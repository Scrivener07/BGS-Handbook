# Button
The `Button` class in the Scaleform CLIK framework is designed to provide interactive button functionality for user interfaces in Flash-based applications, particularly in video game HUDs.
Below is a comprehensive documentation of the `Button` class, detailing its properties, methods, and usage.

## Table of Contents
- [Class Overview](#class-overview)
- [Public Properties](#public-properties)
- [Protected Properties](#protected-properties)
- [Public Methods](#public-methods)
- [Protected Methods](#protected-methods)
- [Events](#events)

## Class Overview

```actionscript
package scaleform.clik.controls {
    // Import statements...

    public class Button extends UIComponent {
        // Class body...
    }
}
```

### **Public Properties**

| Property | Type | Description |
|----------|------|-------------|
| `lockDragStateChange` | Boolean | Prevents state changes on the button while dragging. |
| `repeatDelay` | Number | The initial delay before auto-repeat begins (in milliseconds). |
| `repeatInterval` | Number | The interval between auto-repeats (in milliseconds). |
| `constraintsDisabled` | Boolean | Disables resizing constraints if set to true. |
| `allowDeselect` | Boolean | Allows the button to be deselected if set to true. |
| `preventAutosizing` | Boolean | Prevents the button from auto-resizing if set to true. |
| `textField` | TextField | The `TextField` instance used to display the button's label. |
| `defaultTextFormat` | TextFormat | The default text format for the button's label. |

### **Protected Properties**

| Property | Type | Description |
|----------|------|-------------|
| `\_toggle` | Boolean | Indicates if the button is toggleable. |
| `\_label` | String | The label text of the button. |
| `\_state` | String | The current state of the button. |
| `\_group` | ButtonGroup | The group this button belongs to, if any. |
| `\_groupName` | String | The group name this button belongs to, if any. |
| `\_selected` | Boolean | Indicates if the button is currently selected. |
| `\_data` | Object | The data associated with the button. |
| `\_autoRepeat` | Boolean | Indicates if the button should auto-repeat when held down. |
| `\_autoSize` | String | The auto-size setting for the button. |
| `\_pressedByKeyboard` | Boolean | Indicates if the button was pressed by the keyboard. |
| `\_isRepeating` | Boolean | Indicates if the button is currently in the repeating state. |
| `\_owner` | UIComponent | The owner of this button. |
| `\_stateMap` | Object | The mapping of states to frame labels. |
| `\_newFrame` | String | The new frame to go to after state change. |
| `\_newFocusIndicatorFrame` | String | The new frame for the focus indicator. |
| `\_repeatTimer` | Timer | The timer used for auto-repeating. |
| `\_mouseDown` | int | The state of mouse buttons. |
| `\_focusIndicatorLabelHash` | Object | The hash of focus indicator labels. |
| `\_autoRepeatEvent` | ButtonEvent | The event to dispatch on auto-repeat. |
| `\_focusIndicator` | MovieClip | The focus indicator movie clip. |
| `statesDefault` | Vector.<String> | The default state prefixes vector. |
| `statesSelected` | Vector.<String> | The selected state prefixes vector. |

### **Public Methods**

| Method | Return Type | Description |
|--------|-------------|-------------|
| `Button()` |  | Constructor method for creating a new `Button` instance. |
| `get data()` | Object | Returns the data associated with the button. |
| `set data(param1)` | void | Sets the data associated with the button. |
| `get autoRepeat()` | Boolean | Returns if the button auto-repeat is enabled. |
| `set autoRepeat(param1)` | void | Sets the auto-repeat behavior of the button. |
| ... | | (Additional getters and setters are defined for various properties) |

### **Protected Methods**

| Method | Return Type | Description |
|--------|-------------|-------------|
| `addToAutoGroup(param1)` | void | Adds the button to an automatically managed group. |
| `checkOwnerFocused()` | Boolean | Checks if the button's owner is focused. |
| `calculateWidth()` | Number | Calculates the correct width of the button. |
| `alignForAutoSize()` | void | Aligns the button for auto-sizing. |
| `updateText()` | void | Updates the text of the button label. |
| ... | | (Additional protected methods handle state transitions, input, and other internal behaviors) |

### **Events**

The `Button` class dispatches various events to signal state changes and interactions.

- **Event.SELECT**: Dispatched when the selection state changes.
- **ButtonEvent.PRESS**: Dispatched when the button is pressed.
- **ButtonEvent.CLICK**: Dispatched when the button is clicked.
- **ButtonEvent.RELEASE_OUTSIDE**: Dispatched when the button is released outside of its bounds.
- **ButtonEvent.DRAG_OVER**: Dispatched when the button is dragged over.
- **ButtonEvent.DRAG_OUT**: Dispatched when the button is dragged out.
- Additional internal events are used to handle focusing, input, and state changes.

## Example Usage

```actionscript
var myButton:Button = new Button();
myButton.label = "Click Me!";
myButton.toggle = true; // Makes the button toggleable
myButton.addEventListener(Event.SELECT, handleButtonSelect);
addChild(myButton);

function handleButtonSelect(e:Event):void {
    trace("Button selected: " + myButton.selected);
}
```

To use the `Button` class, import it into your ActionScript file, create an instance, set its properties, add event listeners as needed, and then add it to the display list.
