# FocusHandler.as Documentation

The `FocusHandler.as` file is part of the `scaleform.clik.managers` package and is responsible for managing focus within the Scaleform CLIK (Common Lightweight Interface Kit) UI components.
It handles the focus transitions between UI components, specifically when working with different input devices like game controllers or the keyboard.

Below is detailed documentation for the `FocusHandler` class.

## Class Overview

**FocusHandler**

- Manages focus for UI components.
- Handles input events for focus control.
- Interacts with the `FocusManager` for Scaleform-specific functionality.

## Properties

| Property | Type | Description |
| ---------| ---- | ----------- |
| `instance` | `FocusHandler` | The singleton instance of the `FocusHandler`. |
| `initialized` | `Boolean` | Indicates whether the `FocusHandler` has been initialized. |
| `_stage` | `Stage` | The reference to the Stage where the UI components exist. |
| `currentFocusLookup` | `Dictionary` | A lookup table to keep track of the current focus per controller index. |
| `actualFocusLookup` | `Dictionary` | A lookup table to keep track of the actual focus per controller index. |
| `preventStageFocusChanges` | `Boolean` | A flag to prevent focus changes on the stage, used during certain events. |
| `mouseDown` | `Boolean` | Indicates whether the mouse button is currently pressed down. |

## Methods

### Public Methods

#### `FocusHandler()`
Constructor for the `FocusHandler` class. Initializes lookup dictionaries.

#### `getInstance(): FocusHandler`
Retrieve the singleton instance of the `FocusHandler`.

#### `init(stage:Stage, root:UIComponent): void`
Initializes the `FocusHandler` with a reference to the Stage and root UIComponent.

#### `set stage(stage:Stage): void`
Sets the stage for the `FocusHandler` and adds necessary event listeners for focus management.

#### `getFocus(controllerIndex:uint): InteractiveObject`
Retrieves the current focused object for the specified controller index.

#### `setFocus(newFocus:InteractiveObject, controllerIndex:uint = 0, mouseChange:Boolean = false): void`
Sets the focus to the specified `InteractiveObject` for a given controller index and optionally indicates if the change was triggered by a mouse event.

### Protected Methods

#### `getCurrentFocusDisplayObject(controllerIndex:uint): InteractiveObject`
Retrieves the current focus display object for the given controller index.

#### `setCurrentFocusDisplayObject(controllerIndex:uint, newFocus:InteractiveObject): void`
Sets the current focus display object for the specified controller index.

#### `getActualFocusDisplayObject(controllerIndex:uint): InteractiveObject`
Retrieves the actual focus display object for the given controller index.

#### `setSystemFocus(newFocus:InteractiveObject, controllerIndex:uint = 0): void`
Sets the system focus to the specified `InteractiveObject` for a given controller index.

#### `getSystemFocus(controllerIndex:uint = 0): InteractiveObject`
Gets the system focus for a given controller index.

#### `clearFocusPrevention(event:Event): void`
Clears the flag that prevents focus changes on the stage.

#### `input(details:InputDetails): void`
Processes an input event and dispatches it further if needed.

#### `trackMouseDown(event:MouseEvent): void`
Tracks the mouse button state (down or up).

#### `handleInput(event:InputEvent): void`
Handles input events and determines if focus needs to be changed based on user navigation.

#### `handleMouseFocusChange(event:FocusEvent): void`
Handles focus change events triggered by mouse interactions.

#### `handleFocusChange(focusedObject:InteractiveObject, relatedObject:InteractiveObject, event:FocusEvent): void`
Handles focus change events and updates the actual focus accordingly.

#### `updateActualFocus(event:FocusEvent): void`
Updates the actual focus based on focus in/out events.

#### `handleTextFieldInput(navigationCode:String, controllerIndex:uint): Boolean`
Handles special input cases for `TextField` objects and returns a boolean indicating whether the input was handled or not.

## Usage Example

To initialize the `FocusHandler` within your UIComponent:

```actionscript
var stageRef:Stage = this.stage;
var rootComponent:UIComponent = this; // Your main UIComponent

FocusHandler.init(stageRef, rootComponent);
```

To set the focus to a specific UI component:

```actionscript
var myButton:InteractiveObject = myButtonInstance; // Your button instance
FocusHandler.instance.setFocus(myButton);
```

## Notes

- The `FocusHandler` is typically used within the context of a larger user interface built with Scaleform CLIK components.
- The `FocusHandler` utilizes event listeners extensively to track focus changes and input events, ensuring seamless focus management across various UI components.
- This class has a strong dependency on other Scaleform components such as `FocusManager`, `InputDelegate`, and `UIComponent`.
- The `FocusHandler` keeps track of focus using two types of lookup tables: one for the current focus and another for the actual focus, implementing a weak reference pattern to avoid memory leaks.
- The actual focus may differ from the current focus to handle cases where the Stage focus is different from the component focus, especially with `TextField` components.

## Conclusion

Through careful management of focus and input events, the `FocusHandler` class provides robust support for user interaction within the Scaleform CLIK framework, accommodating both traditional inputs like keyboard and mouse, as well as game controller inputs.
