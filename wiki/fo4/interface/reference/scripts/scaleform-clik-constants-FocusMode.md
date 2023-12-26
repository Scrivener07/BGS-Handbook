# FocusMode.as Documentation

The `FocusMode.as` file contains a public class `FocusMode` within the `scaleform.clik.constants` package.
This class defines several constants that represent different focus modes.
These constants can be used to configure how focus is handled within an application.

## Constants

The `FocusMode` class defines the following constants:

| Constant      | Value                 | Description                                     |
| ------------- | --------------------- | ----------------------------------------------- |
| **LOOP**      | `"loop"`              | Focus can loop around.                          |
| **DEFAULT**   | `"default"`           | The default focus mode.                         |
| **VERTICAL**  | `"focusModeVertical"` | Focus movement is constrained to the vertical.  |
| **HORIZONTAL**| `"focusModeHorizontal"`| Focus movement is constrained to the horizontal.|

### Code snippet

```actionscript
package scaleform.clik.constants {

    public class FocusMode {
        public static const LOOP:String = "loop";
        public static const DEFAULT:String = "default";
        public static const VERTICAL:String = "focusModeVertical";
        public static const HORIZONTAL:String = "focusModeHorizontal";

        public function FocusMode() {
            super();
        }
    }
}
```

## Usage

To use one of these constants, you can refer to them through the class name followed by the constant name.

For example:

```actionscript
import scaleform.clik.constants.FocusMode;

var currentFocusMode:String = FocusMode.DEFAULT;
```

## Constructor

The `FocusMode` class constructor does nothing beyond calling the constructor of the superclass.

```actionscript
public function FocusMode() {
    super();
}
```

## Notes

- This class is part of the Scaleform CLIK (Common Lightweight Interface Kit), which is a UI development kit for games.
- The `FocusMode` class cannot be instantiated, as it is meant to provide constants only.
- The file is named `FocusMode.as` and should be placed in the `scaleform/clik/constants` directory of your ActionScript 3.0 project.

Remember to always reference the appropriate constant when configuring focus behavior to maintain readability and avoid "magic strings" in your codebase!
