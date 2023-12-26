# PromptMenuPanel_1 Documentation

## Overview

`PromptMenuPanel_1` is a dynamic class extending `MovieClip` from the ActionScript package `PromptMenu_fla`. It is designed to represent a panel that can hold and display a message within a movie clip, complete with configurable bracket styles and background settings.

### File Details
- **Filename:** `PromptMenuPanel_1.as`

## Class: `PromptMenuPanel_1`

```as
package PromptMenu_fla {
    import flash.display.MovieClip;

    public dynamic class PromptMenuPanel_1 extends MovieClip {

        public var MessageHolder_mc:MessageHolder;

        public function PromptMenuPanel_1() {
            super();
            this.__setProp_MessageHolder_mc_PromptMenuPanel_MessageHolder_mc_0();
        }

        function __setProp_MessageHolder_mc_PromptMenuPanel_MessageHolder_mc_0() : * {
            try {
                this.MessageHolder_mc["componentInspectorSetting"] = true;
            } catch(e:Error) {
            }

            this.MessageHolder_mc.bracketCornerLength = 6;
            this.MessageHolder_mc.bracketLineWidth = 2;
            this.MessageHolder_mc.bracketPaddingX = 6;
            this.MessageHolder_mc.bracketPaddingY = 2;
            this.MessageHolder_mc.BracketStyle = "horizontal";
            this.MessageHolder_mc.bShowBrackets = true;
            this.MessageHolder_mc.bUseShadedBackground = true;
            this.MessageHolder_mc.ShadedBackgroundMethod = "Shader";
            this.MessageHolder_mc.ShadedBackgroundType = "normal";

            try {
                this.MessageHolder_mc["componentInspectorSetting"] = false;
                return;
            } catch(e:Error) {
                return;
            }
        }
    }
}
```

### Properties

| Property                        | Type          | Description |
| ------------------------------- | ------------- | ----------- |
| `MessageHolder_mc`              | `MessageHolder` | A `MessageHolder` instance to manage message display attributes within the panel. |

### Constructor

- **PromptMenuPanel_1()**
  - Calls the superclass constructor.
  - Invokes `__setProp_MessageHolder_mc_PromptMenuPanel_MessageHolder_mc_0` to initialize the `MessageHolder_mc` properties.

### Methods

- **__setProp_MessageHolder_mc_PromptMenuPanel_MessageHolder_mc_0() : \***
  - Configures properties of `MessageHolder_mc`.
  - Sets component inspector settings to `true`, attempts to configure various bracket and background properties, then resets component inspector settings to `false`.

### Configured Properties of `MessageHolder_mc`

| Property | Value | Description |
| -------- | ----- | ----------- |
| `bracketCornerLength` | `6` | The length of the bracket corners. |
| `bracketLineWidth` | `2` | The line width of the brackets. |
| `bracketPaddingX` | `6` | The horizontal padding for the brackets. |
| `bracketPaddingY` | `2` | The vertical padding for the brackets. |
| `BracketStyle` | `"horizontal"` | The style of the brackets (horizontal in this case). |
| `bShowBrackets` | `true` | Whether or not to show brackets. |
| `bUseShadedBackground` | `true` | Whether or not to use a shaded background. |
| `ShadedBackgroundMethod` | `"Shader"` | The method used for shading the background. |
| `ShadedBackgroundType` | `"normal"` | The type of the shaded background. |

## Usage Example

To use the `PromptMenuPanel_1` within your Flash application, simply create an instance of the panel and add it to the stage or a parent display object container:

```as
var promptPanel:PromptMenuPanel_1 = new PromptMenuPanel_1();
this.addChild(promptPanel);
```

This will display the message panel with all the default bracket and background settings applied.
