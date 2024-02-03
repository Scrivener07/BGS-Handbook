---
---
# MouseEventEx
The `MouseEventEx` class is an extension of the `MouseEvent` class within the `scaleform.gfx` package.
It provides additional information about mouse events, specifically tailored for Scaleform implementations.

## Contents
- [Class Definition](#class-definition)
- [Constants](#constants)
- [Properties](#properties)
- [Constructor](#constructor)
- [Example Usage](#example-usage)

## Class Definition

```as3
package scaleform.gfx {
    import flash.events.MouseEvent;

    public final class MouseEventEx extends MouseEvent {
        // Constants and properties are defined here
    }
}
```

## Constants

`MouseEventEx` defines constants to represent the specific mouse buttons. These constants are used to easily identify which mouse button is pressed.

| Constant         | Value | Description       |
| ---------------- | ----- | ----------------- |
| `LEFT_BUTTON`    | 0     | The left button   |
| `RIGHT_BUTTON`   | 1     | The right button  |
| `MIDDLE_BUTTON`  | 2     | The middle button |

## Properties

The class includes several properties that provide additional details about the mouse event:

| Property    | Type  | Description                                     |
| ----------- | ----- | ----------------------------------------------- |
| `mouseIdx`  | uint  | The index of the mouse that triggered the event |
| `nestingIdx`| uint  | The index of nesting level                      |
| `buttonIdx` | uint  | The index of the button that was pressed        |

## Constructor

The constructor for `MouseEventEx` takes in a single parameter which specifies the type of event.

```as3
public function MouseEventEx(param1:String) {
    super(param1);
}
```

**Parameters:**
- `param1`: A string representing the type of mouse event.

## Example Usage

Here is an example of how you might use the `MouseEventEx` class in your code.

```as3
import scaleform.gfx.MouseEventEx;

function handleMouseEvent(event:MouseEventEx):void {
    if(event.buttonIdx == MouseEventEx.LEFT_BUTTON) {
        trace("Left button clicked.");
    } else if(event.buttonIdx == MouseEventEx.RIGHT_BUTTON) {
        trace("Right button clicked.");
    } else if(event.buttonIdx == MouseEventEx.MIDDLE_BUTTON) {
        trace("Middle button clicked.");
    }
}

// Add event listener for mouse events
addEventListener(MouseEventEx.CLICK, handleMouseEvent);
```

📝 **Filename:** `MouseEventEx.as`

**Bold** elements are used to provide emphasis on important parts of the documentation. This markdown documentation utilizes tables for structured data representation, code blocks for code segments, lists for content organization and emojis for an engaging presentation.
