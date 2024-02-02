# BSButtonHintData
The `BSButtonHintData` class is part of the `Shared.AS3` package and extends the `EventDispatcher` class to manage button hints data in a user interface.
This class is used to describe the properties of a button, such as its labels, associated keys, and states (enabled, visible, flashing).

### Table of Contents
1. [Constants](#constants)
2. [Properties](#properties)
3. [Public Methods](#public-methods)
4. [Event Handlers](#event-handlers)
5. [Usage](#usage)

## Constants
| Constant                 | Description                         |
|--------------------------|-------------------------------------|
| `BUTTON_HINT_DATA_CHANGE`| Event identifier for data changes.  |

## Properties

#### Primary Button Properties
| Property             | Type     | Description                                  |
|----------------------|----------|----------------------------------------------|
| `_strButtonText`     | `String` | The text label of the button.                |
| `_strPCKey`          | `String` | The key associated with the button on PC.    |
| `_strPSNButton`      | `String` | The PlayStation controller button label.     |
| `_strXenonButton`    | `String` | The Xbox controller button label.            |
| `_uiJustification`   | `uint`   | The justification value for the button.      |
| `_callbackFunction`  | `Function` | The function callback for button click.    |
| `_bButtonDisabled`   | `Boolean`| The state of the button being disabled.      |
| `_bButtonVisible`    | `Boolean`| The visibility status of the button.         |
| `_bButtonFlashing`   | `Boolean`| Whether the button is flashing.              |

#### Secondary Button Properties
| Property                      | Type      | Description                                         |
|-------------------------------|-----------|-----------------------------------------------------|
| `_hasSecondaryButton`         | `Boolean` | Indicates the presence of a secondary button.       |
| `_strSecondaryPCKey`          | `String`  | The secondary PC key.                               |
| `_strSecondaryPSNButton`      | `String`  | The secondary PlayStation controller button label.  |
| `_strSecondaryXenonButton`    | `String`  | The secondary Xbox controller button label.         |
| `_secondaryButtonCallback`    | `Function`| The callback function for the secondary button.     |

#### Dynamic Movie Clip
| Property                  | Type     | Description                                     |
|---------------------------|----------|-------------------------------------------------|
| `_strDynamicMovieClipName`| `String` | The name of the dynamic movie clip associated.  |

## Public Methods

#### Constructor
```as3
public function BSButtonHintData(astrButtonText:String, astrPCKey:String, astrPSNButton:String, astrXenonButton:String, auiJustification:uint, aFunction:Function)
```
Initializes a new instance of the `BSButtonHintData` class.

#### Getters/Setters
- Various getters and setters for button properties such as `ButtonText`, `PCKey`, `PSNButton`, `XenonButton`, etc.
- Allows toggling button states like `ButtonDisabled`, `ButtonVisible`, and `ButtonFlashing`.

#### Button Configuration
- `SetButtons` - Set primary button configuration.
- `SetSecondaryButtons` - Set secondary button configuration.

#### Event Handling
- `AnnounceDataChange` - Dispatches the `BUTTON_HINT_DATA_CHANGE` event.

#### Callback Setup
- `secondaryButtonCallback` - Set the callback for secondary button.

## Event Handlers
- `onAnnounceDataChange`
- `onTextClick`
- `onSecondaryButtonClick`

## Usage

Here is an example of how the `BSButtonHintData` class might be instantiated and used:

```as3
import Shared.AS3.BSButtonHintData;

var buttonHint:BSButtonHintData = new BSButtonHintData("Press", "E", "X", "A", 1, function() {
    trace("Button was clicked");
});

buttonHint.ButtonVisible = true;
buttonHint.ButtonEnabled = true;
buttonHint.onTextClick = function() {
    trace("Primary button was clicked");
};

buttonHint.SetSecondaryButtons("Q", "Square", "B");
buttonHint.SecondaryButtonEnabled = true;
buttonHint.onSecondaryButtonClick = function() {
    trace("Secondary button was clicked");
};
```

This class is designed to interact with UI elements for action-driven interfaces, typically found in video game UI systems.
The properties and methods allow a developer to define the look and functionality of the UI buttons and handle user interactions seamlessly. The `EventDispatcher` functionality enables communication between the UI component and the rest of the application when changes occur.
