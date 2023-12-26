# GlobalFunc.as Documentation
Mainly used for backend operations in UI and HUD elements of Scaleform GFX in games.

`GlobalFunc` is a utility class in the `Shared` package, providing a collection of static functions to facilitate various operations in Scaleform and game interfaces.

The `GlobalFunc.as` file contains a collection of static utility functions that can be used throughout a Flash application.
These functions provide a range of features such as linear interpolation, rounding decimals, text formatting, and ensuring display objects stay within a safe rectangular boundary on the screen.

Used for various utility operations like text formatting, animation controls, and geometric calculations.

Includes methods for linear interpolation (`Lerp`), rounding decimals, checking proximity (`CloseToNumber`), maintaining text formats, setting text with optional HTML and truncation (`SetText`), aligning objects within a safe area (`LockToSafeRect`), and more.


#### Example
```as3
// Example usage for setting text
GlobalFunc.SetText(myTextField, "Example Text", false, true);
```



## Constants

The following table lists the constants defined within the `GlobalFunc` class:

| Constant Name                | Type     | Description                                           | Value       |
| ---------------------------- | -------- | ----------------------------------------------------- | ----------- |
| `PIPGREY_OUT_ALPHA`          | `Number` | Alpha transparency for a greyed-out Pipboy            | `0.5`       |
| `SELECTED_RECT_ALPHA`        | `Number` | Alpha transparency for a selected rectangle           | `1`         |
| `DIMMED_ALPHA`               | `Number` | Alpha transparency for a dimmed element               | `0.65`      |
| `NUM_DAMAGE_TYPES`           | `uint`   | Number of damage types                                | `6`         |
| `CLOSE_ENOUGH_EPSILON`       | `Number` | Epsilon value for close number comparison             | `0.001`     |
| `MAX_TRUNCATED_TEXT_LENGTH`  | `Number` | Maximum length for truncated text                     | `42`        |
| `PLAY_FOCUS_SOUND`           | `String` | Identifier for the play focus sound event             | `"GlobalFunc::playFocusSound"` |

## Methods

### Linear Interpolation (Lerp)

Performs a linear interpolation between two values.

```as3
public static function Lerp(aTargetMin:Number, aTargetMax:Number, aSourceMin:Number, aSourceMax:Number, aSource:Number, abClamp:Boolean) : Number
```

### Round Decimal

Rounds a number to a given precision.

```as3
public static function RoundDecimal(aNumber:Number, aPrecision:Number) : Number
```

### Close To Number

Determines if two numbers are within a small range (epsilon) of each other.

```as3
public static function CloseToNumber(aNumber1:Number, aNumber2:Number) : Boolean
```

### Maintain Text Format

Maintains the text format of a `TextField` when setting its text.

```as3
public static function MaintainTextFormat() : *
```

### Set Text

Sets the text of a `TextField` with options to use HTML text, uppercase conversion, and truncation.

```as3
public static function SetText(aTextField:TextField, aText:String, abHTMLText:Boolean, abUpperCase:Boolean = false, abTruncate:* = false) : *
```

### Lock To Safe Rect

Positions a `DisplayObject` within a specified safe rectangle on the screen.

```as3
public static function LockToSafeRect(aDisplayObject:DisplayObject, aPosition:String, aSafeX:Number = 0, aSafeY:Number = 0) : *
```

### Add Movie Explore Functions

Adds functions to explore `MovieClip` instances within a `MovieClip` object.

```as3
public static function AddMovieExploreFunctions() : *
```

### Add Reverse Functions

Adds functions for playing `MovieClip` animations in reverse.

```as3
public static function AddReverseFunctions() : *
```

### String Trim

Trims whitespace from the beginning and end of a string.

```as3
public static function StringTrim(astrText:String) : String
```

## Usage 📝

To use these utility functions, simply call them statically through the `GlobalFunc` class, such as:

```as3
var alpha:Number = GlobalFunc.Lerp(0, 1, 0, 100, 50, true);
```

To ensure the methods that extend built-in classes (like `TextField`) work correctly, call the relevant function like `MaintainTextFormat()` somewhere in your initialization code.

---

**Note**: The extensions to `TextField.prototype` and `MovieClip.prototype` modify the prototypes of built-in ActionScript 3 classes, which is generally discouraged as it can lead to conflicts and unpredictable behavior if multiple libraries or pieces of code attempt to extend the same prototypes. Use these extensions with caution.
