---
title: "EntryHolder"
---

`EntryHolder.as` is an ActionScript file defining a dynamic class named `EntryHolder` which extends the `MovieClip` class from the Flash API.
This class is designed to manage multiple `FavoritesEntry` objects, providing specific settings for each one.

## Class Details

### **EntryHolder**

The `EntryHolder` class contains multiple instances of `FavoritesEntry`, each uniquely identified by a property name (`Entry_0` through `Entry_11`).

#### Properties

Each `FavoritesEntry` property within the `EntryHolder` class is listed below:

| Property Name | Type            | Description                          |
|---------------|-----------------|--------------------------------------|
| `Entry_0`     | `FavoritesEntry`| The first favorites entry.           |
| `Entry_1`     | `FavoritesEntry`| The second favorites entry.          |
| ...           | ...             | ...                                  |
| `Entry_9`     | `FavoritesEntry`| The tenth favorites entry.           |
| `Entry_10`    | `FavoritesEntry`| The eleventh favorites entry.        |
| `Entry_11`    | `FavoritesEntry`| The twelfth favorites entry.         |

#### Constructor

The constructor initializes each `FavoritesEntry` with specific component properties:

```actionscript
public function EntryHolder() {
    super();
    // Initialization for each entry
    this.__setProp_Entry_0_EntryHolder_Layer1_0();
    // Additional initializations...
}
```

#### Initialization Methods

Each `FavoritesEntry` is configured using its respective initialization method, such as:

```actionscript
function __setProp_Entry_0_EntryHolder_Layer1_0() : * {
    try {
        this.Entry_0["componentInspectorSetting"] = true;
    } catch(e:Error) {
    }
    // Configuration settings for Entry_0
    // ...
    try {
        this.Entry_0["componentInspectorSetting"] = false; return;
    } catch(e:Error) {
        return;
    }
}
```

### **FavoritesEntry Properties**

Each `FavoritesEntry` includes the following properties:

| Property Name             | Type    | Description                                                 |
|---------------------------|---------|-------------------------------------------------------------|
| `bracketCornerLength`     | `Number`| The length of the bracket corners.                          |
| `bracketLineWidth`        | `Number`| The width of the bracket line.                              |
| `bracketPaddingX`         | `Number`| The horizontal padding for the bracket.                     |
| `bracketPaddingY`         | `Number`| The vertical padding for the bracket.                       |
| `BracketStyle`            | `String`| The style of the bracket (e.g., "horizontal").              |
| `bShowBrackets`           | `Boolean`| Whether or not to display brackets.                         |
| `bUseShadedBackground`    | `Boolean`| Whether or not to use a shaded background.                  |
| `ShadedBackgroundMethod`  | `String`| The method used for shading the background (e.g., "Shader").|
| `ShadedBackgroundType`    | `String`| The type of shaded background (e.g., "normal").             |

Each `FavoritesEntry` object is configured with similar settings in their respective initialization methods.

## Example Usage

```actionscript
// Create an instance of EntryHolder
var holder:EntryHolder = new EntryHolder();

// Access and interact with a specific FavoritesEntry
var entry:FavoritesEntry = holder.Entry_1;
entry.doSomething(); // Replace with actual method calls
```

### Notes
- The actual implementation details for `FavoritesEntry` and how it interacts with `EntryHolder` are not provided in the given code.
- The code uses try-catch blocks to safely attempt property settings which suggests there may be cases where `componentInspectorSetting` is not available on the `FavoritesEntry` instance.
