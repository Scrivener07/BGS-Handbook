---
---
# InputEvent
The `InputEvent` class is a custom event type used within the `scaleform.clik.events` package, which is part of the Scaleform CLIK (Common Lightweight Input Keyboard) UI toolkit for Flash.
It extends the native Flash `Event` class and is designed to handle input details in user interface elements.

## File Details

- **Filename**: InputEvent.as

## Class Definition

```actionscript
package scaleform.clik.events {
    import flash.events.Event;
    import scaleform.clik.ui.InputDetails;

    public class InputEvent extends Event {

        public static const INPUT:String = "input";
        public var details:InputDetails;

        public function InputEvent(param1:String, param2:InputDetails) {
            super(param1,true,true);
            this.details = param2;
        }

        public function get handled() : Boolean {
            return isDefaultPrevented();
        }

        public function set handled(param1:Boolean) : void {
            if(param1) {
                preventDefault();
            }
        }

        override public function clone() : Event {
            return new InputEvent(type, this.details);
        }

        override public function toString() : String {
            return formatToString("InputEvent", "type", "details");
        }
    }
}
```

## Properties and Methods

### Static Constants

| Name     | Type     | Description                       |
|----------|----------|-----------------------------------|
| `INPUT`  | `String` | The constant defining input event |

### Public Variables

| Variable  | Type          | Description                         |
|-----------|---------------|-------------------------------------|
| `details` | `InputDetails`| An object containing input details |

### Constructor

| Constructor                     | Parameters                          | Description                                     |
|---------------------------------|-------------------------------------|-------------------------------------------------|
| `InputEvent(param1, param2)`    | `param1: String`, `param2: InputDetails` | Initializes a new InputEvent with the specified type and input details |

### Public Methods

| Method                       | Returns | Description                                            |
|------------------------------|---------|--------------------------------------------------------|
| `handled()`                  | `Boolean`| Getter that tells if the event has been handled       |
| `handled(param1)`            | `void`  | Setter that marks the event as handled if `param1` is true |
| `clone()`                    | `Event` | Creates a clone of the InputEvent instance            |
| `toString()`                 | `String`| Returns a string representation of the InputEvent instance |

## Usage

The `InputEvent` class is generally used within the Scaleform CLIK framework to dispatch events that represent user input. `details` property carries information about input such as the key code, the state of the input (press, hold, release), and the controller index.

### Event Handling Example

```actionscript
function onInputEvent(e:InputEvent):void {
    // Check if the input has been handled
    if (!e.handled) {
        // Handle the input event
        trace("Input type:", e.details.value);

        // Mark the event as handled
        e.handled = true;
    }
}

// Add the event listener for the InputEvent.INPUT type
someComponent.addEventListener(InputEvent.INPUT, onInputEvent);
```

This example demonstrates how to listen to and handle an `InputEvent` within a component. Upon receiving the event, it checks whether it has already been handled before proceeding to process the input details. After processing, it marks the event as handled to prevent other listeners from handling it again.

_**Note**: The actual usage of this class may vary depending on the UI framework and game engine integration specifics._
