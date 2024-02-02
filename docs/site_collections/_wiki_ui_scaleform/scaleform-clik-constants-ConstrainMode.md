# ConstrainMode
The `ConstrainMode.as` file contains a class that provides constants for different constraint modes in the Scaleform CLIK (Common Lightweight Interface Kit) library.
Below is the detailed documentation of the `ConstrainMode` class, which is part of the `scaleform.clik.constants` package.

## Class Definition

```as3
package scaleform.clik.constants {
    public class ConstrainMode {
        public static const COUNTER_SCALE:String = "counterScale";
        public static const REFLOW:String = "reflow";

        public function ConstrainMode() {
            super();
        }
    }
}
```

## Constants

The `ConstrainMode` class defines the following static constants:

| Constant         | Type    | Description                                                            |
|------------------|---------|------------------------------------------------------------------------|
| COUNTER_SCALE    | String  | A mode that applies counter scaling to the constrained display object. |
| REFLOW           | String  | A mode that causes the constrained display object to reflow.           |

### Usage Example

To utilize these constants, you would typically access them through the class name, as they are static properties of the `ConstrainMode` class.
Below is an example of how to use these constants in your code:

```as3
import scaleform.clik.constants.ConstrainMode;

function setConstraintMode(mode:String):void {
    switch (mode) {
        case ConstrainMode.COUNTER_SCALE:
            // Implementation for counter scale mode
            break;
        case ConstrainMode.REFLOW:
            // Implementation for reflow mode
            break;
        default:
            throw new Error("Invalid constraint mode");
    }
}
```

**Note**: The `ConstrainMode` class does not contain any instance methods or properties, except for its constructor.
Since the constructor does not perform any specific action other than calling `super()`, it is not common to instantiate this class.
The primary use of `ConstrainMode` is to access its static constants.
