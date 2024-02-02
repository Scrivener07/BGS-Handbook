---
---
# Constraints
This Markdown documentation provides an overview and detailed description of the `Constraints` class found in the `scaleform.clik.utils` package.

The `Constraints` class in ActionScript 3 is used to manage constraints on DisplayObjects within a UIComponent.
It allows elements to be anchored to different sides of a container or aligned centrally, and to adjust their size and position based on the container's size changes.

## Table of Contents

- [Class Definition](#class-definition)
- [Properties](#properties)
- [Methods](#methods)
- [Example Usage](#example-usage)

## Class Definition

```actionscript
package scaleform.clik.utils {
    import flash.display.DisplayObject;
    import flash.display.DisplayObjectContainer;
    import flash.display.Sprite;
    import flash.display.Stage;
    import flash.events.Event;
    import flash.events.EventDispatcher;
    import flash.text.TextField;

    import scaleform.clik.constants.ConstrainMode;
    import scaleform.clik.core.UIComponent;
    import scaleform.clik.events.ResizeEvent;

    public class Constraints extends EventDispatcher {
        // ... Class contents ...
    }
}
```

## Properties

| Property | Type | Description |
|----------|------|-------------|
| `LEFT` | `uint` | A static property representing the left edge constraint. |
| `RIGHT` | `uint` | A static property representing the right edge constraint. |
| `TOP` | `uint` | A static property representing the top edge constraint. |
| `BOTTOM` | `uint` | A static property representing the bottom edge constraint. |
| `ALL` | `uint` | A static property representing all edge constraints. |
| `CENTER_H` | `uint` | A static property representing horizontal center constraint. |
| `CENTER_V` | `uint` | A static property representing vertical center constraint. |
| `scope` | `DisplayObject` | The DisplayObject that this `Constraints` object is managing. |
| `scaleMode` | `String` | The scaling mode for the constraints, default is `"counterScale"`. |
| `parentXAdjust` | `Number` | Horizontal scaling adjustment factor. |
| `parentYAdjust` | `Number` | Vertical scaling adjustment factor. |
| `elements` | `Object` | An associative array of `ConstrainedElement` objects, with string keys. |
| `elementCount` | `int` | The number of elements that have constraints applied. |
| `parentConstraints` | `Constraints` | A reference to the parent's `Constraints` object, if any. |
| `lastWidth` | `Number` | The last recorded width of the scope. |
| `lastHeight` | `Number` | The last recorded height of the scope. |

## Methods

### Public Methods

- `addElement(param1:String, param2:DisplayObject, param3:uint)`: Adds a DisplayObject with a string identifier and specified constraints.
- `removeElement(param1:String)`: Removes the element with the given identifier from the constraints.
- `removeAllElements()`: Clears all elements from the constraints.
- `getElement(param1:String)`: Retrieves the `ConstrainedElement` for the given identifier.
- `updateElement(param1:String, param2:DisplayObject)`: Updates the DisplayObject associated with the given identifier.
- `getXAdjust()`: Calculates and returns the horizontal adjustment factor.
- `getYAdjust()`: Calculates and returns the vertical adjustment factor.
- `update(param1:Number, param2:Number)`: Updates the constraints with the new width and height.
- `toString()`: Returns a string representation of the `Constraints` object.

### Protected Methods

- `handleScopeAddedToStage(param1:Event)`: Handles the addition of the scope to the stage.
- `addToParentConstraints()`: Adds this constraints to the parent's constraints if applicable.
- `handleParentConstraintsResize(param1:ResizeEvent)`: Handles the resize event from the parent's constraints.

## Example Usage

The following example demonstrates how to use the `Constraints` class to set up constraints for elements:

```actionscript
var myConstraints:Constraints = new Constraints(mySprite);
myConstraints.addElement("myTextField", myTextField, Constraints.LEFT | Constraints.TOP);
myConstraints.update(800, 600); // Update constraints with new width and height
```

Please note that this is just a basic usage example. In practice, the `Constraints` class is typically used within a more complex UI framework where elements are dynamically added and adjusted based on container resizing.

---
📝 **Note**: This document uses emojis and Markdown styling to improve readability and organization.
