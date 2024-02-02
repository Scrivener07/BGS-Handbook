---
---
# KeyboardEventEx
The `KeyboardEventEx` class is an extension of the standard Flash `KeyboardEvent` and is part of the `scaleform.gfx` package.
This class adds functionality for handling keyboard events with an additional property to identify the controller index.

---

## File Details

- **Filename**: `KeyboardEventEx.as`
- **Package**: `scaleform.gfx`

---

## Class Definition

```actionscript
package scaleform.gfx {
    import flash.events.KeyboardEvent;

    public final class KeyboardEventEx extends KeyboardEvent {
        public var controllerIdx:uint = 0;

        public function KeyboardEventEx(param1:String) {
            super(param1);
        }
    }
}
```

---

## Properties

| Property Name  | Type | Description | Default Value |
| -------------- | ---- | ----------- | ------------- |
| `controllerIdx` | `uint` | The index of the controller that generated the keyboard event. | `0` |

---

## Constructor

The `KeyboardEventEx` class constructor takes in one parameter:

| Parameter | Type | Description |
| --------- | ---- | ----------- |
| `param1`  | `String` | The type of the event, accessible as `KeyboardEvent.type`. |

**Example usage**:

```actionscript
var keyboardEvent:KeyboardEventEx = new KeyboardEventEx("keyDown");
keyboardEvent.controllerIdx = 1;
```

---

## Inheritance

The `KeyboardEventEx` class extends **`flash.events.KeyboardEvent`**.

---

## Notes 📝

- The class is marked as `final`, which means it cannot be subclassed.
- The additional `controllerIdx` property can be used to distinguish input from different controllers, which is particularly useful in multi-controller environments such as gaming consoles.

---

## Example Code

```actionscript
import scaleform.gfx.KeyboardEventEx;

function handleKeyboardEvent(event:KeyboardEventEx):void {
    trace("Key event type: " + event.type + " from controller index: " + event.controllerIdx);
}

var eventInstance:KeyboardEventEx = new KeyboardEventEx(KeyboardEvent.KEY_DOWN);
eventInstance.controllerIdx = 1;

handleKeyboardEvent(eventInstance);
```

**Output**:

```
Key event type: keyDown from controller index: 1
```
