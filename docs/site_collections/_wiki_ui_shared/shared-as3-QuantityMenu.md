---
---
# QuantityMenu
The `QuantityMenu` class, located in the `QuantityMenu.as` file, is an ActionScript 3 class that extends the `MovieClip` class from the `flash.display` package.
This class is responsible for managing a quantity menu, which allows users to adjust the quantity of an item, typically within a user interface for a game or similar application.

## Features
- Open and close the quantity menu interface
- Scroll through quantities using keyboard or mouse input
- Dynamically adjust the visible menu elements based on content

## Constants

| Constant                            | Type    | Description                                                          |
|-------------------------------------|---------|----------------------------------------------------------------------|
| `QUANTITY_CHANGED`                  | String  | Event name for when the quantity has been changed.                   |
| `CONFIRM`                           | String  | Event name for when the quantity is confirmed.                       |
| `INV_MAX_NUM_BEFORE_QUANTITY_MENU`  | uint    | The max number of items before the quantity menu is needed.          |

## Properties

| Property                       | Type                | Description                                           |
|--------------------------------|---------------------|-------------------------------------------------------|
| `Label_tf`                     | TextField           | The text field for the label.                         |
| `Value_tf`                     | TextField           | The text field for the current value.                 |
| `TotalValue_tf`                | TextField           | The text field for the total value.                   |
| `CapsLabel_tf`                 | TextField           | The text field for the caps label.                    |
| `QuantityScrollbar_mc`         | Option_Scrollbar    | The scrollbar control for adjusting the quantity.     |
| `QuantityBracketHolder_mc`     | MovieClip           | The MovieClip that holds the brackets around the menu.|

## Public Methods

### `QuantityMenu()`
Constructor for the `QuantityMenu` class. Initializes the object and event listeners for keyboard and mouse events.

### `OpenMenu(aiQuantity:int, aPrevFocusObj:InteractiveObject, asLabelText:String = "", auiItemValue:* = 0)`
Opens the quantity menu with specified parameters.

- **aiQuantity**: The initial quantity.
- **aPrevFocusObj**: The previous focus object before the menu was opened.
- **asLabelText**: The label text to display, defaults to an empty string.
- **auiItemValue**: The value of the item.

### `CloseMenu()`
Closes the quantity menu, restoring focus to the previous object.

## Protected Methods

### `FitBrackets()`
Adjusts bracket positions to fit around the label text.

### `RefreshText()`
Refreshes the text fields to display current quantity and total value.

### `modifyQuantity(aiQuantity:int)`
Modifies the current item quantity and refreshes the text display.

- **aiQuantity**: The amount by which to change the quantity.

### `ProcessUserEvent(asEvent:String, bData:Boolean) : Boolean`
Processes user events like shoulder button presses to adjust the quantity.

- **asEvent**: The event string.
- **bData**: Boolean data associated with the event.

## Event Handling Methods

### `onKeyDown(event:KeyboardEvent)`
Handles key down events for scrolling the quantity.

### `onKeyUp(event:KeyboardEvent)`
Handles key up events for stopping quantity scrolling and confirming the selection.

### `onMouseWheel(event:MouseEvent)`
Handles mouse wheel events for modifying the quantity.

### `onArrowMouseUp(e:Event)`
Handles mouse up events after scrolling has started.

### `onArrowTick(e:Event)`
Handles the event for continuous scrolling when arrow keys are held down.

### `onValueChange(e:Event)`
Handles the event when the scrollbar's value is changed.

### `onArrowMouseDown(event:MouseEvent)`
Handles mouse down events on the scrollbar's arrows.

## Example Usage
```actionscript
var quantityMenu:QuantityMenu = new QuantityMenu();
// Open the quantity menu with a quantity of 10, no previous focus object, and an item value of 100.
quantityMenu.OpenMenu(10, null, "Quantity", 100);
// The user interacts with the quantity menu (via keyboard or mouse).
// Event listeners within the class handle these interactions.
// Close the quantity menu when done.
quantityMenu.CloseMenu();
```

## Notes
- The class makes use of several private variables to manage state and input handling.
- Custom events such as `QUANTITY_CHANGED` and `CONFIRM` are dispatched for external handling by other parts of the application.
- The `ProcessUserEvent` method suggests integration with a control scheme for a game or similar interface.

## Conclusion
The `QuantityMenu` class provides an interactive and dynamically adjustable menu for changing quantities, useful in various applications where users need to select a number of items or adjust values in a UI environment.
