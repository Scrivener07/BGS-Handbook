# FocusManager
The `FocusManager` class is part of the `scaleform.gfx` package and provides a suite of static methods designed to manage focus within Scaleform GFx displays.

The class is designed to be used with Scaleform's game development tools and is not intended for use with standard Flash applications.

## Class Definition

```actionscript
package scaleform.gfx {
    import flash.display.DisplayObjectContainer;
    import flash.display.InteractiveObject;
    import flash.display.Sprite;

    public final class FocusManager {
        // Constructor and methods
    }
}
```

## Constructor

- **FocusManager()**
  Constructs a new instance of the FocusManager class.

## Properties

| Property Name             | Type       | Description                                                              |
|---------------------------|------------|--------------------------------------------------------------------------|
| alwaysEnableArrowKeys     | Boolean    | Enables or disables the use of arrow keys for navigation at all times.   |
| disableFocusKeys          | Boolean    | Enables or disables the focus key functionality.                         |
| numFocusGroups            | uint       | Retrieves the number of focus groups available.                          |

## Methods

### Focus Management
| Method                    | Return Type          | Description                                                             |
|---------------------------|----------------------|-------------------------------------------------------------------------|
| **setFocus**              | `void`               | Sets the current focus to a specified `InteractiveObject`.              |
| **getFocus**              | `InteractiveObject`  | Returns the current `InteractiveObject` that has focus.                 |
| **moveFocus**             | `InteractiveObject`  | Moves the focus based on the given direction and conditions.            |
| **findFocus**             | `InteractiveObject`  | Finds the next object that should receive focus.                        |

### Focus Group Management
| Method                    | Return Type          | Description                                                             |
|---------------------------|----------------------|-------------------------------------------------------------------------|
| **setFocusGroupMask**     | `void`               | Sets the focus group mask for an `InteractiveObject`.                   |
| **getFocusGroupMask**     | `uint`               | Gets the focus group mask for an `InteractiveObject`.                   |
| **setControllerFocusGroup** | `Boolean`          | Assigns a focus group to a controller.                                  |
| **getControllerFocusGroup** | `uint`             | Gets the focus group assigned to a controller.                          |
| **getControllerMaskByFocusGroup** | `uint`       | Retrieves the controller mask for a given focus group.                  |

### Modal Clip Management
| Method                    | Return Type          | Description                                                             |
|---------------------------|----------------------|-------------------------------------------------------------------------|
| **setModalClip**          | `void`               | Sets a `Sprite` as the modal clip.                                      |
| **getModalClip**          | `Sprite`             | Retrieves the current modal clip.                                       |

### Usage Notes

- **setFocus** and **getFocus**: These methods are only usable with GFx and provide diagnostic trace outputs when used with Flash.
- **alwaysEnableArrowKeys** and **disableFocusKeys**: These properties are accessors for enabling or disabling specific focus-related behaviors.
- **moveFocus** and **findFocus**: These methods are used to navigate between interactive objects based on certain criteria (e.g., direction, starting object).

### Example Code
**Setting Always Enable Arrow Keys**
```actionscript
FocusManager.alwaysEnableArrowKeys = true;
```

**Setting Focus to an InteractiveObject**
```actionscript
var interactiveObj:InteractiveObject = new InteractiveObject();
FocusManager.setFocus(interactiveObj);
```

## Remarks
- This class is a final class and cannot be extended.
- It is important to note that error messages indicate that `FocusManager.setFocus` and `FocusManager.getFocus` are not functional for standard Flash applications but are specific to Scaleform GFx. Use the `stage.focus` property for Flash applications instead.
- The `FocusManager` class is part of the Scaleform utilities for game interface design and is typically not used in traditional web-based Flash development.
