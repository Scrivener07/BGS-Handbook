---
title: "MessageBoxMenu"
---

`MessageBoxMenu.as` is an ActionScript file that defines a custom menu interface for displaying a message box with an associated list of selectable options.
This menu is an extension of the `IMenu` class and contains various components such as a text field for the body message, a scrolling list for options, and movie clips for background elements.


## Components

The following table outlines the main components of the `MessageBoxMenu` class:

| Component          | Type                 | Description                                           |
|--------------------|----------------------|-------------------------------------------------------|
| `Body_tf`          | `TextField`          | Text field for displaying the message body.           |
| `List_mc`          | `BSScrollingList`    | Scrolling list for displaying selectable options.     |
| `BGRect_mc`        | `MovieClip`          | Movie clip for the main background.                   |
| `BGRectBlack_mc`   | `MovieClip`          | Movie clip for a secondary, potentially black, background. |
| `BGSCodeObj`       | `Object`             | Object containing code interface for button presses and focus sounds. |

## Properties

- **bodyText (`String`)**
  - Getter that returns the text of the `Body_tf` text field.
  - Setter that updates the `Body_tf` text field with a new message.

- **buttonArray (`Array`)**
  - Getter that returns an array of entries in the `List_mc`.
  - Setter that updates the `List_mc` with a new array of button entries.

- **selectedIndex (`uint`)**
  - Getter that returns the index of the selected item in the `List_mc`.

- **menuMode (`Boolean`)**
  - Setter that updates the menu mode, affecting the visibility of the black background.

---

## Methods

### Public Methods

- **MessageBoxMenu()**
  - Constructor for the `MessageBoxMenu` class. It initializes properties and event listeners.

- **ForceInit()**
  - Initializes the list if it hasn't been populated yet with list items.

- **InvalidateMenu()**
  - Updates the layout of the menu components based on the content and prepares the menu for visibility.

### Private Methods

- **initDisableInputCounter()**
  - A frame-based counter to delay input enabling for the list, ensuring it is not immediately selectable.

- **onItemPress(`Event`)**
  - Event handler for when a list item is pressed. It calls an external interface function for button press logic.

- **playFocusSound()**
  - Triggers a focus sound effect when a list item gains focus.

### Special Methods

- **__setProp_BGRect_mc_MenuObj_Background_0()**
  - Used for component inspector settings for the background movie clip.

- **__setProp_List_mc_MenuObj_ButtonList_0()**
  - Configures the list movie clip with component inspector settings.


## Usage Example

```actionscript
// Create a new MessageBoxMenu instance
var messageBoxMenu:MessageBoxMenu = new MessageBoxMenu();

// Set the body text of the message box
messageBoxMenu.bodyText = "Are you sure you want to continue?";

// Define button options for the message box
var buttons:Array = [
    {label: "Yes", buttonIndex: 0},
    {label: "No", buttonIndex: 1}
];

// Set the button array
messageBoxMenu.buttonArray = buttons;

// Force initialize the menu if needed
messageBoxMenu.ForceInit();

// Update the menu layout
messageBoxMenu.InvalidateMenu();
```
