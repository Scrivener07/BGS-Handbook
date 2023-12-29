---
title: "Option_Scrollbar"
---

The `Option_Scrollbar` AS3 (ActionScript 3.0) class provides functionality to create a custom scrollbar within a Flash application.
This class extends the `MovieClip` class, and includes interactivity through mouse and keyboard events.

## Class Structure
### Filename
`Option_Scrollbar.as`

### Package
```as3
package {
    // Import statements
    ...
    // Option_Scrollbar class definition
    public class Option_Scrollbar extends MovieClip {
        ...
    }
}
```

### Class Definition

```as3
public class Option_Scrollbar extends MovieClip {
    ...
}
```

## Properties

| Property           | Type         | Description                                           |
|--------------------|--------------|-------------------------------------------------------|
| `VALUE_CHANGE`     | `String`     | Static const representing the change in scrollbar value. |
| `Track_mc`         | `MovieClip`  | Represents the track of the scrollbar.                |
| `Thumb_mc`         | `MovieClip`  | Represents the draggable thumb of the scrollbar.      |
| `LeftArrow_mc`     | `MovieClip`  | Represents a clickable left arrow for decrementing the value. |
| `RightArrow_mc`    | `MovieClip`  | Represents a clickable right arrow for incrementing the value. |
| `LeftCatcher_mc`   | `MovieClip`  | Invisible area to detect clicks for decrementing the value. |
| `RightCatcher_mc`  | `MovieClip`  | Invisible area to detect clicks for incrementing the value. |
| `BarCatcher_mc`    | `MovieClip`  | Invisible area to detect clicks on the track bar for setting the value directly. |

## Methods

### Constructor
```as3
public function Option_Scrollbar() {
    ...
}
```
Initializes the scrollbar properties and event listeners.

### Public Methods

| Method              | Return Type | Description                                                |
|---------------------|-------------|------------------------------------------------------------|
| `Decrement`         | `*`         | Decrements the value by the step size.                     |
| `Increment`         | `*`         | Increments the value by the step size.                     |
| `HandleKeyboardInput` | `*`       | Handles keyboard input for left and right arrow keys.      |

### Events

| Event             | Associated Method   | Description                                      |
|-------------------|---------------------|--------------------------------------------------|
| `MouseEvent.CLICK`| `onClick`           | Handles click events for the scrollbar components. |
| `MouseEvent.MOUSE_DOWN` | `onThumbMouseDown` | Handles the thumb drag operation.               |
| `MouseEvent.MOUSE_UP` | `onThumbMouseUp`   | Stops the thumb drag operation.                   |
| `MouseEvent.MOUSE_MOVE` | `onThumbMouseMove` | Tracks mouse movement and updates the value during drag. |

### Event Dispatched
```as3
dispatchEvent(new Event(VALUE_CHANGE,true,true));
```
Dispatched when the value of the scrollbar is changed through interaction.

## Usage

### Creating an instance of Option_Scrollbar
```as3
var scrollbar:Option_Scrollbar = new Option_Scrollbar();
addChild(scrollbar);
```

### Listening for the VALUE_CHANGE event
```as3
scrollbar.addEventListener(Option_Scrollbar.VALUE_CHANGE, valueChangeHandler);

function valueChangeHandler(event:Event):void {
    trace("Scrollbar value changed!");
}
```

## Example

```as3
package {
    import flash.display.MovieClip;
    import flash.events.Event;
    import flash.events.MouseEvent;
    ...

    public class Option_Scrollbar extends MovieClip {
        ...
        public function Option_Scrollbar() {
            super();
            this.fMinThumbX = this.Track_mc.x;
            ...
            addEventListener(MouseEvent.CLICK, this.onClick);
            ...
        }
        ...
    }
}
```

## Conclusion

The `Option_Scrollbar` class provides a customizable scrollbar with keyboard and mouse interaction capabilities, allowing users to scroll content within Flash applications.
The class can be extended and modified to suit specific design and functionality requirements.
