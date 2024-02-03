---
---
# SWFLoaderClip
This documentation provides an overview of the `SWFLoaderClip` class, its methods, properties, and usage within a Flash application.
The class is part of the `Components` package and is designed to load and handle SWF files.

The `SWFLoaderClip` class extends `MovieClip` and allows for the loading and unloading of SWF files as display objects.
It provides functionality to set the alpha (transparency) and scale of the loaded SWF as well as an alternative menu loading mechanism in case of an IO error.

### Properties

| Property       | Type             | Description                                      |
|----------------|------------------|--------------------------------------------------|
| `SWF`          | `DisplayObject`  | The currently loaded SWF display object.         |
| `menuLoader`   | `Loader`         | The loader responsible for loading SWF files.    |
| `ClipAlpha`    | `Number`         | The alpha (transparency) of the loaded SWF clip. |
| `ClipScale`    | `Number`         | The scale of the loaded SWF clip.                |
| `AltMenuName`  | `String`         | An alternative SWF file to load upon an IO error.|

### Methods

#### `SWFLoaderClip()`
Constructor method for the `SWFLoaderClip` class. It initializes the properties and sets up the loader.

```as3
public function SWFLoaderClip()
```

#### `set clipAlpha(param1:Number)`
Setter method for `ClipAlpha`. It sets the alpha (transparency) of the loaded SWF clip.

```as3
public function set clipAlpha(param1:Number) : *
```

#### `set clipScale(param1:Number)`
Setter method for `ClipScale`. It sets the scale of the loaded SWF clip.

```as3
public function set clipScale(param1:Number) : *
```

#### `SWFLoad(param1:String)`
Loads an SWF file based on the provided URL string.

```as3
public function SWFLoad(param1:String) : void
```

#### `SWFLoadAlt(param1:String, param2:String)`
Attempts to load an SWF file and sets an alternative file to load in case of an IO error.

```as3
public function SWFLoadAlt(param1:String, param2:String) : *
```

#### `onMenuLoadComplete(param1:Event)`
Callback method invoked upon successful loading of an SWF file. It sets the scale and alpha of the loaded SWF clip and adds it as a child.

```as3
public function onMenuLoadComplete(param1:Event) : void
```

#### `SWFUnload(param1:DisplayObject)`
Unloads the currently loaded SWF display object from the display list and unloads the content from memory.

```as3
public function SWFUnload(param1:DisplayObject) : void
```

#### `_ioErrorEventHandler(param1:IOErrorEvent)`
Private method invoked upon an IO error. It attempts to load an alternative SWF file if available or traces an error message.

```as3
private function _ioErrorEventHandler(param1:IOErrorEvent) : *
```

### Events

- `Event.COMPLETE`: Dispatched when the SWF file has been loaded successfully.
- `IOErrorEvent.IO_ERROR`: Dispatched when there is an IO error during the loading of the SWF file.

### Example Usage

```as3
var swfClip:SWFLoaderClip = new SWFLoaderClip();
swfClip.SWFLoad("path/to/your/file");
```

---

💡 **Note**: This class requires the Flash Player API and is intended for use in ActionScript 3.0. It is essential to handle potential IO errors gracefully, as shown in the `_ioErrorEventHandler` method.

**Filename**: `SWFLoaderClip.as`
**Package**: `Components`

**Bold**: Important terms and method names are highlighted in **bold** for quick reference.

**Emojis**: Emojis like 💡 are used to draw attention to specific notes and tips.
