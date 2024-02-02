# InputValue
The `InputValue` class within the `scaleform.clik.constants` package is a simple class that defines constants representing various states of keyboard input.
These constants can be used to identify the type of keyboard interaction occurring, such as a key being pressed down, released, or held down.

## Constants

Below is a table with a description of each constant within the `InputValue` class:

| Constant   | Type   | Description                         |
|------------|--------|-------------------------------------|
| KEY_DOWN   | String | Represents a key press event.       |
| KEY_UP     | String | Represents a key release event.     |
| KEY_HOLD   | String | Represents a key being held down.   |

## Code Example

Here is how the `InputValue` class is structured in the `InputValue.as` file:

```actionscript
package scaleform.clik.constants {

    public class InputValue {

        /** Represents a key press event. */
        public static const KEY_DOWN:String = "keyDown";

        /** Represents a key release event. */
        public static const KEY_UP:String = "keyUp";

        /** Represents a key being held down. */
        public static const KEY_HOLD:String = "keyHold";

        /** Constructor for the InputValue class. */
        public function InputValue() {
            super();
        }

    }

}
```

## Usage Example

To use the `InputValue` constants, you would typically check the type of key event in your input handling function. Here's an example of how you might use these constants:

```actionscript
import scaleform.clik.constants.InputValue;

function handleInput(type:String, keyCode:int):void {
    switch(type) {
        case InputValue.KEY_DOWN:
            // Handle key down event
            trace("Key Down: " + keyCode);
            break;
        case InputValue.KEY_UP:
            // Handle key up event
            trace("Key Up: " + keyCode);
            break;
        case InputValue.KEY_HOLD:
            // Handle key hold event
            trace("Key Hold: " + keyCode);
            break;
    }
}
```

In the above example, the `handleInput` function checks the input type and performs an action accordingly, using the constants defined in the `InputValue` class.

## Notes

- The `InputValue` class is best utilized in the context of keyboard input handling within the Scaleform CLIK (Common Lightweight Interface Kit) framework.
- The constants should be used to ensure consistent handling of input across different parts of an application or game.

Feel free to integrate these constants into your projects to help manage and interpret keyboard input events consistently! 🎮
