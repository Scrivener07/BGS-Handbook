---
---
# TextEntry
`TextEntry.as` is part of the `Components` package and provides a text entry component for use with Flash-based applications.
It extends the functionality of `MovieClip` and allows the user to input and retrieve text.

## Class Definition

```as3
package Components {
    import Shared.GlobalFunc;
    import flash.display.MovieClip;
    import flash.text.TextField;

    public class TextEntry extends MovieClip {
        // ... [Class Members]
    }
}
```

## Class Members

### Public Variables

| Variable Name          | Type        | Description                                    |
| ---------------------- | ----------- | ---------------------------------------------- |
| **TextEntryAnim_mc**   | MovieClip   | MovieClip that contains the animation for text entry. |
| **TextEntryBackground_mc** | MovieClip | MovieClip that represents the background for text entry. |

### Private Variables

| Variable Name         | Type    | Description                                       |
| --------------------- | ------- | ------------------------------------------------- |
| **bUseBackground**    | Boolean | Indicates whether to use the background MovieClip. |

## Public Functions

### Constructor

```as3
public function TextEntry() {
    super();
    addFrameScript(0,this.frame1,12,this.frame13,24,this.frame25);
}
```
Initializes the text entry component and adds frame scripts.

### **useBackground** (Setter)
```as3
public function set useBackground(param1:Boolean) : * {
    // Implementation
}
```
Sets whether the background should be visible.

### **GetEnteringText**
```as3
public function GetEnteringText() : Boolean {
    // Implementation
}
```
Returns `true` if the text entry field is currently focused.

### **GetText**
```as3
public function GetText() : String {
    // Implementation
}
```
Retrieves the text from the text entry field.

### **FadeIn**
```as3
public function FadeIn() : * {
    // Implementation
}
```
Executes the fade-in animation and sets the focus on the text entry field.

### **FadeOut**
```as3
public function FadeOut() : * {
    // Implementation
}
```
Executes the fade-out animation.

### **SetTitleText**
```as3
public function SetTitleText(param1:String) : * {
    // Implementation
}
```
Sets the title text for the text entry field.

## Private Functions

### **frame1**
```as3
function frame1() : * {
    // Implementation
}
```
Stops the animation in the first frame.

### **frame13**
```as3
function frame13() : * {
    // Implementation
}
```
Stops the animation in the 13th frame.

### **frame25**
```as3
function frame25() : * {
    // Implementation
}
```
Stops the animation in the 25th frame.


## Usage Example
To use the `TextEntry` component, create an instance of the class and add it to the stage.
You can configure the background visibility and set the title text.

Here's how to create an instance and configure it:

```as3
var textEntryComponent:TextEntry = new TextEntry();
textEntryComponent.useBackground = true; // Show background
textEntryComponent.SetTitleText("Enter your name:");
addChild(textEntryComponent); // Add to stage
```

Invoke `FadeIn` to show the text entry with animation:
```as3
textEntryComponent.FadeIn();
```

To retrieve the entered text:
```as3
var userInput:String = textEntryComponent.GetText();
```

## 📄 Additional Notes
- Ensure that the `Shared.GlobalFunc` class and related `TextField` instances are properly set up in the project.
- Animation labels such as `"FadeIn"` and `"FadeOut"` must exist within the `MovieClip` timeline for the corresponding functions to work.
- The maximum number of characters allowed in the text field is set to 26 in the `FadeIn` function.
- The `SetTitleText` function assumes that a `TitleText_tf` TextField exists within the `TextEntryAnim_mc` MovieClip.
