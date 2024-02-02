---
---
# PopUpManager
The `PopUpManager` class is part of the `scaleform.clik.managers` package.
It is responsible for managing pop-up elements within the user interface, such as dialogs and modal windows.

This documentation outlines the functionality provided by the `PopUpManager` class.

## Table of Contents
- [**PopUpManager Class Overview**](#popupmanager-class-overview)
- [**Public Methods**](#public-methods)
- [**Protected Methods**](#protected-methods)
- [**Usage Example**](#usage-example)

---

## PopUpManager Class Overview

**Filename**: `PopUpManager.as`

The `PopUpManager` class includes methods to initialize the pop-up systems, display pop-ups, show modal windows, and handle the removal of pop-ups.

**Tables of Properties and Methods**:

| Type | Name | Description |
| ---- | ---- | ----------- |
| **Property** | `initialized` | A `Boolean` indicating whether the manager has been initialized. |
| **Property** | `_stage` | Holds a reference to the `Stage` object. |
| **Property** | `_defaultPopupCanvas` | A `MovieClip` which acts as the default container for pop-ups. |
| **Property** | `_modalMc` | A `Sprite` that represents the currently active modal pop-up. |
| **Property** | `_modalBg` | A `Sprite` that represents the background of the modal pop-up. |
| **Method** | `init` | Initializes the `PopUpManager` with a given `Stage` object. |
| **Method** | `show` | Displays a `DisplayObject` as a pop-up on the stage. |
| **Method** | `showModal` | Displays a `Sprite` as a modal dialog on the stage. |
| **Method** | `handleStageAddedEvent` | A `protected` method that ensures the pop-up canvas is always on top. |
| **Method** | `handleRemovePopup` | A `protected` method to clean up after a pop-up is removed. |
| **Method** | `handleRemoveModalMc` | A `protected` method to clean up after a modal pop-up is removed. |
| **Method** | `removeAddedToStageListener` | A `protected` method to remove stage added event listeners. |

---

## Public Methods

### `init`

Initializes the pop-up manager with the specified stage.

```actionscript
public static function init(param1:Stage) : void
```

### `show`

Displays the given `DisplayObject` as a pop-up.

```actionscript
public static function show(param1:DisplayObject, param2:Number = 0, param3:Number = 0, param4:DisplayObjectContainer = null) : void
```

### `showModal`

Displays the given `Sprite` as a modal pop-up window.

```actionscript
public static function showModal(param1:Sprite, param2:Number = 0, param3:Number = 0, param4:Sprite = null, param5:uint = 0, param6:Sprite = null) : void
```

## Protected Methods

### `handleStageAddedEvent`

Ensures that the pop-up canvas is the topmost display object on the stage.

```actionscript
protected static function handleStageAddedEvent(param1:Event) : void
```

### `handleRemovePopup`

Handles the removal of a pop-up from the stage.

```actionscript
protected static function handleRemovePopup(param1:Event) : void
```

### `handleRemoveModalMc`

Handles the removal of a modal pop-up, cleaning up its components.

```actionscript
protected static function handleRemoveModalMc(param1:Event) : void
```

### `removeAddedToStageListener`

Removes the event listener for stage additions when there are no more pop-ups.

```actionscript
protected static function removeAddedToStageListener() : void
```

## Usage Example

**Initialization of PopUpManager**:

Before using the `PopUpManager`, it must be initialized with a reference to the application's stage.

```actionscript
PopUpManager.init(stage);
```

**Displaying a Pop-Up**:

To display a `DisplayObject` as a pop-up, call the `show` method.

```actionscript
var myPopUp:DisplayObject = new MyCustomPopUpClass();
PopUpManager.show(myPopUp, xPosition, yPosition);
```

**Displaying a Modal Pop-Up**:

To display a modal window, use the `showModal` method.

```actionscript
var myModal:Sprite = new MyModalClass();
PopUpManager.showModal(myModal, xPosition, yPosition);
```

**💡 Note**: The `PopUpManager` must be properly initialized before attempting to display any pop-ups or modal windows.
