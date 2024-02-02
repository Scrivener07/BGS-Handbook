---
---
# ResizeEvent
The `ResizeEvent` class, defined within the `scaleform.clik.events` package, is an extension of the `flash.events.Event` class.
It is specifically crafted for handling resize-related events within the Scaleform CLIK (Common Lightweight Interface Kit) framework.

This class provides additional properties to capture the scale factors along the X and Y axes.

## Filename

`ResizeEvent.as`

## Package

```markdown
scaleform.clik.events
```

## Imports

```actionscript
import flash.events.Event;
```

## Class Definition

```actionscript
public class ResizeEvent extends Event
```

## Constants

| Constant                     | Value                | Description                                     |
| ---------------------------- | -------------------- | ----------------------------------------------- |
| **`RESIZE`**                 | `"resize"`           | Event type for a generic resize event.          |
| **`SCOPE_ORIGINALS_UPDATE`** | `"scopeOriginalsUpdate"` | Event type for scope originals update event. |

## Properties

- **`scaleX`**: `Number` (default: `1`) - Represents the scale factor along the X axis after the resize event occurs.

- **`scaleY`**: `Number` (default: `1`) - Represents the scale factor along the Y axis after the resize event occurs.

## Constructor

The `ResizeEvent` constructor initializes a new `ResizeEvent` instance.

```actionscript
public function ResizeEvent(param1:String, param2:Number, param3:Number)
```

**Parameters:**

- `param1`: `String` - The type of the event.
- `param2`: `Number` - The scale factor along the X axis.
- `param3`: `Number` - The scale factor along the Y axis.

## Methods

### override `toString`

Provides a string representation of the `ResizeEvent` instance.

```actionscript
override public function toString() : String
```

**Returns:**

- `String`: The string representation of the event.

### override `clone`

Creates a clone of the `ResizeEvent` instance.

```actionscript
override public function clone() : Event
```

**Returns:**

- `Event`: A new `ResizeEvent` instance with the same properties as the original.

## Example Usage

```actionscript
var resizeEvent:ResizeEvent = new ResizeEvent(ResizeEvent.RESIZE, 2, 2);
trace(resizeEvent.toString()); // output: [ResizeEvent type="resize" scaleX=2 scaleY=2]
```

---
**Note:**
This documentation assumes familiarity with the Scaleform CLIK framework and the ActionScript 3.0 programming language.
