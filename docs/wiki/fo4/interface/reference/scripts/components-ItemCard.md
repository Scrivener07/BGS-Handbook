# ItemCard.as Documentation

**`ItemCard` Class Overview**

The `ItemCard` class extends `BSUIComponent` to manage and display item information in a user interface.
This class is part of the `Components` package and it is responsible for organizing and rendering item entries based on various types and attributes.

## Properties

| Property | Type | Description |
|----------|------|-------------|
| `_InfoObj` | `Array` | An array of data objects that hold information about the item. |
| `currY` | `Number` | The current Y position for placing new item entries. |
| `_showItemDesc` | `Boolean` | Determines whether the item description should be shown. |
| `ENTRY_SPACING` | `Number` | Constant defining the spacing between entries. |
| `ET_STANDARD` | `uint` | Constant representing a standard entry type. |
| `ET_AMMO` | `uint` | Constant representing an ammunition entry type. |
| `ET_DMG_WEAP` | `uint` | Constant representing a weapon damage entry type. |
| `ET_DMG_ARMO` | `uint` | Constant representing an armor damage entry type. |
| `ET_TIMED_EFFECT` | `uint` | Constant representing a timed effect entry type. |
| `ET_COMPONENTS_LIST` | `uint` | Constant representing a components list entry type. |
| `ET_ITEM_DESCRIPTION` | `uint` | Constant representing an item description entry type. |

## Constructor

The `ItemCard` constructor initializes the properties:

```actionscript
public function ItemCard() {
    super();
    this._InfoObj = new Array();
    this._showItemDesc = true;
    this.currY = 0;
}
```

## Methods

- **Getter and Setter for `InfoObj`**

```actionscript
public function get InfoObj() : Array {
    return this._InfoObj;
}

public function set InfoObj(aNewArray:Array) : * {
    this._InfoObj = aNewArray;
}
```

- **Setter for `showItemDesc`**

```actionscript
public function set showItemDesc(aVal:Boolean) : * {
    this._showItemDesc = aVal;
}
```

- **`onDataChange` Method**

Invokes `SetIsDirty` method to indicate that the data has changed.

```actionscript
public function onDataChange() : * {
    SetIsDirty();
}
```

- **`redrawUIComponent` Method**

Overrides `BSUIComponent` method to redraw the UI components for the item card.

```actionscript
override public function redrawUIComponent() : void {
    // Implementation details omitted for brevity.
}
```

- **`GetEntryType` Private Method**

Determines the entry type based on the object properties.

```actionscript
private function GetEntryType(aEntryObj:Object) : uint {
    // Implementation details omitted for brevity.
}
```

- **`CreateEntry` Private Method**

Creates an `ItemCard_Entry` instance based on the specified entry type.

```actionscript
private function CreateEntry(aEntryType:uint) : ItemCard_Entry {
    // Implementation details omitted for brevity.
}
```

## Entry Types and their Constants

- **Standard Entries**: Represented by `ET_STANDARD`
- **Ammo Entries**: Represented by `ET_AMMO`
- **Weapon Damage Entries**: Represented by `ET_DMG_WEAP`
- **Armor Damage Entries**: Represented by `ET_DMG_ARMO`
- **Timed Effect Entries**: Represented by `ET_TIMED_EFFECT`
- **Components List Entries**: Represented by `ET_COMPONENTS_LIST`
- **Item Description Entries**: Represented by `ET_ITEM_DESCRIPTION`

## Usage

The `ItemCard` class is used by creating an instance and providing it with an array of item data through the `InfoObj` property. Based on the data and the specified types, the class will handle the rendering of each item component on the user interface.

**Example:**

```actionscript
var itemCard:ItemCard = new ItemCard();
itemCard.InfoObj = [/* array of item data */];
itemCard.showItemDesc = true; // Show the description
itemCard.redrawUIComponent(); // Redraw the UI
```

This documentation provides a high-level understanding of the `ItemCard` class functionalities and usage within the user interface system. It is a critical piece for anyone looking to modify or extend the UI components for item information display.
