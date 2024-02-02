---
---
# IMenu
The `IMenu` class is part of the `Shared` package.
This class extends the `MovieClip` class from the Flash API and provides functionality for handling platform requests, stage initialization, font resizing, and focus management within a user interface context.

`IMenu` is a foundational class in the `Shared` package for Fallout 4 game menus.
Despite its name, it's an extendable class, not an interface.

It provides common functionality for game menus, handling platform-specific differences and UI interactions.

Used as a base class for creating custom game menus, handling platform-specific events, and managing UI focus.

No specific visual elements are directly linked to this class, but it manages the display and layout of UI components in a menu.

Though named like an interface, `IMenu` is an essential class for creating and managing game menus in Fallout 4.


## Table of Contents
- [Class Overview](#class-overview)
- [Properties](#properties)
- [Public Methods](#public-methods)
- [Protected Methods](#protected-methods)
- [Private Methods](#private-methods)
- [Event Handlers](#event-handlers)


## Class Overview
```actionscript
package Shared {
    import flash.display.MovieClip;
    import flash.events.Event;

    public class IMenu extends MovieClip {
        // ... class members ...
    }
}
```

#### Example
```as3
// Creating a new menu class
public class CustomMenu extends IMenu {
    public function CustomMenu() {
        super();
        // Custom menu initialization
    }
}
```


## Properties

| Property Name       | Type      | Description                                             |
|---------------------|-----------|---------------------------------------------------------|
| `_uiPlatform`       | `uint`    | The platform UI identifier.                             |
| `_bPS3Switch`       | `Boolean` | A flag for PS3 platform switch.                         |
| `_bRestoreLostFocus`| `Boolean` | A flag to indicate if the lost focus should be restored.|
| `safeX`             | `Number`  | The safe area X coordinate.                             |
| `safeY`             | `Number`  | The safe area Y coordinate.                             |
| `textFieldSizeMap`  | `Object`  | A map to keep track of text fields and their sizes.     |

## Public Methods

- **IMenu**
  Constructor for the `IMenu` class. Initializes properties and event listeners.

- **get uiPlatform**
  Getter for the `_uiPlatform` property.

- **get bPS3Switch**
  Getter for the `_bPS3Switch` property.

- **get SafeX**
  Getter for the `safeX` property.

- **get SafeY**
  Getter for the `safeY` property.

- **SetPlatform**
  Sets the platform type ID and PS3 switch value. Dispatches a `PlatformChangeEvent`.
  ```actionscript
  public function SetPlatform(auiPlatform:uint, abPS3Switch:Boolean): *
  ```

- **SetSafeRect**
  Sets the safe area rectangle for the UI.
  ```actionscript
  public function SetSafeRect(aSafeX:Number, aSafeY:Number): *
  ```

- **ShrinkFontToFit**
  Adjusts font size to fit within a specified area.
  It does this by shrinking the font size of a `TextField` to fit a specified max scroll value.
  ```actionscript
  public function ShrinkFontToFit(textField:TextField, amaxScrollV:int): *
  ```

## Protected Methods

- **onPlatformRequestEvent**
  Responds to platform request events.

- **onSetSafeRect**
  Placeholder method for setting the safe rectangle. Designed to be overridden.

- **onMouseFocus**
  Handles mouse focus events.

## Private Methods

- **onFocusLost**
  Handles focus lost events and restores focus if the `_bRestoreLostFocus` flag is true.

## Event Handlers

- **onStageInit**
  Initializes stage properties and adds focus-related event listeners upon being added to the stage.

- **onStageDestruct**
  Cleans up focus-related event listeners upon being removed from the stage.

---

**Filename:** `IMenu.as`

**Usage Example:**
```actionscript
var menu:IMenu = new IMenu();
menu.SetPlatform(PlatformChangeEvent.PLATFORM_PS3, true);
menu.SetSafeRect(100, 100);
```

**Note:** 📝 The `IMenu` class appears to be designed as a base class for menu-related UI components that would be customized further in subclasses. The actual resizing and focus restoration logic is implemented but `onSetSafeRect` is empty, implying it should be overridden in subclasses for specific behavior.
