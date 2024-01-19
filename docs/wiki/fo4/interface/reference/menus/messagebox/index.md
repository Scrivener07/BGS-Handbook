---
title: "MessageBoxMenu"
---

The `MessageBoxMenu` is used to display the content of a Creation Kit [`Message`](https://falloutck.uesp.net/wiki/Message) object.
A `Message` object is normally shown by calling the [Message.Show()](https://falloutck.uesp.net/wiki/Show_-_Message) Papyrus function.

The `MessageBoxMenu` is also used to display scripted debug text using the Papyrus function [Debug.MessageBox()](https://falloutck.uesp.net/wiki/MessageBox_-_Debug).
When the menu is started by the debug function it will display a single-button "OK" message box containing the specified text.


#### Components

- [ItemList](/wiki/fo4/interface/reference/components/ItemList.html)


#### Display
```
stage
0: root1                 --> [object MovieClip]
   0: Menu_mc            --> [object MessageBoxMenu]
      0: List_mc         --> [object MessageBoxButtonList]
         0: ScrollDown   --> [object MovieClip]
            0: instance1 --> [object Shape]
         1: ScrollUp     --> [object MovieClip]
            0: instance2 --> [object Shape]
         2: instance3    --> [object MovieClip]
         3: border       --> [object MovieClip]
            0: instance4 --> [object Shape]
      1: Body_tf         --> [object TextField]
      2: BGRectBlack_mc  --> [object MovieClip]
         0: instance5    --> [object Shape]
      3: BGRect_mc       --> [object MovieClip]
         0: instance6    --> [object Shape]
```


#### BGSCodeObj
```
MessageBoxMenu.BGSCodeObj
[object Object]
--- onButtonPress : function Function() {}
--- PlayFocusSound : function Function() {}
```


#### Creation Kit

- <https://falloutck.uesp.net/wiki/Message>
- <https://falloutck.uesp.net/wiki/Message_Script>
- <https://falloutck.uesp.net/wiki/MessageBox_-_Debug>
- <https://falloutck.uesp.net/wiki/Text_Replacement>
- <https://falloutck.uesp.net/wiki/Button_Tag_Replacement>


#### Note on `initDisableInputCounter`

This method is a frame enter event that occurs 4 times.
This is used as a count down timer to disable list input after 4 *frames*.
