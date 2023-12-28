---
title: "Console"
---

The '''Console Menu''' is where [[Console Command]]s may be executed.

== AS3 ==
* <code>var BGSCodeObj:Object</code>
* <code>var CommandEntry:TextField</code>
* <code>var Background:MovieClip</code>
* <code>var CommandHistory:TextField</code>
* <code>var CurrentSelection:TextField</code>
* <code>var CommandPrompt_tf:TextField</code>
* <code>function get shown():Boolean</code>
* <code>function get hiding():Boolean</code>
* <code>function set currentSelection(param1:String):*</code>
* <code>function set historyCharBufferSize(param1:uint):*</code>
* <code>function set historyTextColor(param1:uint):*</code>
* <code>function set textColor(param1:uint):*</code>
* <code>function set textSize(param1:uint):*</code>
* <code>function set size(param1:Number):*</code>
* <code>function PositionTextFields():*</code>
* <code>function Show():*</code>
* <code>function ShowComplete():*</code>
* <code>function Hide():*</code>
* <code>function HideComplete():*</code>
* <code>function Minimize():*</code>
* <code>function PreviousCommand():*</code>
* <code>function NextCommand():*</code>
* <code>function AddHistory(param1:String):*</code>
* <code>function SetCommandPrompt(param1:String):*</code>
* <code>function ClearHistory():*</code>
* <code>function ResetCommandEntry():*</code>
* <code>function onKeyUp(param1:KeyboardEvent):*</code>
* <code>function onResize():*</code>

==== BGSCodeObj ====
* <code>function onHideComplete():void</code>
* <code>function executeCommand(command:String):void</code>

== See Also ==
*[[Menu]]
*[[User Interface]]
*[[Console Command]]


[[Category:User Interface]]







# Console.as Documentation

---

## Overview

The `Console.as` is an ActionScript 3 class that defines functionality for a console interface within a Flash application.
It enables users to input commands, navigate command history, and adjust the visual aspects of the console.

## Class Definition

```as3
package {
  // Import statements...
  public class Console extends MovieClip {
    // Property and method definitions...
  }
}
```

## Properties

| Property                  | Type            | Description                                                  |
|---------------------------|-----------------|--------------------------------------------------------------|
| `BGSCodeObj`              | `Object`        | An object for interfacing with the underlying game console.   |
| `CommandEntry`            | `TextField`     | The text field where the user enters commands.               |
| `Background`              | `MovieClip`     | The background movie clip for the console.                   |
| `CommandHistory`          | `TextField`     | The text field displaying the history of entered commands.   |
| `CurrentSelection`        | `TextField`     | The text field showing the current selection.                |
| `CommandPrompt_tf`        | `TextField`     | The text field showing the command prompt.                   |

## Constants

| Constant                 | Type    | Description                                              |
|--------------------------|---------|----------------------------------------------------------|
| `PREVIOUS_COMMANDS`      | `uint`  | The number of previous commands to store.                |
| `HistoryCharBufferSize`  | `uint`  | The character buffer size for the command history.       |

## Methods

### Public Methods

- `Console()`: Constructor that initializes the console.
- `shown`: Getter that returns whether the console is shown and not animating.
- `hiding`: Getter that returns whether the console is in the process of hiding.
- `set currentSelection(value:String)`: Setter to change the current selection text.
- `set historyCharBufferSize(value:uint)`: Setter to change the character buffer size.
- `set historyTextColor(value:uint)`: Setter to change the text color of the command history.
- `set textColor(value:uint)`: Setter to change the text color of command entry and selection.
- `set textSize(value:uint)`: Setter to change the text size of all text fields.
- `set size(value:Number)`: Setter to change the size of the console based on screen percentage.
- `PositionTextFields()`: Method to reposition text fields when the console size changes.
- `Show()`: Method to show the console.
- `ShowComplete()`: Method to set the state when the console showing animation is complete.
- `Hide()`: Method to hide the console.
- `HideComplete()`: Method to set the state when the console hiding animation is complete.
- `Minimize()`: Method to minimize the console.
- `PreviousCommand()`: Method to navigate to the previous command in history.
- `NextCommand()`: Method to navigate to the next command in history.
- `AddHistory(command:String)`: Method to add a command to the history.
- `SetCommandPrompt(prompt:String)`: Method to set the command prompt text.
- `ClearHistory()`: Method to clear the command history.
- `ResetCommandEntry()`: Method to reset the command entry.
- `onKeyUp(event:KeyboardEvent)`: Event handler for key up events.
- `onResize()`: Event handler for stage resize events.

### Private Methods

- None

## Events

| Event Type          | Listener        | Description                                    |
|---------------------|-----------------|------------------------------------------------|
| `Event.RESIZE`      | `onResize`      | Handles stage resize events to adjust the console layout. |
| `KeyboardEvent.KEY_UP` | `onKeyUp`    | Handles key up events for command execution and navigation. |

---

## Usage Example

```as3
var myConsole:Console = new Console();
addChild(myConsole);
```

## Notes

- The `Console` class utilizes the `scaleform.gfx` extension for advanced text field manipulation.
- The console's interface elements (text fields, movie clips) are assumed to be set up within the Flash environment and linked to the class through instance names.
- The `BGSCodeObj` object is intended to provide a bridge to the game's or application's code logic for command execution.
- Customization of the console's appearance and behavior can be achieved through the setter methods provided.

---

📂 **Filename**: `Console.as`

**Bold** elements are key components and functionality within the class definition that enable the `Console` to operate within a Flash application.
