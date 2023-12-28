# ButtonBarHolder Documentation
`ButtonBarHolder` is an ActionScript class that extends the `MovieClip` class and is designed to hold and configure a button hint bar within a user interface.
The class is defined within the ButtonBarHolder.as file and is part of an unnamed package.

## Class Definition
Below is the class definition for `ButtonBarHolder`:

```actionscript
package {
    import Shared.AS3.BSButtonHintBar;
    import flash.display.MovieClip;

    public dynamic class ButtonBarHolder extends MovieClip {
        public var ButtonHintBar_mc:BSButtonHintBar;

        public function ButtonBarHolder() {
            super();
            trace("[ButtonBarHolder](ctor)");
            this.InspectorSetting();
        }

        private function InspectorSetting():* {
            trace("[ButtonBarHolder](InspectorSetting)");
            try {
                this.ButtonHintBar_mc["componentInspectorSetting"] = true;
            } catch(error:Error) {
                trace("[ButtonBarMenu.swf][ButtonBarHolder](InspectorSetting) " + error.toString());
            }

            this.ButtonHintBar_mc.BackgroundAlpha = 1;
            this.ButtonHintBar_mc.BackgroundColor = 0;
            this.ButtonHintBar_mc.bracketCornerLength = 6;
            this.ButtonHintBar_mc.bracketLineWidth = 1.5;
            this.ButtonHintBar_mc.BracketStyle = "horizontal";
            this.ButtonHintBar_mc.bRedirectToButtonBarMenu = false;
            this.ButtonHintBar_mc.bShowBrackets = true;
            this.ButtonHintBar_mc.bUseShadedBackground = true;
            this.ButtonHintBar_mc.ShadedBackgroundMethod = "Shader";
            this.ButtonHintBar_mc.ShadedBackgroundType = "normal";

            try {
                this.ButtonHintBar_mc["componentInspectorSetting"] = false;
            } catch(error:Error) {
                trace("[ButtonBarMenu.swf][ButtonBarHolder](InspectorSetting) " + error.toString());
            }
        }
    }
}
```

## Properties

**Public Properties:**

| **Property**           | **Type**          | **Description**                                             |
|------------------------|-------------------|-------------------------------------------------------------|
| `ButtonHintBar_mc`     | `BSButtonHintBar` | A reference to the `BSButtonHintBar` instance in the movie clip. |

## Constructor
The `ButtonBarHolder` constructor initializes the object and calls the `InspectorSetting` method.

- `public function ButtonBarHolder()`

## Methods

**Private Methods:**

| **Method**             | **Return Type** | **Description**                                 |
|------------------------|-----------------|-------------------------------------------------|
| `InspectorSetting`     | `*`             | Configures the `ButtonHintBar_mc` properties. |

**Method Details:**

- `private function InspectorSetting():*`

This method sets various properties of the `ButtonHintBar_mc` to configure its appearance and behavior. It also wraps the property setting code within a `try-catch` block to handle any potential errors.

## Configuration
In the `InspectorSetting` method, the following **configuration** is applied to the `ButtonHintBar_mc`:

- **BackgroundAlpha**: Set to `1` (fully opaque).
- **BackgroundColor**: Set to `0` (black).
- **bracketCornerLength**: Set to `6`.
- **bracketLineWidth**: Set to `1.5`.
- **BracketStyle**: Set to `"horizontal"`.
- **bRedirectToButtonBarMenu**: Set to `false` (no redirection).
- **bShowBrackets**: Set to `true` (brackets will be shown).
- **bUseShadedBackground**: Set to `true` (a shaded background will be used).
- **ShadedBackgroundMethod**: Set to `"Shader"`.
- **ShadedBackgroundType**: Set to `"normal"`.

During the configuration, if any error occurs, the error is captured and output to the trace log with a detailed message.
