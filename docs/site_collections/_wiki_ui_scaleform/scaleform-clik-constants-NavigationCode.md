---
---
# NavigationCode
The `NavigationCode` class, part of the `scaleform.clik.constants` package, provides constants to represent various navigation commands that might be used in a user interface, particularly one that responds to keyboard and gamepad input.

Below is the documentation for the `NavigationCode.as` file.

## Table of Constants

Here is a summary of the constants defined in the `NavigationCode` class:

| Constant           | Value                   | Description                              |
|--------------------|-------------------------|------------------------------------------|
| `UP`               | `"up"`                  | Represents the UP navigation command.    |
| `DOWN`             | `"down"`                | Represents the DOWN navigation command.  |
| `LEFT`             | `"left"`                | Represents the LEFT navigation command.  |
| `RIGHT`            | `"right"`               | Represents the RIGHT navigation command. |
| `START`            | `"start"`               | Represents the START navigation command. |
| `BACK`             | `"back"`                | Represents the BACK navigation command.  |
| `GAMEPAD_A`        | `"enter-gamepad_A"`     | Represents the GAMEPAD A button.         |
| `GAMEPAD_B`        | `"escape-gamepad_B"`    | Represents the GAMEPAD B button.         |
| `GAMEPAD_X`        | `"gamepad_X"`           | Represents the GAMEPAD X button.         |
| `GAMEPAD_Y`        | `"gamepad_Y"`           | Represents the GAMEPAD Y button.         |
| `GAMEPAD_L1`       | `"gamepad_L1"`          | Represents the GAMEPAD L1 button.        |
| `GAMEPAD_L2`       | `"gamepad_L2"`          | Represents the GAMEPAD L2 button.        |
| `GAMEPAD_L3`       | `"gamepad_L3"`          | Represents the GAMEPAD L3 button.        |
| `GAMEPAD_R1`       | `"gamepad_R1"`          | Represents the GAMEPAD R1 button.        |
| `GAMEPAD_R2`       | `"gamepad_R2"`          | Represents the GAMEPAD R2 button.        |
| `GAMEPAD_R3`       | `"gamepad_R3"`          | Represents the GAMEPAD R3 button.        |
| `GAMEPAD_START`    | `"start"`               | Represents the GAMEPAD START button.     |
| `GAMEPAD_BACK`     | `"back"`                | Represents the GAMEPAD BACK button.      |
| `ENTER`            | `"enter-gamepad_A"`     | Represents the ENTER navigation command. |
| `ESCAPE`           | `"escape-gamepad_B"`    | Represents the ESCAPE navigation command.|
| `END`              | `"end"`                 | Represents the END navigation command.   |
| `HOME`             | `"home"`                | Represents the HOME navigation command.  |
| `PAGE_DOWN`        | `"pageDown"`            | Represents the PAGE DOWN command.        |
| `PAGE_UP`          | `"pageUp"`              | Represents the PAGE UP command.          |
| `TAB`              | `"tab"`                 | Represents the TAB navigation command.   |
| `SHIFT_TAB`        | `"shifttab"`            | Represents the SHIFT+TAB command.        |

## Usage

The constants in the `NavigationCode` class can be accessed statically, which means there is no need to create an instance of the class. Below are some examples of how these constants might be used:

```actionscript
import scaleform.clik.constants.NavigationCode;

function handleInput(input:String):void {
    switch (input) {
        case NavigationCode.UP:
            // Code to move up
            break;
        case NavigationCode.DOWN:
            // Code to move down
            break;
        // ... (Other cases)
        case NavigationCode.GAMEPAD_A:
            // Code to handle gamepad A button
            break;
        // ... (Other gamepad-related cases)
    }
}
```

## Class Definition

The `NavigationCode` class is straightforward and simply defines a set of static constants. It does not contain any methods or properties beyond what is inherited from its superclass.

```actionscript
package scaleform.clik.constants {
    public class NavigationCode {
        public static var UP:String = "up";
        public static var DOWN:String = "down";
        // ... (Other constants)
        public static var GAMEPAD_R3:String = "gamepad_R3";
        // ... (Other constants)

        public function NavigationCode() {
            super();
        }
    }
}
```

**Note**: `NavigationCode` assumes a specific mapping of gamepad buttons to actions, which might correspond to the standard conventions used in a particular game or application. Adjustments might be necessary to align with different hardware or user preferences.
