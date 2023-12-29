# FocusEventEx
The `FocusEventEx.as` file contains a single class, `FocusEventEx`, within the `scaleform.gfx` package.
This class extends the native `FocusEvent` class provided by Flash's `events` package.

## Class: `FocusEventEx`

The `FocusEventEx` class is a custom event class that includes functionality for handling focus events with an additional property for the controller index.

### **Properties:**

| Property        | Type   | Description                                    |
|-----------------|--------|------------------------------------------------|
| `controllerIdx` | `uint` | Holds the index of the controller (default 0). |

### **Constructor:**

The constructor for `FocusEventEx` takes a single parameter that specifies the type of focus event.

```actionscript
public function FocusEventEx(param1:String) {
    super(param1);
}
```

### **Code Block:**

```actionscript
package scaleform.gfx {

    import flash.events.FocusEvent;

    public final class FocusEventEx extends FocusEvent {

        // Property to keep track of the controller index
        public var controllerIdx:uint = 0;

        // Constructor for the FocusEventEx class
        public function FocusEventEx(param1:String) {
            super(param1);
        }
    }
}
```

### **Usage:**

To use the `FocusEventEx` class, create a new instance and dispatch it from an object that can dispatch events.
The `controllerIdx` can be set to identify which controller initiated the focus event when handling it within your application.

**Example:**

```actionscript
// Create a new FocusEventEx instance
var focusEvent:FocusEventEx = new FocusEventEx(FocusEvent.FOCUS_IN);

// Set the controller index to 1
focusEvent.controllerIdx = 1;

// Dispatch the event from an interactive object
myInteractiveObject.dispatchEvent(focusEvent);
```

### Notes:
- The `FocusEventEx` class is marked `final`, meaning it cannot be subclassed.
- The `controllerIdx` property is unique to the `FocusEventEx` and is not a part of the standard `FocusEvent` class.
- Ensure that the `FocusEventEx` class is imported properly where it is being used.
