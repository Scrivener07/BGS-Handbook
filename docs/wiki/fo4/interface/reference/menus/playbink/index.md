---
title: "PlayBinkMenu"
---

`PlayBinkMenu` is an ActionScript class file that seems to be part of a user interface system, specifically designed for displaying and controlling video playback in a game or application.
The class extends `IMenu`, indicating that it represents a menu screen or a component within the user interface.

Below is a detailed documentation of the `PlayBinkMenu` class, which is found within the `PlayBinkMenu.as` file.

## Class Documentation

### Properties

| Property            | Type              | Description                                                                 |
|---------------------|-------------------|-----------------------------------------------------------------------------|
| **BGSCodeObj**      | Object            | An object that possibly holds reference to the game or application logic.   |
| **ButtonHintBar_mc**| BSButtonHintBar   | Instance of `BSButtonHintBar` to display button hints on the menu.          |
| **buttonHint_Skip** | BSButtonHintData  | Data for the skip button hint, indicating the properties of the skip action.|

### Constructor

The constructor sets up the menu and initializes the button hints.

```actionscript
public function PlayBinkMenu() {
    this.buttonHint_Skip = new BSButtonHintData("$SKIP", "T", "PSN_Y", "Xenon_Y", 1, null);
    super();
    this.BGSCodeObj = new Object();
    var _loc1_:Vector.<BSButtonHintData> = new Vector.<BSButtonHintData>();
    _loc1_.push(this.buttonHint_Skip);
    this.buttonHint_Skip.ButtonVisible = false;
    this.ButtonHintBar_mc.SetButtonHintData(_loc1_);
    this.__setProp_ButtonHintBar_mc_MenuObj_Layer1_0();
}
```

### Public Functions

#### set allowConfirm

Allows toggling the visibility of the skip button.

| Parameter   | Type    | Description                                              |
|-------------|---------|----------------------------------------------------------|
| **param1**  | Boolean | Sets the visibility of the `buttonHint_Skip` to `param1`.|

```actionscript
public function set allowConfirm(param1:Boolean) : * {
    this.buttonHint_Skip.ButtonVisible = param1;
}
```

### Protected Functions

#### \_\_setProp_ButtonHintBar_mc_MenuObj_Layer1_0

Configures the properties of the `ButtonHintBar_mc`.

```actionscript
function __setProp_ButtonHintBar_mc_MenuObj_Layer1_0() : * {
    try {
        this.ButtonHintBar_mc["componentInspectorSetting"] = true;
    } catch(e:Error) { }
    this.ButtonHintBar_mc.BackgroundAlpha = 1;
    this.ButtonHintBar_mc.BackgroundColor = 0;
    this.ButtonHintBar_mc.bracketCornerLength = 6;
    this.ButtonHintBar_mc.bracketLineWidth = 1.5;
    this.ButtonHintBar_mc.BracketStyle = "horizontal";
    this.ButtonHintBar_mc.bRedirectToButtonBarMenu = true;
    this.ButtonHintBar_mc.bShowBrackets = false;
    this.ButtonHintBar_mc.bUseShadedBackground = false;
    this.ButtonHintBar_mc.ShadedBackgroundMethod = "Shader";
    this.ButtonHintBar_mc.ShadedBackgroundType = "normal";
    try {
        this.ButtonHintBar_mc["componentInspectorSetting"] = false;
        return;
    } catch(e:Error) {
        return;
    }
}
```

## Notes
- The `buttonHint_Skip` is initialized with specific identifiers for different platforms (e.g., "PSN_Y" for PlayStation and "Xenon_Y" for Xbox).
- The class includes properties and methods to control the visibility and behavior of the skip button hint.
- `__setProp_ButtonHintBar_mc_MenuObj_Layer1_0` is a method that seems to be used to configure component properties, potentially for usage within a visual editor or component inspector.
