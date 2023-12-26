# BSUIComponent.as Documentation

The `BSUIComponent` class is a dynamic subclass of `MovieClip` that provides an interface for user interface components within the Shared ActionScript 3 (AS3) package.
It includes features for platform-specific behavior, bracket drawing for visual elements, and shaded background management.

Below is the markdown documentation that provides an overview of the `BSUIComponent` class, its properties, and its methods.

## Class Overview

```as3
package Shared.AS3 {
    public dynamic class BSUIComponent extends MovieClip {
        // ... class members and methods ...
    }
}
```

## Properties

| Property | Type | Description |
|----------|------|-------------|
| `_bIsDirty` | `Boolean` | Indicates whether the component needs to be redrawn. |
| `_iPlatform` | `Number` | Represents the current platform ID. |
| `_bPS3Switch` | `Boolean` | Determines whether the PS3 control scheme is active. |
| `_bAcquiredByNativeCode` | `Boolean` | Specifies if the component has been acquired by native code. |
| `_bShowBrackets` | `Boolean` | Controls the visibility of brackets around the component. |
| `_bUseShadedBackground` | `Boolean` | Determines if a shaded background should be used. |
| `_shadedBackgroundType` | `String` | Defines the type of the shaded background. |
| `_shadedBackgroundMethod` | `String` | Specifies the method used to apply the shaded background. |
| `_bracketPair` | `BSBracketClip` | An instance of `BSBracketClip` used to draw brackets. |
| `_bracketLineWidth` | `Number` | Defines the line width of the brackets. |
| `_bracketCornerLength` | `Number` | Sets the corner length of the brackets. |
| `_bracketPaddingX` | `Number` | The padding on the X-axis for the brackets. |
| `_bracketPaddingY` | `Number` | The padding on the Y-axis for the brackets. |
| `_bracketStyle` | `String` | The style of the brackets (`"horizontal"` or other). |

## Methods

### Public Methods

- **BSUIComponent()**: Constructor. Initializes the component and sets up event listeners.
- **getters and setters**: For each property, there are getter and setter methods to access or update the value accordingly. Setters will flag the component as needing redraw if the value changes.
- **SetIsDirty()**: Marks the component as dirty, triggering a redraw request.
- **onAcquiredByNativeCode()**: Callback when the component is acquired by native code.
- **UpdateBrackets(bRedrawBrackets:Boolean)**: Updates and redraws the brackets if necessary.
- **onAddedToStage()**: Lifecycle method called when the component is added to the stage; requests a redraw if dirty.
- **onRemovedFromStage()**: Lifecycle method called when the component is removed from the stage; cleans up event listeners.
- **redrawUIComponent()**: Provides an interface for subclasses to implement custom drawing code.
- **SetPlatform(aiPlatform:Number, abPS3Switch:Boolean)**: Updates the platform ID and PS3 switch state and marks the component as dirty.

### Private Methods

- **ClearIsDirty()**: Resets the dirty flag to false.
- **requestRedraw()**: Requests a redraw of the component.
- **UpdateBrackets(bRedrawBrackets:Boolean)**: Helper to draw or clear the bracket visuals.

## Event Handling

The `BSUIComponent` class listens for various stage events to manage its lifecycle and drawing state:

- **Event.ADDED_TO_STAGE**: Sets up additional event listeners and performs initial setup.
- **Event.REMOVED_FROM_STAGE**: Cleans up event listeners and performs any necessary teardown.
- **Event.RENDER**: Invoked when the component needs to be redrawn.
- **Event.ENTER_FRAME**: Used to defer drawing operations until the next frame.

## Example Usage

Below is an example of how to create a `BSUIComponent` instance and configure some of its properties.

```as3
var myComponent:BSUIComponent = new BSUIComponent();
myComponent.bShowBrackets = true;
myComponent.bracketLineWidth = 2;
myComponent.bracketPaddingX = 5;
myComponent.bracketPaddingY = 5;
addChild(myComponent);
```

📝 **Note:** The actual drawing operations and any platform-specific behavior must be implemented in the `redrawUIComponent()` method within subclasses.
