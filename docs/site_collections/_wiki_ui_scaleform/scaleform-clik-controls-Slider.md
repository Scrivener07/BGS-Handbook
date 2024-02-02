---
---
# Slider
`Slider.as` is a code file containing the definition for a customizable Slider control, which is a user interface component within the Scaleform CLIK (Common Lightweight Interface Kit) framework.
The component allows users to select a value by moving a slider thumb along a track.
This control is typically used for adjusting settings like volume or brightness.

Below is the detailed documentation for the `Slider` class, including its properties, methods, and events.

## Table of Contents

- [Class Overview](#class-overview)
- [Public Variables](#public-variables)
- [Protected Variables](#protected-variables)
- [Public Methods](#public-methods)
- [Protected Methods](#protected-methods)
- [Events](#events)

## Class Overview

```as3
package scaleform.clik.controls {
    import scaleform.clik.core.UIComponent;
    ...

    public class Slider extends UIComponent {
        ...
    }
}
```

The `Slider` class extends the `UIComponent` class from the Scaleform CLIK framework.

## Public Variables

| Variable         | Type    | Description                         | Default Value |
|------------------|---------|-------------------------------------|---------------|
| `liveDragging`   | Boolean | Enables live update of value during drag. | `true`        |
| `state`          | String  | Represents the current state of the slider. | `"default"`   |
| `offsetLeft`     | Number  | Left offset for the thumb position. | `0`           |
| `offsetRight`    | Number  | Right offset for the thumb position.| `0`           |
| `thumb`          | Button  | Reference to the slider's thumb button. |               |
| `track`          | Button  | Reference to the slider's track button. |               |

## Protected Variables

| Variable               | Type    | Description                                        |
|------------------------|---------|----------------------------------------------------|
| `_minimum`             | Number  | The minimum value of the slider.                   |
| `_maximum`             | Number  | The maximum value of the slider.                   |
| `_value`               | Number  | The current value of the slider.                   |
| `_snapInterval`        | Number  | The interval at which the slider snaps.            |
| `_snapping`            | Boolean | Whether the snapping feature is enabled.           |
| `_dragOffset`          | Object  | The offset of the drag operation.                  |
| `_trackDragMouseIndex` | Number  | Mouse index when the track is being dragged.       |
| `_trackPressed`        | Boolean | Indicates if the track button is pressed.          |
| `_thumbPressed`        | Boolean | Indicates if the thumb button is pressed.          |

## Public Methods

### `Slider()`
Constructor for the `Slider` class.

### Getters and Setters

- **`enabled` (Boolean)**
  - getter: Returns the enabled state of the slider.
  - setter: Sets the slider's enabled state and propagates to child components.

- **`focusable` (Boolean)**
  - getter: Returns whether the slider can receive focus.
  - setter: Sets the focusable state.

- **`value` (Number)**
  - getter: Returns the current value of the slider.
  - setter: Sets the slider's value, clamping it within minimum and maximum bounds.

- **`maximum` (Number)**
  - getter: Returns the maximum value of the slider.
  - setter: Sets the maximum value of the slider.

- **`minimum` (Number)**
  - getter: Returns the minimum value of the slider.
  - setter: Sets the minimum value of the slider.

- **`position` (Number)**
  - getter: Returns the same value as the `value` getter.
  - setter: Directly sets the value without clamping or dispatching the change event.

- **`snapping` (Boolean)**
  - getter: Returns whether snapping is enabled.
  - setter: Sets the snapping property and invalidates the SETTINGS.

- **`snapInterval` (Number)**
  - getter: Returns the snap interval.
  - setter: Sets the snap interval and invalidates the SETTINGS.

### `invalidateSettings()`
Invalidates the slider's settings, causing a redraw on the next frame.

### `handleInput(param1:InputEvent)`
Handles input events for the slider, adjusting the value based on key navigation.

### `toString()`
Returns a string representation of the `Slider` instance.

## Protected Methods

### `configUI()`
Configures the UI components of the slider.

### `draw()`
Draws the slider's components and updates their states.

### `changeFocus()`
Changes the focus state of the slider.

### `updateThumb()`
Updates the thumb's position based on the current value.

### `beginDrag(param1:MouseEvent)`
Begins the drag operation for the thumb.

### `doDrag(param1:MouseEvent)`
Continues the drag operation and updates the slider's value.

### `endDrag(param1:MouseEvent)`
Ends the drag operation and dispatches the value change event if `liveDragging` is set to false.

### `trackPress(param1:MouseEvent)`
Handles the press event on the track, updating the slider's value accordingly.

### `lockValue(param1:Number)`
Locks the value within the minimum and maximum bounds and applies snapping if enabled.

### `scrollWheel(param1:Number)`
Handles mouse wheel scrolling to adjust the slider's value.

## Events

- **`SliderEvent.VALUE_CHANGE`**
  - Dispatched when the value of the slider changes.

**NOTE:** In the actual code, some methods are marked as `override` and implement or extend functionality provided by the `UIComponent` class.

## Example Usage

```as3
import scaleform.clik.controls.Slider;

var mySlider:Slider = new Slider();
mySlider.minimum = 0;
mySlider.maximum = 100;
mySlider.snapInterval = 5;

mySlider.addEventListener(SliderEvent.VALUE_CHANGE, onSliderChange);

function onSliderChange(event:SliderEvent):void {
    trace("Slider value changed to: " + event.value);
}
```

---

📘 **Please note:**
This documentation assumes familiarity with AS3 (ActionScript 3) and Scaleform CLIK components.
The actual behavior and integration of the `Slider` component might require additional context regarding its environment and use within a user interface system, such as a game's UI.
