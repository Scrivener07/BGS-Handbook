---
title: "SWFLoaderMenu"
---

The `SWFLoaderMenu` class extends `IMenu` and is responsible for the dynamic loading and unloading of SWF files.
It manages a map of loaded content and provides methods to load/unload SWF files, retrieve menu names, and handle loading events.


## Public Variables

| Variable Name | Type   | Description                             |
|---------------|--------|-----------------------------------------|
| `BGSCodeObj`  | Object | Object to interact with BGS code.       |
| `LoadedSWFMap`| Object | Map holding references to loaded SWFs.  |

---

## Constructor
The constructor initializes the `BGSCodeObj` and `LoadedSWFMap` objects.

```actionscript
public function SWFLoaderMenu() {
    super();
    this.BGSCodeObj = new Object();
    this.LoadedSWFMap = new Object();
}
```


## Methods

### SWFLoad

Loads a SWF file given a path.

```actionscript
public function SWFLoad(param1:String) : * {
    // Implementation...
}
```

- **param1**: The path to the SWF file to be loaded.
- Checks if the SWF is already loaded. If not, initiates a new load operation.

### GetMenuNameFromURL

Extracts menu name from the SWF file URL.

```actionscript
protected function GetMenuNameFromURL(param1:String) : String {
    // Implementation...
}
```

- **param1**: The URL of the SWF file.
- Returns the name of the menu.

### onMenuLoadComplete

Event handler for successful SWF load operation.

```actionscript
public function onMenuLoadComplete(param1:Event) : * {
    // Implementation...
}
```

- **param1**: The `Event` object associated with the completion of the SWF load.
- Processes the loaded content and updates the map.

### SWFUnload

Unloads a SWF file given an identifier.

```actionscript
public function SWFUnload(param1:String) : * {
    // Implementation...
}
```

- **param1**: The name of the SWF file to be unloaded.
- Handles the removal of event listeners and unloading of the SWF content.

### onMenuLoadAbandoned

Event handler for abandoned SWF load operations.

```actionscript
public function onMenuLoadAbandoned(param1:Event) : * {
    // Implementation...
}
```

- **param1**: The `Event` object associated with the abandoned SWF load.
- Cleans up after an abandoned load operation.

### GetTimelineObj

Retrieves the timeline object for a given SWF name if loaded and not a `Loader`.

```actionscript
public function GetTimelineObj(param1:String) : Object {
    // Implementation...
}
```

- **param1**: The name of the SWF file.
- Returns the timeline object or `null` if not available.


## Usage Examples

```actionscript
// Create instance of the SWFLoaderMenu
var menuLoader:SWFLoaderMenu = new SWFLoaderMenu();

// Load a SWF file by providing the path to the SWFLoaderMenu instance
menuLoader.SWFLoad("path/to/your/swf");

// Unload a SWF file by providing the name to the SWFLoaderMenu instance
menuLoader.SWFUnload("yourSWFName");
```


## Additional Information

- **Filename**: `SWFLoaderMenu.as`
- **Language**: ActionScript
- **Dependencies**: Requires the `Shared.IMenu` class and `flash.display.Loader` among other Flash classes for loading content.


## Conventions Used

- **Bold**: Relevant text and method names are bolded for emphasis.
- **Lists**: Used for organizing variables and methods.
- **Tables**: Utilized to structure information about variables and methods for clarity.
- **Code Blocks**: Deployed to present code snippets and method signatures.
- **Emojis**: Not included as they are not typically part of technical documentation for code.

🚀 Enjoy managing your SWF content with `SWFLoaderMenu`!
