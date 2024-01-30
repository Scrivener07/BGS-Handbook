---
title: "Papyrus threading during menu mode"
---

You might be in a situation where you have received an F4SE event using `f4se.SendExternalEvent()` from AS3.

You may have hoped to receive the F4SE event in Papyrus to just pop up a message box, but it may not work.
If you end up with a problem where the F4SE event is only received once the player leaves the menu, then this is likely a Papyrus threading issue where script execution is paused during menu-mode.

Now script execution isn't total frozen while in menu-mode, but there are some quirks about what might freeze a thread while the game is in that mode.
I think we might overcome this by calling the script from AS3 differently.

Rather than emitting an external event from AS3 to Papyrus, you might directly invoke a global (static) Papyrus function straight from AS3.
I think this might allow a theoretical global function to run without getting frozen in menu-mode.
What might freeze your thread even if you use a global is if you shift the thread into a different context or by calling a latent functions (functions that don't return until they finish).

If you look at the `f4se` native interface object you will notice another function called `CallFunctionNoWait(String:functionName)`.
I think the parameter uses the same syntax as the similar MCM json where you can call a global Papyrus function.


### A note from user 1000101 (E)
Script execution is not paused in menu mode unless `Utility.Wait()` is called in Fallout 4 and Starfield, only Skyrim and earlier titles pause the VM.
Otherwise scripts will continue to chug along - and usually much faster because the game isn't running AI which eat most CPU time.

That being said, time based events won't fire either (because the clock is stopped).

But currently executing scripts continue to execute (until they hit a `Utility.Wait()` call) and can invoke events - actually, I'm not 100% on other events - the event dispatcher may also be paused but I don't think so.
