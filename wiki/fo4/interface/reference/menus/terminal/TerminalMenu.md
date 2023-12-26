# Terminal.as Documentation

## Overview

The `Terminal` class is an ActionScript 3.0 class that is designed to function as an interactive terminal within a user interface system.

It inherits from `IMenu` and contains numerous elements for text display, input handling, and visual feedback such as blinking cursors and highlights.

The following documentation provides an overview of the properties and methods within the `Terminal` class.

## Properties

The `Terminal` class contains a wide array of properties which are primarily used for managing the user interface elements such as text fields, movie clips, and menu items.

| **Property**                  | **Type**             | **Description**                                                                                           |
|-------------------------------|----------------------|-----------------------------------------------------------------------------------------------------------|
| `HeaderText_tf`               | `TextField`          | Text field for the header text.                                                                           |
| `WelcomeText_tf`              | `TextField`          | Text field for the welcome message.                                                                       |
| `DisplayText_tf`              | `TextField`          | Main text field for displaying terminal text.                                                             |
| `ResponsePrompt_tf`           | `TextField`          | Text field used for input prompts.                                                                        |
| `ResponseText_tf`             | `TextField`          | Text field to show user's input text.                                                                     |
| `ResponseLog_tf`              | `TextField`          | Text field for logging responses.                                                                         |
| `HackingAttempts_tf`          | `TextField`          | Text field showing the number of hacking attempts left.                                                   |
| `MenuItemList_mc`             | `MenuItemList`       | MovieClip that handles the menu item list.                                                                |
| `BlinkingCursor_mc`           | `MovieClip`          | MovieClip for the blinking cursor animation.                                                              |
| `HackingHighlight1_mc`        | `MovieClip`          | MovieClip for the first hacking highlight.                                                                |
| `HackingHighlight2_mc`        | `MovieClip`          | MovieClip for the second hacking highlight.                                                               |
| `HackingGuessX_mc`            | `MovieClip`          | MovieClips for hacking guess indicators, where X can be from 1 to 5.                                      |
| `BGSCodeObj`                  | `Object`             | Generic object used for passing around code references.                                                   |
| `strHeaderText`               | `String`             | String for storing header text.                                                                           |
| `strWelcomeText`              | `String`             | String for storing welcome text.                                                                          |
| `strDisplayText`              | `String`             | String for storing display text.                                                                          |
| `strResponseText`             | `String`             | String for storing response text.                                                                         |
| `timer`                       | `Timer`              | Timer used for text animation.                                                                            |
| `iTickCount`                  | `int`                | Counter to store the tick count of the timer.                                                             |
| `bAnimateResponseText`        | `Boolean`            | Flag to determine if the response text should be animated.                                                |
| `bAnimateDisplayText`         | `Boolean`            | Flag to determine if the display text should be animated.                                                 |
| `bShowHackingAttempts`        | `Boolean`            | Flag to determine if hacking attempts should be shown.                                                    |
| `bAcceptDebounce`             | `Boolean`            | Debouncing flag for input acceptance.                                                                     |
| `displayText_x`, `displayText_y`, `displayText_width`, `displayText_height` | `Number`   | Coordinates and dimensions for display text positioning.                                                  |
| `responsePrompt_x`, `responsePrompt_y`, `responseText_x`, `responseText_y`, `responseText_width` | `Number` | Coordinates for response prompt and text positioning. |
| `displayTextMenuBuffer_y`     | `Number`             | Vertical spacing buffer for the display text menu.                                                        |
| `menuItemList_y`              | `Number`             | Y coordinate for the menu item list.                                                                      |
| `menuItemList_height`         | `Number`             | Height of the menu item list.                                                                             |
| `menuItemList_scrollDownY`    | `Number`             | Y coordinate for the menu item list's scroll down button.                                                 |
| `displayText_startChar`       | `Number`             | Starting character index for animated display text.                                                       |
| `displayText_isDone`          | `Boolean`            | Flag to determine if the display text is done animating.                                                  |
| `DisplayImage_mc`             | `MovieClip`          | MovieClip to display an image within the terminal.                                                        |
| `DisplayImageLoader`          | `Loader`             | Loader to handle image loading for the display image.                                                     |
| `ncharRemainder`              | Private variable     | Remainder variable for character calculations during animations.                                          |
| `ucharsPerSec`                | Private variable     | Characters per second for text animation.                                                                 |

## Methods

The `Terminal` class includes methods for text animations, mouse interactions, text updates, timer control, and much more.

### Public Methods

| **Method**                    | **Return Type**      | **Description**                                                                                           |
|-------------------------------|----------------------|-----------------------------------------------------------------------------------------------------------|
| `Terminal`                    | Constructor          | Initializes the terminal, sets up properties, and event listeners.                                        |
| `onCodeObjCreate`             | `void`               | Sets up additional properties once the code object is created.                                             |
| `playSelectSound`             | `void`               | Plays sound associated with selection.                                                                    |
| `RegisterTerminalElements`    | `void`               | Registers the terminal elements and sets up event listeners.                                               |
| `DisplayHack`                 | `void`               | A placeholder method for future functionality related to display hacks.                                    |
| `AnimateText`                 | `void`               | Begins the text animation process.                                                                        |
| `onTextOver`                  | `void`               | Handles mouse over events on the text.                                                                    |
| `onTextClick`                 | `void`               | Validates the hacking word when text is clicked.                                                          |
| `ConvertToGlobal`             | `Point`              | Converts the position of a `TextField` to a global point.                                                 |
| `UpdateTextField`             | `void`               | Updates a `TextField` with new text.                                                                      |
| `UpdateText`                  | `void`               | Updates the display and response texts based on animation needs.                                          |
| `SetCursorPosition`           | `void`               | Sets the position of the blinking cursor.                                                                 |
| `ShowHackingHighlight`        | `void`               | Shows or hides the hacking highlights on the display text.                                                |
| `StartTimer`                  | `void`               | Starts the text animation timer.                                                                          |
| `StopTimer`                   | `void`               | Stops the text animation timer.                                                                           |
| `IsTextAnimating`             | `Boolean`            | Determines if the text is currently animating.                                                            |
| `FinishAnimatingText`         | `void`               | Finishes animating text instantly.                                                                        |
| `set headerText`              | `void`               | Setter for `strHeaderText`.                                                                               |
| `set welcomeText`             | `void`               | Setter for `strWelcomeText`.                                                                              |
| `set displayText`             | `void`               | Setter for `strDisplayText`.                                                                              |
| `DisplayTextNextPage`         | `void`               | Prepares the next page of display text for animation.                                                     |
| `IsDisplayTextDone`           | `Boolean`            | Checks if the display text has finished animating.                                                        |
| `set responseText`            | `void`               | Setter for `strResponseText`.                                                                             |
| `SetDisplayMode`              | `void`               | Sets the display mode for hacking or standard display.                                                    |
| `PushResponseLog`             | `void`               | Appends text to the response log.                                                                         |
| `ShowHackingGuesses`          | `void`               | Shows or hides the hacking guess indicators.                                                              |
| `RemoveGuessBlock`            | `void`               | Removes one block from the hacking guess indicators.                                                      |
| `ProcessUserEvent`            | `Boolean`            | Processes user input events and stops text animation if needed.                                           |
| `LoadDisplayImage`            | `void`               | Loads an image to be displayed in the terminal.                                                           |
| `onItemPress`                 | `void`               | Handles item press events within the menu list.                                                           |
| `onMouseClick`                | `void`               | Responds to mouse click events.                                                                           |
| `__setProp_MenuItemList_mc_TerminalBase_Layer1_0` | `void` | Component Inspector setting method for `MenuItemList_mc`.                                                |

### Private Methods

| **Method**                    | **Return Type**      | **Description**                                                                                           |
|-------------------------------|----------------------|-----------------------------------------------------------------------------------------------------------|
| `onDisplayImageLoadComplete`  | `void`               | Event handler for when the display image has loaded successfully.                                         |

## Events

The class sets up several event listeners for handling selection changes, item presses, mouse events, and timer events.

## Usage Example

To create an instance of the `Terminal` class in your ActionScript 3.0 project, you can do the following:

```as3
var terminalInstance:Terminal = new Terminal();
addChild(terminalInstance);
```

Once created, you can interact with the terminal through its public methods and properties. For instance, to start animating some display text, you would set the `displayText` property:

```as3
terminalInstance.displayText = "Welcome to the Terminal Interface!";
```

After setting up the text, you could then start the animation process:

```as3
terminalInstance.StartTimer();
```

It's important to note that you would also need to provide the necessary artwork, sounds, and other resources for the terminal to function fully within your user interface implementation.

## Conclusion

In summary, the `Terminal` class is a complex and feature-rich class designed to manage and animate a terminal-like interface in an ActionScript 3.0 environment. It includes support for text display and animations, sound playback, input handling, and hacking game mechanics.
