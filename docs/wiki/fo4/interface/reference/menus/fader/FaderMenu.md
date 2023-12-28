The '''Fader Menu''' is used when the a menu might fade in or out.

== AS3 ==
* <code>var BGSCodeObj:Object</code>
* <code>var FadeRect_mc:MovieClip</code>
* <code>var SpinnerIcon_mc:MovieClip</code>
* <code>var FadeValue:Number</code>
* <code>function SetImmediateWhiteFullFade():*</code>
* <code>function initFade(param1:Boolean, param2:Boolean, param3:Number, param4:Number, param5:Boolean, param6:Boolean):*</code>
* <code>function updateFade(param1:Number):*</code>

==== BGSCodeObj ====
* <code>function onFadeDone():void</code>



# FaderMenu.as Documentation
The `FaderMenu` class extends the `IMenu` class, providing functionality for managing fades and display of a spinner icon during loading or transitions.
The class has methods for initializing and updating the fade effect, as well as handling the completion of the fade.

### Class Overview

**Filename:** `FaderMenu.as`

**Extends:** `IMenu`

### Public Members

| Member Name           | Type           | Description                            |
|-----------------------|----------------|----------------------------------------|
| `BGSCodeObj`          | `Object`       | An object to hold the Bethesda Game Studio Code. |
| `FadeRect_mc`         | `MovieClip`    | The MovieClip responsible for the fade effect. |
| `SpinnerIcon_mc`      | `MovieClip`    | The MovieClip of the spinner icon displayed during loading or transitions. |
| `FadeValue`           | `Number`       | The current fade value.                |

### Private Members

| Member Name            | Type       | Description                                |
|------------------------|------------|--------------------------------------------|
| `fStartAlpha`          | `Number`   | The starting alpha transparency for the fade effect. |
| `fEndAlpha`            | `Number`   | The ending alpha transparency for the fade effect. |
| `fFadeDuration`        | `Number`   | The duration of the fade effect in seconds. |
| `fFadeElapsedSecs`     | `Number`   | The elapsed time in seconds since the fade effect started. |
| `fTotalElapsedSecs`    | `Number`   | The total elapsed time in seconds since some reference point (not specified in the code). |
| `iPostFadeCountdown`   | `int`      | A countdown timer for actions to take after the fade is complete. |
| `fMinNumSeconds`       | `Number`   | The minimum number of seconds to wait before updating the fade. |
| `bShaderFadeActivated` | `Boolean`  | Flag to indicate if shader-based fade is activated. |

### Constructor

```actionscript
public function FaderMenu() {
    super();
    this.BGSCodeObj = new Object();
    this.fStartAlpha = 1;
    this.FadeValue = this.fStartAlpha;
    this.fEndAlpha = 0;
    this.fFadeDuration = 0;
    this.fFadeElapsedSecs = 0;
    this.fTotalElapsedSecs = 0;
    this.fMinNumSeconds = 0;
    this.iPostFadeCountdown = -1;
}
```

### Public Methods

- **onSetSafeRect():**
  Ensures the `SpinnerIcon_mc` is locked to the safe rectangle's bottom right corner.

- **SetImmediateWhiteFullFade():**
  Immediately sets the fade to white and full opacity.

- **initFade():**
  Initializes the fade effect with various parameters to control the fade and spinner visibility.

- **updateFade():**
  Updates the fade based on elapsed time and handles the completion of the fade effect.

### Usage Example

To initialize a fade:

```actionscript
var faderMenu:FaderMenu = new FaderMenu();
faderMenu.initFade(true, false, 1.0, 0.5, false, true);
```

To update the fade within a frame update loop:

```actionscript
faderMenu.updateFade(deltaTime);
```

> **Note:** The snippet assumes `deltaTime` is the time passed since the last update call in seconds.

### 🚩 Important Notes
- The fade effect depends on the elapsed time and duration values.
- The `BGSCodeObj` object would typically provide a callback function, such as `onFadeDone`, which is called when the fade completes.
- The visibility and color of `FadeRect_mc` and `SpinnerIcon_mc` can be adjusted based on the parameters provided to `initFade`.
