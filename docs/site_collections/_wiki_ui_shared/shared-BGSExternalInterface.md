---
---
# BGSExternalInterface
The `BGSExternalInterface.as` file contains the `BGSExternalInterface` class within the `Shared` package.
This class is designed to provide an interface to call functions on a given object dynamically.

It's a critical class for ensuring UI components can interact with game-specific logic, especially in Bethesda Game Studios titles using Scaleform.

Below is the detailed documentation of its usage and functionality.

`BGSExternalInterface` is a utility class in the `Shared` package.
It's designed to facilitate communication between ActionScript and the game engine's code, typically represented as `BGSCodeObj`.

Used to call functions on the `BGSCodeObj`, which represents an interface to the game engine.

`BGSExternalInterface` doesn't directly interact with visual elements but acts as a bridge for communication between UI elements and the game's backend logic.


#### Example
```as3
// Call a function on the BGSCodeObj
BGSExternalInterface.call(gameCodeObj, "functionName", param1, param2);
```


## Table of Contents

- [Class Overview](#class-overview)
- [Constructor](#constructor)
- [Public Methods](#public-methods)
- [Usage Example](#usage-example)
- [Error Handling](#error-handling)

## Class Overview

**Package**: `Shared`
**Filename**: `BGSExternalInterface.as`
**Class**: `BGSExternalInterface`

The primary objective of the `BGSExternalInterface` class is to allow for dynamic function calls on objects that are structured to handle such invocations.

### Constructor

The class constructor is a simple initialization that inherits from its superclass.

```actionscript
public function BGSExternalInterface() {
    super();
}
```

## Public Methods

| Method | Description | Parameters | Return Type |
| ------ | ----------- | ---------- | ----------- |
| `call` | Calls a function on the passed `BGSCodeObj` object dynamically using the function name provided in the arguments. | `BGSCodeObj:Object`, `...args` | `void` |

### call Method

The `call` method performs a dynamic function call on an object passed as `BGSCodeObj`, where the function name to be called is the first element within the `args` array.

The first argument in `args` is assumed to be the function name, and the rest are parameters to that function.


**Signature**:

```actionscript
public static function call(BGSCodeObj:Object, ... args) : void {
```

**Usage**:

- `BGSCodeObj`: The object containing the function to be called.
- `args`: An array where the first element is the string name of the function to be called, followed by any arguments for that function.

## Usage Example

Below is an example of how to use the `BGSExternalInterface` class to call a function named "updateScore" on an object with the corresponding method.

```actionscript
var gameController:Object = new GameController();
BGSExternalInterface.call(gameController, "updateScore", 500);
```

## Error Handling

The `call` method includes traces to output errors to the console if the function or the `BGSCodeObj` is `null`. If the function name does not exist on `BGSCodeObj`, or if `BGSCodeObj` itself is `null`, the call will not proceed.

**Function doesn't exist**:

```plaintext
BGSExternalInterface::call -- Can't call function 'FUNCTION_NAME' on BGSCodeObj. This function doesn't exist!
```

**BGSCodeObj is null**:

```plaintext
BGSExternalInterface::call -- Can't call function 'FUNCTION_NAME' on BGSCodeObj. BGSCodeObj is null!
```

**Note**: Replace 'FUNCTION_NAME' with the actual function name when interpreting error messages.

---

The `BGSExternalInterface` provides a flexible way to interface with objects that must respond to dynamic function calls.
Proper error handling and usage practices should be employed to ensure that function calls are executed correctly.
