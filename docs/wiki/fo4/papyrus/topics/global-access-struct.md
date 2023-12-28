### Sample: Global access to a Papyrus struct instance
This sample demonstrates global access to an instance of a Papyrus `Struct`.
A Papyrus `Struct` is a reference type, meaning `DataStruct::Text` and `DataStruct::Number` should update as references do.

It requires that you bind the script to some start game enabled quest.
- Replace `0x00000000` with the "Form ID" of the Quest you bind this script to.
- Replace `MyPlugin.esp` with your actual plugin name.


```papyrus
ScriptName MyQuestScript extends Quest

Struct DataStruct
    string Text = ""
    int Number = 0
EndStruct

DataStruct Property Data Auto

Event OnInit()
    Data = new DataStruct
    Data.Text = "Hello World!"
    Data.Number = 42
EndEvent

MyQuestScript Function Get() Global
    Quest qust = Game.GetFormFromFile(0x00000000, "MyPlugin.esp") as Quest
    if (qust)
        return qust as MyQuestScript
        EndIf
    EndIf

    ; Something went wrong..
    return  none
EndFunction

DataStruct Function GetData() Global
    MyQuestScript script = MyQuestScript.Get()
    if (script)
        return script.Data
    EndIf

    ; Something went wrong..
    return  none
EndFunction
```
