---
title: "TerminalButtons"
---

The `TerminalButtons` class is defined within the `TerminalButtons.as` file and is responsible for managing button hints on a terminal interface, typically for a video game.
This class extends the `IMenu` class, indicating that it represents some form of menu within the game's UI system.

## Class Structure

### Properties

| Property Name     | Type                | Description |
|-------------------|---------------------|-------------|
| `ButtonHintBar_mc` | `BSButtonHintBar`    | An instance of `BSButtonHintBar`, which manages the display of button hints. |
| `BGSCodeObj`      | `Object`             | A generic object expected to contain game code logic related to the terminal buttons. |
| `ExitButton`      | `BSButtonHintData`   | An instance of `BSButtonHintData` that defines the data for the exit button. |
| `HolotapeButton`  | `BSButtonHintData`   | An instance of `BSButtonHintData` that defines the data for the holotape button. |

### Constructor

The `TerminalButtons` constructor initializes the `ExitButton` and `HolotapeButton` with specific parameters and sets up the button bar by calling `PopulateButtonBar`.

**Constructor Code:**
```actionscript
public function TerminalButtons() {
    this.ExitButton = new BSButtonHintData("$Exit", "Tab", "PSN_B", "Xenon_B", 1, this.onExitPressed);
    this.HolotapeButton = new BSButtonHintData("", "R", "PSN_X", "Xenon_X", 1, this.onHolotapeButtonPressed);
    super();
    this.BGSCodeObj = new Object();
    this.PopulateButtonBar();
}
```

### Methods

#### Public Methods

- `SetExitButtonText(param1:String):void`
  Sets the text for the exit button.

- `SetHolotapeButtonText(param1:String):void`
  Sets the text for the holotape button.

- `ToggleHolotapeButtonState():*`
  Toggles the visibility and enabled state of the holotape button.

#### Private Methods

- `PopulateButtonBar():void`
  Populates the button hint bar with the exit and holotape buttons.

- `onExitPressed():void`
  Callback function that is triggered when the exit button is pressed.

- `onHolotapeButtonPressed():void`
  Callback function that is triggered when the holotape button is pressed.

### Example Usage

```actionscript
var terminalButtons:TerminalButtons = new TerminalButtons();
terminalButtons.SetExitButtonText("Exit Terminal");
terminalButtons.SetHolotapeButtonText("Play Holotape");
terminalButtons.ToggleHolotapeButtonState();
```

## Notes

- 📌 The `ExitButton` and `HolotapeButton` properties are instances of `BSButtonHintData` which configure the button text, associated keys/buttons, and callbacks.
- 📌 The `ButtonHintBar_mc` assumes that there is a corresponding movie clip symbol in the game's library linked to the `BSButtonHintBar` class.
- 📌 The `BGSCodeObj` object is a placeholder for the game code that handles exiting the terminal and activating a holotape.
- 📌 The visibility of the `HolotapeButton` is false by default and can be toggled using `ToggleHolotapeButtonState`.

Remember to replace the placeholder strings such as "$Exit" with the relevant localized string references or constants for proper internationalization support, if needed.
