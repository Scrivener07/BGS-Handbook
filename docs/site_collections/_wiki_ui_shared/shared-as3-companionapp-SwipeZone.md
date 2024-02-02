---
---
# SwipeZone
The `SwipeZone` class belongs to the `Shared.AS3.COMPANIONAPP` package and is built for handling swipe gestures within a specified area on the display object.
It extends the `EventDispatcher` class to allow the dispatching of events when a swipe is detected.

## Class Definition

```actionscript
package Shared.AS3.COMPANIONAPP {
    import flash.display.DisplayObject;
    import flash.events.Event;
    import flash.events.EventDispatcher;
    import flash.events.MouseEvent;
    import flash.geom.Point;
    import flash.geom.Rectangle;

    public class SwipeZone extends EventDispatcher {
        ...
    }
}
```

## Public Constants

### Swipe Direction

| Constant             | Type    | Value | Description      |
|----------------------|---------|-------|------------------|
| `SWIPE_NEXT`         | String  | "SwipeNext" | Event dispatched when a next swipe is detected. |
| `SWIPE_PREV`         | String  | "SwipePrev" | Event dispatched when a previous swipe is detected. |
| `HORIZONTAL`         | uint    | 0     | Horizontal swipe direction. |
| `VERTICAL`           | uint    | 1     | Vertical swipe direction. |

---

## Protected Properties

| Property                                  | Type            | Description                                        |
|-------------------------------------------|-----------------|----------------------------------------------------|
| `_container`                              | DisplayObject   | The display object that the swipe zone is attached to. |
| `_zone`                                   | Rectangle       | The area within the container that listens for swipe gestures. |
| `_mousePressPoint`                        | Point           | Coordinates where the mouse was pressed.           |
| `_lastValidMousePoint`                    | Point           | Last known valid mouse coordinates.               |
| `_isPressed`                              | Boolean         | Flag indicating whether the mouse is currently pressed. |
| `_direction`                              | uint            | Swipe direction - `HORIZONTAL` or `VERTICAL`.     |
| `MIN_SWIPE_DISTANCE`                      | Number          | Minimum distance in pixels to be considered a swipe. |
| `MAX_SWIPE_OPPOSITE_DIRECTION_RATIO`      | Number          | Maximum ratio of movement in the opposite direction to still consider it a valid swipe. |

---

## Constructor

```actionscript
public function SwipeZone(param1:DisplayObject, param2:Rectangle = null, param3:uint = 0) {
    ...
}
```

- **param1**: The display object for the swipe zone.
- **param2**: (Optional) The rectangle defining the swipe area within the display object.
- **param3**: (Optional) The direction of swipe to listen for. Default is `HORIZONTAL`.

---

## Public Methods

### activate

**Description**: Activates the swipe zone to start listening for swipe gestures.

```actionscript
public function activate() : void {
    ...
}
```

### deactivate

**Description**: Deactivates the swipe zone to stop listening for swipe gestures.

```actionscript
public function deactivate() : void {
    ...
}
```

---

## Protected Methods

### mousePressHandler

**Description**: Handles the mouse press event, initializing the press point and setting the `_isPressed` flag.

```actionscript
protected function mousePressHandler(param1:MouseEvent) : void {
    ...
}
```

### mouseMoveHandler

**Description**: Handles the mouse move event, updating the last valid mouse point.

```actionscript
protected function mouseMoveHandler(param1:MouseEvent) : void {
    ...
}
```

### mouseReleaseHandler

**Description**: Handles the mouse release event, determines if a swipe has occurred, and dispatches the appropriate event.

```actionscript
protected function mouseReleaseHandler(param1:MouseEvent) : void {
    ...
}
```

---

## Swipe Detection

The `SwipeZone` class determines a swipe based on the distance moved in the preferred direction compared to the minimum swipe distance (`MIN_SWIPE_DISTANCE`). If a swipe is detected, it dispatches the relevant event (`SWIPE_NEXT` or `SWIPE_PREV`) based on the movement direction.

## Example Usage

**Activating SwipeZone**

```actionscript
var mySwipeZone:SwipeZone = new SwipeZone(myDisplayObject);
mySwipeZone.activate();
```

**Listening for a swipe event**

```actionscript
mySwipeZone.addEventListener(SwipeZone.SWIPE_NEXT, onSwipeNext);
mySwipeZone.addEventListener(SwipeZone.SWIPE_PREV, onSwipePrev);

function onSwipeNext(event:Event):void {
    // Handle next swipe
}

function onSwipePrev(event:Event):void {
    // Handle previous swipe
}
```

**Deactivating SwipeZone**

```actionscript
mySwipeZone.deactivate();
```

---

## Note

🔔 It's important to properly activate and deactivate the `SwipeZone` instance to manage resources and event listeners effectively. Always remove event listeners when not needed to avoid memory leaks.

**Bold** the relevant text within the documentation as needed to emphasize important aspects of the code such as method names, property names, and event types.
