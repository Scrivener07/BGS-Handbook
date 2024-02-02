---
---
# DisplayObjectEx
The `DisplayObjectEx` class resides within the `scaleform.gfx` package and extends the functionality of the `flash.display.DisplayObject` class, providing static methods for advanced rendering controls.

It extends functionalities of Flash's `DisplayObject` class, providing additional methods specifically tailored for the game's rendering needs.
This class does not instantiate objects but offers static methods that manipulate existing `DisplayObject` instances.

It includes methods for enabling or disabling batching, setting renderer-specific parameters, and querying these settings.

## Table of Content

- [Constructor](#constructor)
- [Methods](#methods)
  - [disableBatching](#disablebatching)
  - [isBatchingDisabled](#isbatchingdisabled)
  - [setRendererString](#setrendererstring)
  - [getRendererString](#getrendererstring)
  - [setRendererFloat](#setrendererfloat)
  - [getRendererFloat](#getrendererfloat)

## Constructor

| Constructor | Description |
| ----------- | ----------- |
| `DisplayObjectEx()` | Initializes a new instance of the DisplayObjectEx class. |

## Methods

### disableBatching

Disables or enables the batching of rendering commands for the specified `DisplayObject`.

```actionscript
public static function disableBatching(o:DisplayObject, b:Boolean) : void
```

**Parameters**

- `o`: The `DisplayObject` to affect.
- `b`: A `Boolean` value where `true` disables batching and `false` enables it.

### isBatchingDisabled

Checks if the batching of rendering commands is disabled for the specified `DisplayObject`.

```actionscript
public static function isBatchingDisabled(o:DisplayObject) : Boolean
```

**Parameters**

- `o`: The `DisplayObject` to check.

**Returns**

- `Boolean`: `true` if batching is disabled, `false` otherwise.

### setRendererString

Assigns a string to the renderer for the specified `DisplayObject`.

```actionscript
public static function setRendererString(o:DisplayObject, s:String) : void
```

**Parameters**

- `o`: The `DisplayObject` to set the string for.
- `s`: The string to assign to the renderer.

### getRendererString

Retrieves the renderer string for the specified `DisplayObject`.

```actionscript
public static function getRendererString(o:DisplayObject) : String
```

**Parameters**

- `o`: The `DisplayObject` to retrieve the string from.

**Returns**

- `String`: The renderer string or `null` if none is set.

### setRendererFloat

Assigns a floating-point number to the renderer for the specified `DisplayObject`.

```actionscript
public static function setRendererFloat(o:DisplayObject, f:Number) : void
```

**Parameters**

- `o`: The `DisplayObject` to set the float for.
- `f`: The floating-point number to assign to the renderer.

### getRendererFloat

Retrieves the renderer floating-point number for the specified `DisplayObject`.

```actionscript
public static function getRendererFloat(o:DisplayObject) : Number
```

**Parameters**

- `o`: The `DisplayObject` to retrieve the float from.

**Returns**

- `Number`: The renderer float or `Number.NaN` if none is set.

## Filename

```
DisplayObjectEx.as
```

## Utilization Examples

To disable batching for a `DisplayObject` instance:

```actionscript
DisplayObjectEx.disableBatching(myDisplayObject, true);
```

To check if batching is disabled:

```actionscript
var batchingDisabled:Boolean = DisplayObjectEx.isBatchingDisabled(myDisplayObject);
```

To set a renderer string:

```actionscript
DisplayObjectEx.setRendererString(myDisplayObject, "exampleRenderer");
```

To get a renderer string:

```actionscript
var rendererString:String = DisplayObjectEx.getRendererString(myDisplayObject);
```

To set a renderer float:

```actionscript
DisplayObjectEx.setRendererFloat(myDisplayObject, 1.23);
```

To get a renderer float:

```actionscript
var rendererFloat:Number = DisplayObjectEx.getRendererFloat(myDisplayObject);
```
