---
title: "HeaderArrow"
categories: fo4 interface menus container
---

The `HeaderArrow` class extends the `MovieClip` class and is designed to dispatch a custom event when a mouse-up event is detected on an instance of this class.

## Class Definition
```actionscript
package {
    import flash.display.MovieClip;
    import flash.events.Event;
    import flash.events.MouseEvent;

    public class HeaderArrow extends MovieClip {
        ...
    }
}
```

## Public Constants

| Constant | Type | Description |
|----------|------|-------------|
| `MOUSE_UP` | `String` | A custom event type string for the mouse up event. |

## Constructor
The constructor of the `HeaderArrow` class is where the instance adds an event listener for the `MouseEvent.MOUSE_UP` event.

```actionscript
public function HeaderArrow() {
    super();
    addEventListener(MouseEvent.MOUSE_UP, this.onMouseUp);
}
```

## Event Handlers
### `onMouseUp`
When a mouse-up event is detected on the `HeaderArrow` instance, this handler dispatches a custom event with the type `MOUSE_UP`.

```actionscript
public function onMouseUp(event:MouseEvent) : void {
    dispatchEvent(new Event(MOUSE_UP, true, true));
}
```

## Usage

**To create an instance of `HeaderArrow`:**
```actionscript
var headerArrow:HeaderArrow = new HeaderArrow();
this.addChild(headerArrow);
```

**To listen to the custom `MOUSE_UP` event:**
```actionscript
headerArrow.addEventListener(HeaderArrow.MOUSE_UP, onHeaderArrowMouseUp);

function onHeaderArrowMouseUp(event:Event):void {
    // Handle the mouse up event
}
```

## 💡 Tips
- **Event Bubbling:** The custom `MOUSE_UP` event is set to bubble, which means the event will propagate up through the display list.
- **Event Cancelable:** The custom `MOUSE_UP` event is set to be cancelable, allowing listeners to prevent any default behavior associated with the event.

## 👀 Notes
- Be mindful to remove event listeners and properly dispose of `HeaderArrow` instances to prevent memory leaks.
- This class assumes that there will be a visual representation in the `MovieClip` that will respond to mouse events. Make sure your `HeaderArrow` MovieClip has the appropriate graphics or interactive elements.

**Bold** & **Emojis** have been used throughout this document for emphasis and readability.
