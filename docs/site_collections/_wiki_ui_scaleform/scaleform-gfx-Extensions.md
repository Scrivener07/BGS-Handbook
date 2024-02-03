---
---
# Extensions
The *Extensions.as* file is part of the `scaleform.gfx` package and provides a set of static properties and methods related to Scaleform extensions in Flash.
These extensions include additional functionality beyond the standard Flash API, tailored for UI elements in games that use Scaleform technology.

## Table of Contents

- [Class Definition](#class-definition)
- [Constants](#constants)
- [Properties](#properties)
- [Methods](#methods)

## Class Definition

```as3
package scaleform.gfx {
    public final class Extensions {
        // ...
    }
}
```

The `Extensions` class is marked as `final`, indicating it cannot be subclassed.
The class contains both constants and static properties and methods, which means they can be accessed directly on the class without creating an instance.

## Constants

| Constant              | Description                                  | Value |
|-----------------------|----------------------------------------------|-------|
| `EDGEAA_INHERIT`      | Inherit anti-aliasing settings.              | 0     |
| `EDGEAA_ON`           | Enable anti-aliasing.                        | 1     |
| `EDGEAA_OFF`          | Disable anti-aliasing.                       | 2     |
| `EDGEAA_DISABLE`      | Disable edge anti-aliasing.                  | 3     |

These constants are used to determine the anti-aliasing mode for display objects.

## Properties

| Property                         | Type      | Description                                             |
|----------------------------------|-----------|---------------------------------------------------------|
| `isGFxPlayer`                    | Boolean   | Indicates if the GFx Player is being used.              |
| `CLIK_addedToStageCallback`      | Function  | Callback function for when a CLIK component is added.   |
| `gfxProcessSound`                | Function  | Function for processing sound through Scaleform.        |
| `enabled`                        | Boolean   | Enable or disable the extensions.                       |
| `noInvisibleAdvance`             | Boolean   | Whether advance should be stopped when invisible.       |
| `numControllers`                 | uint      | The number of controllers available.                    |
| `visibleRect`                    | Rectangle | The visible rectangle of the stage.                    |
| `isScaleform`                    | Boolean   | Indicates if Scaleform is enabled.                      |

## Methods

### Getting Objects and Properties

- `getTopMostEntity(x:Number, y:Number, testAll:Boolean = true) : DisplayObject`

  Retrieves the topmost display object that lies under the specified point on the stage.

- `getMouseTopMostEntity(testAll:Boolean = true, mouseIndex:uint = 0) : DisplayObject`

  Returns the display object that is under the mouse cursor.

- `getMouseCursorType(mouseIndex:uint = 0) : String`

  Gets the type of the mouse cursor currently in use.

- `get visibleRect() : Rectangle`

  Returns a rectangle representing the visible area of the stage.

- `getEdgeAAMode(dispObj:DisplayObject) : uint`

  Retrieves the edge anti-aliasing mode of a given display object.

### Setting Properties

- `setMouseCursorType(cursor:String, mouseIndex:uint = 0) : void`

  Sets the type of the mouse cursor.

- `setEdgeAAMode(dispObj:DisplayObject, mode:uint) : void`

  Sets the edge anti-aliasing mode for a specific display object.

- `setIMEEnabled(textField:TextField, isEnabled:Boolean) : void`

  Enables or disables the Input Method Editor for a text field.

## Example Usage

Here is an example of how to use some of the static methods and properties of the `Extensions` class:

```as3
import scaleform.gfx.Extensions;

// Check if Scaleform extensions are enabled
var scaleformEnabled:Boolean = Extensions.enabled;

// Get the topmost entity at a specific point on the stage
var topEntity:DisplayObject = Extensions.getTopMostEntity(100, 200);

// Set the edge anti-aliasing mode for a display object
var myDisplayObject:DisplayObject; // assume this is initialized elsewhere
Extensions.setEdgeAAMode(myDisplayObject, Extensions.EDGEAA_ON);

// Enable IME for a text field
var myTextField:TextField; // assume this is initialized elsewhere
Extensions.setIMEEnabled(myTextField, true);
```

Remember that as these are static members, they must always be accessed through the `Extensions` class directly.

## Notes and Remarks

- The `Extensions` class cannot be instantiated as it only contains static members.
- Methods that appear to return display objects or properties actually return default values or `null` in this documentation, as the actual functionality depends on Scaleform's execution environment.
- Some methods contain optional parameters with default values, allowing for more flexible use.
