---
---
# BSSlider
The `BSSlider.as` class is a custom slider component for ActionScript 3 that extends the `BSUIComponent` class.

Below is the documentation for the `BSSlider` class, detailing its properties, methods, and functionalities.

## Table of Contents

- [Class Definition](#class-definition)
- [Constants](#constants)
- [Properties](#properties)
- [Constructor](#constructor)
- [Public Methods](#public-methods)
- [Private Methods](#private-methods)
- [Event Handlers](#event-handlers)
- [Override Methods](#override-methods)

---

## Class Definition

```as3
package Shared.AS3 {
    import Shared.CustomEvent;
    import flash.display.MovieClip;
    import flash.events.MouseEvent;
    // ... More imports

    public class BSSlider extends BSUIComponent {
        // ... Class contents
    }
}
```

## Constants

| Name             | Type   | Description                                         |
| ---------------- | ------ | --------------------------------------------------- |
| `VALUE_CHANGED`  | String | Event constant representing when the slider changes |

## Properties

| Name                         | Type          | Description                                             |
| ---------------------------- | ------------- | ------------------------------------------------------- |
| `SliderBackground_mc`        | MovieClip     | The background display object for the slider            |
| `Marker_mc`                  | MovieClip     | The marker or handle of the slider                      |
| `Fill_mc`                    | MovieClip     | The filled part of the slider                           |
| `LeftArrow_mc`               | MovieClip     | The MovieClip for the left arrow button                 |
| `RightArrow_mc`              | MovieClip     | The MovieClip for the right arrow button                |
| `_iMaxValue`                 | uint          | Private variable to store the maximum slider value      |
| `_iValue`                    | uint          | Private variable to store the current slider value      |
| `_iMinValue`                 | uint          | Private variable to store the minimum slider value      |
| `_fValueFillIncrement`       | Number        | The increment for the fill when the slider value changes|
| `_fFillLength`               | Number        | The length of the fill area                             |
| `LEFT_X`                     | Number        | X-coordinate for left boundary                          |
| `RIGHT_X`                    | Number        | X-coordinate for right boundary                         |
| `_SliderMarkerBoundBox`      | Rectangle     | Boundary box for the slider marker                      |
| `_bIsDragging`               | Boolean       | Indicates if the user is currently dragging the marker  |
| `_iControllerBumperJumpSize` | Any           | Size of the jump when using a controller bumper         |
| `_iControllerTriggerJumpSize`| Any           | Size of the jump when using a controller trigger        |

## Constructor

**BSSlider**

Initializes the slider with default settings and event listeners for dragging functionality.

```as3
public function BSSlider() {
    // Constructor code...
}
```

## Public Methods

**Getters and Setters**

The following methods are used to get and set the properties of the slider:

- `sliderWidth`
- `minValue`
- `value`
- `maxValue`
- `markerPosition`
- `controllerBumberJumpSize`
- `controllerTriggerJumpSize`

**valueJump**

Allows to jump the slider's value by a given amount.

```as3
public function valueJump(param1:int) : * {
    // Implementation...
}
```

**ProcessUserEvent**

Processes controller events to adjust the slider value.

```as3
public function ProcessUserEvent(param1:String, param2:Boolean) : Boolean {
    // Implementation...
}
```

## Private Methods

**onBeginDrag**

Handles the start of a drag operation on the marker.

```as3
private function onBeginDrag(param1:MouseEvent) : * {
    // Implementation...
}
```

**onReleaseDrag**

Handles the release of a drag operation on the marker.

```as3
private function onReleaseDrag(param1:MouseEvent) : * {
    // Implementation...
}
```

**onValueDrag**

Updates the value of the slider based on the marker's position during a drag operation.

```as3
private function onValueDrag(param1:MouseEvent) : * {
    // Implementation...
}
```

## Event Handlers

**onKeyDownHandler**

Handles keyboard input for slider adjustments.

```as3
private function onKeyDownHandler(param1:KeyboardEvent) : * {
    // Implementation...
}
```

**onMouseWheelHandler**

Handles mouse wheel input for slider adjustments.

```as3
private function onMouseWheelHandler(param1:MouseEvent) : * {
    // Implementation...
}
```

**onArrowClickHandler**

Handles clicks on the arrow buttons for slider adjustments.

```as3
public function onArrowClickHandler(param1:MouseEvent) : * {
    // Implementation...
}
```

**onSliderBarMouseClickHandler**

Handles clicks on the slider background to adjust the value.

```as3
public function onSliderBarMouseClickHandler(param1:MouseEvent) : * {
    // Implementation...
}
```

## Override Methods

**onAddedToStage**

Sets up the event listeners when the slider is added to the stage.

```as3
override public function onAddedToStage() : void {
    // Implementation...
}
```

**onRemovedFromStage**

Removes event listeners when the slider is removed from the stage.

```as3
override public function onRemovedFromStage() : void {
    // Implementation...
}
```

**redrawUIComponent**

Updates the appearance of the slider components.

```as3
override public function redrawUIComponent() : void {
    // Implementation...
}
```

---

Please use this documentation as a reference for understanding the features and functionalities of the `BSSlider` class in the BSSlider.as file.
