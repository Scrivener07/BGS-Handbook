---
title: "ItemListEntry"
---

The `ItemListEntry` class extends `BSScrollingListEntry` to provide functionality for displaying item entries with various icons and text manipulation based on the item's properties.
It is part of the package that can be found in the file `ItemListEntry.as`.

## Class Definition

```actionscript
package {
    import Shared.AS3.BSScrollingListEntry;
    import Shared.GlobalFunc;
    import flash.display.MovieClip;
    import flash.geom.ColorTransform;

    public class ItemListEntry extends BSScrollingListEntry {
        // ... class members ...
    }
}
```

## Class Members

### Public Variables

| Variable Name              | Type        | Description                                                              |
|----------------------------|-------------|--------------------------------------------------------------------------|
| `LeftIcon_mc`              | `MovieClip` | MovieClip instance for the left icon.                                    |
| `FavoriteIcon_mc`          | `MovieClip` | MovieClip instance for the favorite icon.                                |
| `LegendaryIcon_mc`         | `MovieClip` | MovieClip instance for the legendary icon.                               |
| `TaggedForSearchIcon_mc`   | `MovieClip` | MovieClip instance for the icon indicating the item is tagged for search.|

### Private Variables

| Variable Name              | Type        | Description                                                              |
|----------------------------|-------------|--------------------------------------------------------------------------|
| `BaseTextFieldWidth`       | `*`         | Stores the original width of the text field.                             |

### Constructor

**ItemListEntry()**
```actionscript
public function ItemListEntry() {
    super();
    this.BaseTextFieldWidth = textField.width;
}
```

Initializes the `ItemListEntry` by calling the superclass constructor and storing the width of the text field.

### Methods

#### SetEntryText
Overrides the `SetEntryText` method from the parent class to customize the text and icons based on item properties.

**SetEntryText(aEntryObject:Object, astrTextOption:String) : ***
```actionscript
override public function SetEntryText(aEntryObject:Object, astrTextOption:String) : * {
    // ... implementation details ...
}
```

##### Parameters:
- `aEntryObject`: The object containing the item's data.
- `astrTextOption`: A string that determines the text display option.

##### Behavior:
- Toggles visibility of icons based on item properties (tagged for search, favorite, isLegendary).
- Adjusts text field width to accommodate the visible icons.
- Sets the item count and barter count display.
- Alters the color transform for different icons based on selection state.

#### Example Usage:
```actionscript
var itemListEntry:ItemListEntry = new ItemListEntry();
var itemData:Object = {
    taggedForSearch: true,
    favorite: 2,
    isLegendary: false,
    // ... other properties ...
};
itemListEntry.SetEntryText(itemData, "default");
```

## 🖥️ User Interface Behavior

- The `ItemListEntry` class manages the visual representation of an item within a list, such as in an inventory screen.
- It supports displaying various status icons next to the item's name (e.g., favorite, legendary, tagged for search).
- The color of icons may change to indicate selection status.

## 🔧 Development Notes

The `ItemListEntry` class is tightly coupled with the graphical assets within the Flash MovieClip symbols.
It assumes that certain MovieClip instances and properties are present, such as `LeftIcon_mc`, `FavoriteIcon_mc`, etc.

## 🗒️ Additional Information

🚀 This class is designed for use within an ActionScript 3.0 project and may be part of a game's user interface codebase, such as that of a Bethesda game using the Scaleform framework for UI design.

🛠️ The manipulation of `ColorTransform` properties allows for dynamic visual feedback based on the item’s selection state.

📌 It is important to note that changes to the class may require corresponding changes to the associated .fla assets for the MovieClips.
