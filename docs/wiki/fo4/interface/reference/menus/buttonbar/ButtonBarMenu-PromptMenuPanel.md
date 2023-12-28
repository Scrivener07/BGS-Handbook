# PromptMenuPanel.as Documentation
`PromptMenuPanel.as` is an ActionScript file that defines a dynamic class named `PromptMenuPanel` which extends the `MovieClip` class from the Flash API.
This class is responsible for creating a prompt menu panel with a message holder component that can be visually customized.

## Class Definition
Below is the summarized structure of the `PromptMenuPanel` class:

```actionscript
package {
    import flash.display.MovieClip;

    public dynamic class PromptMenuPanel extends MovieClip {
        // Properties
        public var MessageHolder_mc:MessageHolder;

        // Constructor
        public function PromptMenuPanel() {
            // Implementation
        }

        // Private Methods
        private function InspectorSetting():* {
            // Implementation
        }
    }
}
```

## Properties

| Property            | Type           | Description                      |
|---------------------|----------------|----------------------------------|
| `MessageHolder_mc`  | MessageHolder  | A reference to the message holder component within the prompt menu panel. |

## Constructor

The constructor initializes the `PromptMenuPanel` object.

```actionscript
public function PromptMenuPanel() {
    super();
    trace("[PromptMenuPanel](ctor)");
    this.InspectorSetting();
}
```

## Methods

### InspectorSetting
This private method is responsible for configuring the `MessageHolder` component's visual properties.

```actionscript
private function InspectorSetting():* {
    trace("[PromptMenuPanel](InspectorSetting)");
    try {
        this.MessageHolder_mc["componentInspectorSetting"] = true;
    } catch(error:Error) {
        trace("[ButtonBarMenu.swf][PromptMenuPanel](InspectorSetting) " + error.toString());
    }

    // Set visual properties
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
    } catch(error:Error) {
        trace("[ButtonBarMenu.swf][PromptMenuPanel](InspectorSetting) " + error.toString());
    }
}
```

## 📄 File Summary
- **Filename**: `PromptMenuPanel.as`
- **Language**: ActionScript
- **Purpose**: To define a dynamic class for creating and configuring a prompt menu panel in a Flash application.
- **Class**: `PromptMenuPanel`
- **Base Class**: `MovieClip`
- **Visibility**: `public`
- **Dynamics**: Yes (can be dynamically modified at runtime)
- **Properties**: 1 (`MessageHolder_mc`)
- **Methods**: 1 (`InspectorSetting`)

**Note**:
The code contains traces for debugging, which output messages to the console to indicate the execution of the constructor and the `InspectorSetting` method.
These may also log errors during the configuration of the `MessageHolder_mc` component.
