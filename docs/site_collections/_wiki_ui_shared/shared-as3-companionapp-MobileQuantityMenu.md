---
---
# MobileQuantityMenu
`MobileQuantityMenu` is a custom quantity selection component designed for use in companion apps.
It extends the `QuantityMenuNEW` class to provide a user interface for selecting a quantity value using slider and button controls.


## Features

- Customizable quantity slider (`sliderCLIK`)
- Increment (`plusCLIK`) and decrement (`minusCLIK`) buttons
- Dynamic updating of UI elements based on the current value
- Dispatches an event (`QUANTITY_CHANGED`) when the quantity changes

## Code Structure

```as3
package Shared.AS3.COMPANIONAPP {
    // ... imports ...

    public class MobileQuantityMenu extends QuantityMenuNEW {
        // ... code ...
    }
}
```

## Properties

| Property        | Type    | Description                                        |
|-----------------|---------|----------------------------------------------------|
| `sliderCLIK`    | Slider  | The slider control for adjusting the quantity.     |
| `minusCLIK`     | Button  | The button control to decrement the quantity.      |
| `plusCLIK`      | Button  | The button control to increment the quantity.      |
| `_currentCount` | uint    | The current selected quantity value.               |
| `_maxCount`     | uint    | The maximum quantity value that can be selected.   |

## Methods

### MobileQuantityMenu (Constructor)
Initializes the `MobileQuantityMenu` with a maximum quantity.

```as3
public function MobileQuantityMenu(param1:uint) {
    // ... constructor code ...
}
```

### onAddedToStage
Sets up slider and button controls when added to the stage.

```as3
override public function onAddedToStage() : void {
    // ... method code ...
}
```

### onSliderValueChange
Updates the current count when the slider value changes.

```as3
private function onSliderValueChange(param1:SliderEvent) : void {
    // ... method code ...
}
```

### onMinusClick
Decrements the slider value when the minus button is clicked.

```as3
private function onMinusClick(param1:ButtonEvent) : void {
    // ... method code ...
}
```

### onPlusClick
Increments the slider value when the plus button is clicked.

```as3
private function onPlusClick(param1:ButtonEvent) : void {
    // ... method code ...
}
```

### updateSliderVisual
Updates the visual state of the slider based on its current value.

```as3
protected function updateSliderVisual() : void {
    // ... method code ...
}
```

### count (getter and setter)
Gets or sets the current count. Dispatches `QUANTITY_CHANGED` event on change.

```as3
override public function get count() : uint {
    // ... getter code ...
}

override public function set count(param1:uint) : * {
    // ... setter code ...
}
```

### redrawUIComponent
Redraws the UI components of the quantity menu.

```as3
override public function redrawUIComponent() : void {
    // ... method code ...
}
```

### ProcessUserEvent
Processes user events (currently not implemented).

```as3
override public function ProcessUserEvent(param1:String, param2:Boolean) : Boolean {
    // ... method code ...
}
```

## Component Setup Functions
These functions set up the slider and button components with initial properties.

- `__setProp_sliderCLIK_MobileQuantityMenu_CLIKSlider_0`
- `__setProp_minusCLIK_MobileQuantityMenu_arrows_0`
- `__setProp_plusCLIK_MobileQuantityMenu_arrows_0`

## Usage

To use `MobileQuantityMenu`, instantiate it with the maximum quantity, then add it to the stage. Interact with the slider or buttons to adjust the quantity, and listen for the `QUANTITY_CHANGED` event to handle changes.

```as3
var quantityMenu:MobileQuantityMenu = new MobileQuantityMenu(10);
addChild(quantityMenu);
quantityMenu.addEventListener(MobileQuantityMenu.QUANTITY_CHANGED, onQuantityChanged);

function onQuantityChanged(event:CustomEvent):void {
    // Handle quantity change
}
```

## Event Constants

| Event Constant      | Value            | Description                              |
|---------------------|------------------|------------------------------------------|
| `QUANTITY_CHANGED`  | "QuantityChanged"| Dispatched when the quantity value changes. |

**Note**: Replace `onQuantityChanged` with your own event handler function.
