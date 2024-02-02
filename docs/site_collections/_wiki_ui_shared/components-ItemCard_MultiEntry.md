---
---
# ItemCard_MultiEntry

The `ItemCard_MultiEntry.as` file is part of the Components package and contains the `ItemCard_MultiEntry` class, which extends `ItemCard_Entry`. This class manages multiple entries for an item card, such as displaying damage or armor ratings for various conditions. Below is a detailed markdown documentation of the `ItemCard_MultiEntry` class.

## Class: ItemCard_MultiEntry

The `ItemCard_MultiEntry` class is responsible for populating and managing the display of multiple properties of an entry within an item card.

### Properties

| Property Name     | Type          | Description                                       |
|-------------------|---------------|---------------------------------------------------|
| DMG_WEAP_ID       | String (const)| Identifier for weapon damage.                     |
| DMG_ARMO_ID       | String (const)| Identifier for armor damage resistance.           |
| EntryHolder_mc    | MovieClip     | MovieClip to hold individual entry elements.      |
| Background_mc     | MovieClip     | MovieClip for the background of all entries.      |
| currY             | Number        | Tracks the current Y position for entry placement.|
| ENTRY_SPACING     | Number (const)| The spacing between individual entries.           |

### Constructor: ItemCard_MultiEntry()

The constructor initializes the class instance and sets the starting Y position for entries.

```as
public function ItemCard_MultiEntry() {
    super();
    this.currY = 0;
}
```

### Methods

#### IsEntryValid(aEntryObj:Object): Boolean

Static method that checks if an entry is valid based on its value and type.

```as
public static function IsEntryValid(aEntryObj:Object) : Boolean {
    return aEntryObj.value > 0 || ShouldShowDifference(aEntryObj) && aEntryObj.text == DMG_ARMO_ID;
}
```

#### PopulateMultiEntry(aInfoObj:Array, aPropName:String): *

Populates the `EntryHolder_mc` with multiple entry values based on the provided information object array.

```as
public function PopulateMultiEntry(aInfoObj:Array, aPropName:String) : * {
    // ... method implementation ...
}
```

### Example Usage

To use the `ItemCard_MultiEntry` class, you would create an instance of it and call the `PopulateMultiEntry` method with the appropriate arguments.

```as
var itemCardMultiEntry:ItemCard_MultiEntry = new ItemCard_MultiEntry();
itemCardMultiEntry.PopulateMultiEntry(infoArray, "propertyName");
```

### 📝 Note

- `DMG_WEAP_ID` and `DMG_ARMO_ID` are the identifiers for weapon and armor properties respectively.
- `currY` starts at 0 and is manipulated within `PopulateMultiEntry` to properly layout the entries.
- `ENTRY_SPACING` is a constant value for the spacing between entries.

🔍 **Search Tags:** ItemCard, MultiEntry, Component, AS3, Flash, UI Component
