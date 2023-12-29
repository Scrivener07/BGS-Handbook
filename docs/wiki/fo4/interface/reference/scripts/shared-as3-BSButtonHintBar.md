# BSButtonHintBar
This is a component that renders a list of multi-platform button.

The `BSButtonHintBar` class is a dynamic subclass of `BSUIComponent` designed for displaying a bar containing button hints.
It includes features such as brackets for stylistic purposes, shaded background support, and the ability to toggle visibility depending on certain conditions.

## Table of Contents
1. [Class Structure](#class-structure)
2. [Properties](#properties)
3. [Public Methods](#public-methods)
4. [Event Handlers](#event-handlers)
5. [Private Methods](#private-methods)
6. [Override Methods](#override-methods)

## Class Structure

```actionscript
package Shared.AS3 {
    import Shared.AS3.COMPANIONAPP.CompanionAppMode;
    import Shared.AS3.COMPANIONAPP.MobileButtonHint;
    import flash.display.MovieClip;
    import flash.events.Event;

    public dynamic class BSButtonHintBar extends BSUIComponent {
        // ... Class members
    }
}
```

## Properties

| Property | Type | Description | Default |
| -------- | ---- | ----------- | ------- |
| `ButtonBracket_Left_mc` | `MovieClip` | MovieClip for the left bracket graphic. | - |
| `ButtonBracket_Right_mc` | `MovieClip` | MovieClip for the right bracket graphic. | - |
| `ShadedBackground_mc` | `MovieClip` | MovieClip for the shaded background graphic. | - |
| `_bRedirectToButtonBarMenu` | `Boolean` | Determines if button bar should redirect to the button bar menu. | `true` |
| `_backgroundColor` | `uint` | Background color of the button hint bar. | `0` (black) |
| `_backgroundAlpha` | `Number` | Alpha transparency of the background. | `1.0` (opaque) |
| `_bShowBrackets_Override` | `Boolean` | Override flag for displaying brackets. | `true` |
| `_bUseShadedBackground_Override` | `Boolean` | Override flag for using a shaded background. | `true` |

## Public Methods

- **Constructor (`BSButtonHintBar`):** Initializes the button hint bar.

- **`get bRedirectToButtonBarMenu():Boolean`**
  - Returns the current state of redirect to button bar menu property.

- **`set bRedirectToButtonBarMenu(abRedirectToButtonBarMenu:Boolean):*`**
  - Sets the redirect to button bar menu property and marks the UI as dirty if changed.

- **`get BackgroundColor():uint`**
  - Returns the background color.

- **`set BackgroundColor(abBackgroundColor:uint):*`**
  - Sets the background color and marks the UI as dirty if changed.

- **`get BackgroundAlpha():Number`**
  - Returns the alpha transparency of the background.

- **`set BackgroundAlpha(abBackgroundAlpha:Number):*`**
  - Sets the alpha transparency of the background.

## Event Handlers

- **`onButtonHintDataDirtyEvent(arEvent:Event):void`**
  - Event handler for button hint data change; marks the UI as dirty.

## Private Methods

- **`CanBeVisible():Boolean`**
  - Determines if the button hint bar is allowed to be visible.

- **`SetButtonHintData_Impl(abuttonHintDataV:Vector.<BSButtonHintData>):void`**
  - Implementation for setting the button hint data.

- **`CreateButtonHints():*`**
  - Creates the button hints and adds them to the button hint bar.

## Override Methods

- **`onAcquiredByNativeCode():*`**
  - Override handling for when the component is acquired by native code.

- **`get bShowBrackets():Boolean`**
  - Returns the override state for showing brackets.

- **`set bShowBrackets(abShowBrackets:Boolean):*`**
  - Sets the override state for showing brackets and marks the UI as dirty if changed.

- **`get bUseShadedBackground():Boolean`**
  - Returns the override state for using a shaded background.

- **`set bUseShadedBackground(abUseShadedBackground:Boolean):*`**
  - Sets the override state for using a shaded background and marks the UI as dirty if changed.

- **`redrawUIComponent():void`**
  - Redraws the UI components; primarily used when the state of the button hint bar changes.

## Usage Example
To use the `BSButtonHintBar` class, you would typically create an instance and configure its properties to match the desired appearance and behavior.

You would then add it to the display list of your application's user interface.

```actionscript
var hintBar:BSButtonHintBar = new BSButtonHintBar();
hintBar.BackgroundColor = 0xFF0000; // Red
hintBar.BackgroundAlpha = 0.8;
hintBar.bRedirectToButtonBarMenu = false;
// Add further configuration and add hintBar to the stage or parent container.
```

## Notes

* The provided code indicates that this class is part of a user interface for a desktop application or a companion mobile app, as suggested by the `CompanionAppMode.isOn` conditionals.
* It is important to keep in mind that the actual visual assets are not provided with this code, and the `MovieClip` instances would have to be created with the corresponding graphical assets.
* The `BSButtonHintBar` class is designed to work within a larger ecosystem, likely a game or interactive application, which would manage its state and contents in response to user actions or other events.

💡 **Tip:** Always ensure that any use of this class is properly integrated with the rest of the application to function as intended.
