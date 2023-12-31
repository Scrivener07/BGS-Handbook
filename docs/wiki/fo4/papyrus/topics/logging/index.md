---
title: "Logging"
---

## User Logs
A logging class can be an efficient way to trace information about your mod to help debug issues.
This logging class will automatically open a user log the first time a logging function is called.

The main thing is the `Write` function.
All the rest just format log lines consistently for common messages.

Also a wrapper for `Notification` and `MessageBox` that traces the messages to the user-log and displays them on screen.


### Question: When should I open a log file stream?
You might ask, so when’s the best time to start logging?

I don't directly start the log at all.

I have a dedicated function that will internally open the log the first time it is called.

Further calls to the function will write straight into the opened log.

So technically, if nothing in the code base calls a log function, then it will never open to begin with.

The `Write()` function wrapper gets called the first time.

On this first call to `Write()`, execution hits this line ... `If (Debug.TraceUser(filename, text))`.

The `TraceUser` function return a FALSE bool if the log failed to write or wasn't opened.

So the execution jumps to the `Else` branch, opens the log, and re-calls `Debug.TraceUser(filename, text)`.

Every call to the `Write()` wrapper after this will succeed on the first attempt.

The ``If (Debug.TraceUser(filename, text))`` conditional statement gets called and then immediately returns.

If you choose to use this logging wrapper technique, then I encourage you to customize the `Write()` function to your needs.

The function I posted there can be adapted in many ways.

Like maybe you want to pass the filename as a parameter, or get ride of the pre-formatting that prefixes your message text.

The meat of the function I explained above :slight_smile:

A more pure implementation with no fluff or extras.
```papyrus
bool Function Write(string filename, string text) Global DebugOnly
    {Writes text as lines in the given log file name.}
    If (Debug.TraceUser(filename, text))
        return true
    Else
        Debug.OpenUserLog(filename)
        return Debug.TraceUser(filename, text)
    EndIf
EndFunction
```


### Question: When should I close a log file stream?
You might ask, so when do I close my logs?

I let the game session manager kill the log streams as a mod author.
As a user, you should have debug logging disabled on the INI unless an author tells you to enable it.

As an author, you want all your logging system to light up and just work.

Generally again, as an author it is easier to make sense of what is happening on a users machine when all your systems are pointing to the same log file, especially when sequences of things play a role.

There are time stamps but its difficult to piece together chunks of timestamps spread over many files when a single file you can see at a glance.

The user log versus the main papyrus log can have that issue too sometimes like how Papyrus errors are emitted there and you have to compare that to your user log to see what line the Papyrus error would fit.

A single log file is also easier for users to pass along to an author.
Is is also common to see one mod have a log for each game-system, or for a dedicated part of it that makes sense to isolate.

Ultimately logging is a tool to make your life easier.
Use it the way that makes your life easier 🙂


### Logging Class

```papyrus
ScriptName ExampleMod:Log Const Native Hidden DebugOnly
{Script extensions for Papyrus log tracing.}


bool Function Write(string prefix, string text) Global DebugOnly
	{Writes text as lines in the `ExampleMod.log` log file.}
	string filename = "ExampleMod" const
	text = prefix + " " + text
	If(Debug.TraceUser(filename, text))
		return true
	Else
		Debug.OpenUserLog(filename)
		return Debug.TraceUser(filename, text)
	EndIf
EndFunction


bool Function WriteNotification(string prefix, string text) Global DebugOnly
	{Writes notifications as lines in a log file.}
	Debug.Notification(text)
	return Write(prefix, text)
EndFunction


bool Function WriteMessage(string prefix, string title, string text = "") Global DebugOnly
	{Writes messages as lines in a log file.}
	string value
	If (text)
		value = title+"\n"+text
	EndIf
	Debug.MessageBox(value)
	return Write(prefix, title+" "+text)
EndFunction


; Debug
;---------------------------------------------

bool Function WriteLine(string script, string member, string text = "") Global DebugOnly
	{Writes script info as lines in a log file.}
	If !(text)
		return Write(script, member)
	Else
		return Write(script+"["+member+"]", text)
	EndIf
EndFunction


bool Function WriteUnexpected(string script, string member, string text = "") Global DebugOnly
	{The script had an unexpected operation.}
	return Write(script+"["+member+"]", "The member '"+member+"' had an unexpected operation. "+text)
EndFunction


bool Function WriteUnexpectedValue(string script, string member, string variable, string text = "") Global DebugOnly
	{The script had and unexpected value.}
	return Write(script+"["+member+"."+variable+"]", "The member '"+member+"' with variable '"+variable+"' had an unexpected operation. "+text)
EndFunction


bool Function WriteNotImplemented(string script, string member, string text = "") Global DebugOnly
	{The exception that is thrown when a requested method or operation is not implemented.}
	; The exception is thrown when a particular method, get accessors, or set accessors is present as a member of a type but is not implemented.
	return Write(script, member+": The member '"+member+"' was not implemented. "+text)
EndFunction


Function WriteChangedValue(string script, string propertyName, var fromValue, var toValue) Global DebugOnly
	{The value has changed from one value to another.}
	WriteLine(script, "Changing '"+propertyName+"' from '"+fromValue+"' to '"+toValue+"'.")
EndFunction
```

### Usage

```papyrus
Scriptname ExampleMod:Test

int Number = 10

Event OnInit()
    ; No pre-formatting, used by everything else.
    ExampleMod:Log.Write("Log Line Prefix", "The message text is here.")

    ; Shows a notification AND logs it.
    ExampleMod:Log.WriteNotification("Log Line Prefix", "The message text is here.")

    ; Shows a message-box AND logs it.
    ExampleMod:Log.WriteMessage("Log Line Prefix", "Message Title", "The message text is here.")

    ; Pre-Formatted Lines <script> <member> <message>
    ExampleMod:Log.WriteLine(self, "OnInit", "The message text is here.")

    If ("Some some operation failed or could not be completed..")
        ExampleMod:Log.WriteUnexpected(self, "OnInit", "Something went wrong.")
    EndIf

    If (Number != 11)
        ExampleMod:Log.WriteUnexpectedValue(self, "OnInit", "Number", "The value of "+Number+" is out of range.")
    EndIf

    SetMyValue(5)

    Foo()
EndEvent

Function SetMyValue(int value)
    ExampleMod:Log.WriteChangedValue(self, "Number", Number, value)
    Number = value
EndFunction

Function Foo()
    ExampleMod:Log.WriteNotImplemented(self, "Foo", "This foobar function is not implemented yet.")
    ExampleMod:Log.WriteNotImplemented(self, "Foo", "This function is abstract, override and implement this in an extending script.")
EndFunction
```


### Caution: Rolling Logs
This is an example which shows opening a user log, writing some lines, and then closing it.
When you close a log, you cannot reopen it.

This would initially be written to `Fallout4\Logs\User\ExampleMod.0.log`.

The next time this function runs, your old log will "roll" to `Fallout4\Logs\User\ExampleMod.1.log` and the freshly opened log will become the new `Fallout4\Logs\User\ExampleMod.0.log`.

If the event runs again, another fresh `Fallout4\Logs\User\ExampleMod.0.log` is created and the rolling log rename cascades down.

Now your original log is `Fallout4\Logs\User\ExampleMod.2.log`, the second log is `Fallout4\Logs\User\ExampleMod.1.log`, and the freshly created log is now `Fallout4\Logs\User\ExampleMod.0.log`.

This leads us to a problem.
There is a maximum number of times a log can roll, which I believe is up to `Fallout4\Logs\User\ExampleMod.5.log`, and then it is discarded as not to bloat your storage device.

This can be a problem if your function opens and closes a log 6 or more times as you will end up with missing logs that are discarded in a fraction of a second.
This problem can show itself even in this isolated single function, but become extremely prominent if you have many places with similar code pointing at the same file.

```papyrus
ScriptName ExampleMod:ActorOnKillTest extends Actor

Event OnKill(Actor akVictim)
    Debug.OpenUserLog("ExampleMod")

    ; do work

    Debug.CloseUserLog("ExampleMod")
EndEvent
```
