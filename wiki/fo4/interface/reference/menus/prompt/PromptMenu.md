# PromptMenu Documentation

## **Overview**

The `PromptMenu` class extends `IMenu` and is used to display a prompt in a user interface within a Flash-based project.
The prompt communicates messages to users, and it can also include button prompts that correspond to user actions.

---

## **Class Definition**

**Filename:** `PromptMenu.as`

```actionscript
package {
    import Shared.AS3.BSUIComponent;
    import Shared.GlobalFunc;
    import Shared.IMenu;
    import flash.display.MovieClip;
    import flash.text.TextField;
    import flash.text.TextFieldAutoSize;

    public class PromptMenu extends IMenu {
        public var BGSCodeObj:Object;
        public var PromptMenuPanel_mc:MovieClip;

        public function PromptMenu() {
            super();
            this.BGSCodeObj = new Object();
        }

        override protected function onSetSafeRect() : void {
            GlobalFunc.LockToSafeRect(this.PromptMenuPanel_mc, "TL", SafeX, SafeY);
        }

        public function set message(param1:String) : * {
            var _loc5_:Array = null;
            var _loc2_:BSUIComponent = this.PromptMenuPanel_mc.MessageHolder_mc as BSUIComponent;
            var _loc3_:TextField = _loc2_.textField;
            _loc3_.autoSize = TextFieldAutoSize.LEFT;

            var _loc4_:Array = param1.split("[");
            if (_loc4_.length > 1) {
                _loc5_ = _loc4_[1].split("]");
                GlobalFunc.SetText(_loc3_, _loc4_[0] + this.BGSCodeObj.getButtonFromUserEvent(_loc5_[0]) + _loc5_[1], true);
            } else {
                GlobalFunc.SetText(_loc3_, param1, true);
            }

            _loc2_.SetIsDirty();
        }

        public function onCodeObjDestruction() : * {
            this.BGSCodeObj = null;
        }
    }
}
```

---

## **Properties**

| Property           | Type       | Description                          |
|--------------------|------------|--------------------------------------|
| `BGSCodeObj`       | `Object`   | Object used for code-related functionality. |
| `PromptMenuPanel_mc` | `MovieClip` | MovieClip instance containing the prompt menu visuals and layout. |

---

## **Methods**

### **PromptMenu**
The constructor method initializes the `PromptMenu` instance.

```actionscript
public function PromptMenu() {
    super();
    this.BGSCodeObj = new Object();
}
```

### **onSetSafeRect**
Overrides the `onSetSafeRect` method to lock the PromptMenuPanel to the safe rectangle of the screen.

```actionscript
override protected function onSetSafeRect() : void {
    GlobalFunc.LockToSafeRect(this.PromptMenuPanel_mc, "TL", SafeX, SafeY);
}
```

### **set message**
A setter method to define the prompt message to be displayed to the user. It supports button prompts through square brackets notation.

```actionscript
public function set message(param1:String) : * {
    // Method implementation...
}
```

### **onCodeObjDestruction**
A method to handle the destruction of the `BGSCodeObj` reference, ensuring it is cleaned up properly.

```actionscript
public function onCodeObjDestruction() : * {
    this.BGSCodeObj = null;
}
```

---

## **Usage Example**
To use the `PromptMenu` instance, you would typically instantiate it within a Flash-based application's User Interface code.
After creating an instance, you set its message property to display a prompt on the screen:

```actionscript
var promptMenu:PromptMenu = new PromptMenu();
promptMenu.message = "Press [A] to start.";
```

---

## **Notes**
- The `PromptMenu` class appears to be designed specifically for a game or application that uses Flash for its UI, which is commonly seen in Bethesda Game Studios projects.
- The message setter method interprets a string with square brackets to replace the bracketed content with a corresponding button prompt. This suggests that the UI might change the text dynamically based on the user's input device (e.g., changing "[A]" to the appropriate button on a gamepad or keyboard).
- It is important to note that Adobe Flash reached its end-of-life at the end of 2020, and many browsers no longer support Flash content. As a result, for new projects, alternative technologies should be considered.
