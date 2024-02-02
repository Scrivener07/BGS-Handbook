---
title: "MultiActivateMenu"
categories: fo4 interface menus multi-activatemenu
---

`MultiActivateMenu.as` is an ActionScript file providing functionality for a user interface menu with multiple activatable buttons.
Below is the detailed documentation for the code.

## **Table of Contents**
- [Class Overview](#class-overview)
- [Public Properties](#public-properties)
- [Private Properties](#private-properties)
- [Constructor](#constructor)
- [Protected Methods](#protected-methods)
- [Public Methods](#public-methods)
- [Private Methods](#private-methods)

## **Class Overview**

**Class Name:** `MultiActivateMenu`

**Inherits:** `IMenu`

The `MultiActivateMenu` class extends the `IMenu` class, providing functionality for a menu interface with multiple interactive button hints.
It manages button states and animations and handles user input events to trigger actions associated with each button.

## **Public Properties**

| Property Name   | Type          | Description                           |
|-----------------|---------------|---------------------------------------|
| `FadeHolder_mc` | `MovieClip`   | A container for button animations.    |
| `BGSCodeObj`    | `Object`      | An object to handle button actions.   |

## **Private Properties**

| Property Name     | Type                        | Description                                   |
|-------------------|-----------------------------|-----------------------------------------------|
| `Buttons`         | `Vector.<BSButtonHint>`     | A vector holding button hint instances.       |
| `ButtonAnimators` | `Vector.<MovieClip>`        | A vector holding button animation clips.      |
| `ButtonData`      | `Vector.<BSButtonHintData>` | A vector holding data for button hints.       |
| `ABtnData`        | `BSButtonHintData`          | Button hint data for the 'A' button.          |
| `BBtnData`        | `BSButtonHintData`          | Button hint data for the 'B' button.          |
| `XBtnData`        | `BSButtonHintData`          | Button hint data for the 'X' button.          |
| `YBtnData`        | `BSButtonHintData`          | Button hint data for the 'Y' button.          |

## **Constructor**

The constructor initializes the button data with default values and sets up the vectors for buttons and their animation handlers.
It also binds the proper release functions to each button data.

```actionscript
public function MultiActivateMenu() {
    // ... Constructor code
}
```

## **Protected Methods**

### `onSetSafeRect`

This method ensures that the menu is locked within a safe rectangular area on the screen.

```actionscript
override protected function onSetSafeRect() : void {
    // ... Method code
}
```

## **Public Methods**

### `onCodeObjCreate`

Initializes button hint data for all buttons after creation.

```actionscript
public function onCodeObjCreate() : * {
    // ... Method code
}
```

### `SetButtonData`

Configures the text and enabled state of a button based on the provided parameters.

```actionscript
public function SetButtonData(param1:uint, param2:String, param3:Boolean) : * {
    // ... Method code
}
```

### `ProcessUserEvent`

Handles user input events and triggers the appropriate button press or release functions.

```actionscript
public function ProcessUserEvent(param1:String, param2:Boolean) : Boolean {
    // ... Method code
}
```

## **Private Methods**

### Button Press and Release Handlers

These methods manage the state of the buttons when they are pressed or released.

- `onAPress` / `onARelease`
- `onBPress` / `onBRelease`
- `onXPress` / `onXRelease`
- `onYPress` / `onYRelease`

```actionscript
private function onAPress() : * {
    // ... Method code
}

private function onARelease() : * {
    // ... Method code
}
// Similar methods for B, X, and Y
```

Each of these methods call `onButtonPress` or `onButtonRelease`, passing in the respective button index (0 for A, 1 for B, etc.).
