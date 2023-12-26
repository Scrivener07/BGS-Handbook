# PlatformChangeEvent Documentation

The `PlatformChangeEvent` class is a custom event used to signal a change in the platform input method within a Flash application.
It extends the `flash.events.Event` class.

## File Details

- **Filename:** `PlatformChangeEvent.as`
- **Language:** ActionScript
- **Package:** Shared

## Class Definition

```as3
package Shared {
    import flash.events.Event;

    public class PlatformChangeEvent extends Event {
        // Class code goes here
    }
}
```

## Constants

The `PlatformChangeEvent` class defines several constants representing different platform input methods and an event type.

| Constant                        | Value            | Description                        |
| ------------------------------- | ---------------- | ---------------------------------- |
| `PLATFORM_PC_KB_MOUSE`          | `0`              | Platform is PC with Keyboard/Mouse |
| `PLATFORM_PC_GAMEPAD`           | `1`              | Platform is PC with Gamepad        |
| `PLATFORM_XB1`                  | `2`              | Platform is Xbox One               |
| `PLATFORM_PS4`                  | `3`              | Platform is PlayStation 4          |
| `PLATFORM_MOBILE`               | `4`              | Platform is Mobile                 |
| `PLATFORM_INVALID`              | `uint.MAX_VALUE` | Invalid Platform Indicator         |
| `PLATFORM_CHANGE`               | `"SetPlatform"`  | Event Type for Platform Change     |

## Properties

The `PlatformChangeEvent` class includes private variables and corresponding public getter and setter methods.

### `_uiPlatform`

Holds the unique identifier for the platform. It is initialized with a large unsigned integer value.

### `_bPS3Switch`

A Boolean flag that indicates whether a switch specific to the PlayStation 3 platform occurred.

## Constructor

The constructor initializes the event with provided parameters.

**Syntax:**

```as3
public function PlatformChangeEvent(auiPlatform:uint, abPS3Switch:Boolean)
```

**Parameters:**

- `auiPlatform` (uint): The platform identifier.
- `abPS3Switch` (Boolean): The PS3 switch flag.

**Code Example:**

```as3
public function PlatformChangeEvent(auiPlatform:uint, abPS3Switch:Boolean) {
    super(PLATFORM_CHANGE, true, true);
    this.uiPlatform = auiPlatform;
    this.bPS3Switch = abPS3Switch;
}
```

## Accessors and Mutators

### `uiPlatform`

**Getter:**

```as3
public function get uiPlatform() : * {
    return this._uiPlatform;
}
```

**Setter:**

```as3
public function set uiPlatform(auiPlatform:uint) : * {
    this._uiPlatform = auiPlatform;
}
```

### `bPS3Switch`

**Getter:**

```as3
public function get bPS3Switch() : * {
    return this._bPS3Switch;
}
```

**Setter:**

```as3
public function set bPS3Switch(abPS3Switch:Boolean) : * {
    this._bPS3Switch = abPS3Switch;
}
```

## Example Usage

The following example demonstrates how to dispatch a `PlatformChangeEvent`:

```as3
var platformChangeEvent:PlatformChangeEvent = new PlatformChangeEvent(PlatformChangeEvent.PLATFORM_PS4, false);
dispatchEvent(platformChangeEvent);
```

This dispatches a platform change event indicating that the platform has been set to PlayStation 4 without a PS3 switch.
