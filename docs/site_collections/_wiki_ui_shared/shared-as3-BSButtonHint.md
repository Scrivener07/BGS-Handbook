---
---
# BSButtonHint
The `BSButtonHint` class is a dynamic component in the `Shared.AS3` package used to display button hints in a user interface.
This class extends `BSUIComponent` and provides functionality to handle the display and behavior of button hints based on user interaction.

Below you will find a comprehensive documentation of the `BSButtonHint` class.

## Table of Contents

- [Class Overview](#class-overview)
- [Public Variables](#public-variables)
- [Private Variables](#private-variables)
- [Constructor](#constructor)
- [Public Methods](#public-methods)
- [Private Methods](#private-methods)
- [Events](#events)
- [Constants](#constants)

## Class Overview

```as3
package Shared.AS3 {
    public dynamic class BSButtonHint extends BSUIComponent {
        // ... class implementation ...
    }
}
```

## Public Variables

| Variable                     | Type         | Description                                                  |
| ---------------------------- | ------------ | ------------------------------------------------------------ |
| `textField_tf`               | `TextField`  | The primary text field for the button hint.                  |
| `IconHolderInstance`         | `MovieClip`  | The container for the primary button icon.                   |
| `SecondaryIconHolderInstance`| `MovieClip`  | The container for the secondary button icon.                 |

## Private Variables

| Variable                           | Type         | Description                                                       |
| ---------------------------------- | ------------ | ----------------------------------------------------------------- |
| `_hitArea`                         | `Sprite`     | A sprite representing the hit area for mouse interactions.        |
| `DynamicMovieClip`                 | `MovieClip`  | A movie clip that can be dynamically loaded based on button data. |
| `bButtonFlashing`                  | `Boolean`    | Flag to control button flash animation.                           |
| `_strCurrentDynamicMovieClipName`  | `String`     | Name of the current dynamic movie clip.                           |
| `_DyanmicMovieHeight`              | `Number`     | Height of the dynamic movie clip.                                 |
| `_DynamicMovieY`                   | `Number`     | The Y position of the dynamic movie clip.                         |
| `_buttonHintData`                  | `BSButtonHintData` | Data model for the button hint.                                |

## Constructor

The constructor initializes the button hint component.

```as3
public function BSButtonHint() {
    // ... constructor implementation ...
}
```

## Public Methods

### Setters and Getters

The following methods are used to set and get properties of the button hint:

| Method                      | Returns     | Description                                                  |
| --------------------------- | ----------- | ------------------------------------------------------------ |
| `set ButtonHintData`        | `void`      | Sets the data model for the button hint.                     |
| `get PCKey`                 | `String`    | Returns the PC key representation for the primary button.    |
| `get SecondaryPCKey`        | `String`    | Returns the PC key representation for the secondary button.  |
| `get ControllerButton`      | `String`    | Returns the controller button representation for the primary button. |
| `get SecondaryControllerButton` | `String` | Returns the controller button representation for the secondary button. |
| `get ButtonText`            | `String`    | Returns the text for the button hint.                        |
| `get Justification`         | `uint`      | Returns the justification setting for the text.              |
| `get ButtonDisabled`        | `Boolean`   | Returns whether the primary button is disabled.              |
| `get SecondaryButtonDisabled` | `Boolean`  | Returns whether the secondary button is disabled.            |
| `get AllButtonsDisabled`    | `Boolean`   | Returns whether all buttons (primary and secondary) are disabled. |
| `get ButtonVisible`         | `Boolean`   | Returns whether the button is visible.                       |
| `get UseDynamicMovieClip`   | `Boolean`   | Returns whether a dynamic movie clip should be used.         |
| `set bButtonPressed`        | `void`      | Sets whether the button is pressed.                          |
| `get bButtonPressed`        | `Boolean`   | Returns whether the button is pressed.                       |
| `set bMouseOver`            | `void`      | Sets whether the mouse is over the button.                   |
| `get bMouseOver`            | `Boolean`   | Returns whether the mouse is over the button.                |

### Event Handlers

Event handlers manage user interactions:

| Method                  | Returns     | Description                                                  |
| ----------------------- | ----------- | ------------------------------------------------------------ |
| `onTextClick`           | `void`      | Called when the text is clicked.                             |
| `onMouseOver`           | `void`      | Called when the mouse hovers over the component.             |
| `onMouseOut`            | `void`      | Called when the mouse leaves the component.                  |

### Redrawing Methods

Methods that redraw the UI components:

| Method                    | Returns     | Description                                                  |
| ------------------------- | ----------- | ------------------------------------------------------------ |
| `redrawUIComponent`       | `void`      | Redraws the entire button hint UI component.                 |
| `SetFlashing`             | `void`      | Sets the flashing animation state for the button.            |

## Private Methods

Private methods handle internal operations such as updating text fields and redrawing specific elements.

## Events

- `MouseEvent.CLICK`: Invoked when the text click occurs.
- `MouseEvent.MOUSE_OVER`: Invoked when the mouse hovers over the component.
- `MouseEvent.MOUSE_OUT`: Invoked when the mouse leaves the component.
- `BSButtonHintData.BUTTON_HINT_DATA_CHANGE`: Listens for changes in the button hint data model.

## Constants

The class contains constants to control the appearance and behavior:

| Constant                        | Type         | Description                                                  |
| ------------------------------- | ------------ | ------------------------------------------------------------ |
| `DISABLED_GREY_OUT_ALPHA`       | `Number`     | The alpha value used to grey out disabled buttons.           |
| `JUSTIFY_RIGHT`                 | `uint`       | Enumerator for right justification.                          |
| `JUSTIFY_LEFT`                  | `uint`       | Enumerator for left justification.                           |
| `DYNAMIC_MOVIE_CLIP_BUFFER`     | `int`        | The buffer space used around dynamic movie clips.            |
| `NameToTextMap`                 | `Object`     | A mapping of names to text representations for buttons.      |

## Code Example

```as3
var buttonHint:BSButtonHint = new BSButtonHint();
buttonHint.ButtonHintData = new BSButtonHintData();
// ... further configuration ...
addChild(buttonHint);
```

This documentation provides a detailed insight into the `BSButtonHint` class, which is part of the user interface system in the `Shared.AS3` package, showcasing its methods, variables, and functionality. 📘
