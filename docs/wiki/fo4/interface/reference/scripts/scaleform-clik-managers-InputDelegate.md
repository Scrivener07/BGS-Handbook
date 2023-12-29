# InputDelegate
The `InputDelegate` class is part of the `scaleform.clik.managers` package, which is used to manage input events in Scaleform user interfaces, commonly used in video game development.
The `InputDelegate` class is designed to handle keyboard input and dispatch custom input events within the Scaleform CLIK framework.

## File Overview

**Filename:** `InputDelegate.as`

## Class Definition

```actionscript
public class InputDelegate extends EventDispatcher
```

The `InputDelegate` class extends the `EventDispatcher` class to allow for event handling functionality.

## Properties

| Property               | Type               | Description                                                                      |
|------------------------|--------------------|----------------------------------------------------------------------------------|
| `instance`             | InputDelegate      | A static instance of the `InputDelegate`. This is used to implement a singleton. |
| `MAX_KEY_CODES`        | uint (static const)| The maximum number of keycodes supported by the delegate.                        |
| `KEY_PRESSED`          | uint (static const)| A static constant indicating a key is pressed.                                   |
| `KEY_SUPRESSED`        | uint (static const)| A static constant indicating a key is suppressed.                                |
| `stage`                | Stage              | The Stage object where the input will be captured.                               |
| `externalInputHandler` | Function           | A callback function for handling external input.                                 |
| `keyHash`              | Array              | A protected array used to track the state of keys.                               |

## Constructor

```actionscript
public function InputDelegate()
```

The constructor initializes the `keyHash` array.

## Methods

### getInstance

```actionscript
public static function getInstance() : InputDelegate
```

Returns the singleton instance of the `InputDelegate`.

### initialize

```actionscript
public function initialize(param1:Stage) : void
```

Initializes the `InputDelegate` with a given `Stage` object and sets up event listeners for key down and key up events.

### setKeyRepeat

```actionscript
public function setKeyRepeat(param1:Number, param2:Boolean, param3:uint = 0) : void
```

Sets or clears the suppression of the repeat event for a particular key.

### inputToNav

```actionscript
public function inputToNav(param1:String, param2:Number, param3:Boolean = false, param4:* = null) : String
```

Converts keyboard input to navigation codes based on the `param1` input type, `param2` key code, `param3` shift key status, and `param4` additional information.

### readInput

```actionscript
public function readInput(param1:String, param2:int, param3:Function) : Object
```

A placeholder for reading inputs. Returns `null`.

### handleKeyDown

```actionscript
protected function handleKeyDown(param1:KeyboardEvent) : void
```

Handles the key down events and processes key presses accordingly.

### handleKeyUp

```actionscript
protected function handleKeyUp(param1:KeyboardEvent) : void
```

Handles the key up events and updates the key state in the `keyHash`.

### handleKeyPress

```actionscript
protected function handleKeyPress(param1:String, param2:Number, param3:Number, param4:Boolean, param5:Boolean, param6:Boolean) : void
```

Processes a key press event and dispatches an `InputEvent` with the relevant input details.

## Example Usage

```actionscript
// Retrieve the InputDelegate instance
var inputDelegate:InputDelegate = InputDelegate.getInstance();

// Initialize the input delegate with a stage reference
inputDelegate.initialize(stage);

// Set up an external input handler function
inputDelegate.externalInputHandler = function(inputType:String, keyCode:Number, additional:*):String {
    // Custom input handling logic here
    return null;
};
```

The `InputDelegate` class is an essential part of handling user input within the Scaleform CLIK framework, enabling smooth and consistent input management across a Scaleform UI application.
