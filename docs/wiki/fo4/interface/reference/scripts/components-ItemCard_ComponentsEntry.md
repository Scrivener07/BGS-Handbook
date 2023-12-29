# ItemCard_ComponentsEntry
Below is the documentation for the `ItemCard_ComponentsEntry` class located in the file `ItemCard_ComponentsEntry.as` within the `Components` package.

## Package Structure

```plaintext
Components
└── ItemCard_ComponentsEntry.as
```

## Class Definition

The `ItemCard_ComponentsEntry` class is an extension of the `ItemCard_Entry` class. It is responsible for populating itself with component entries.

```as3
package Components {
    ...
    public class ItemCard_ComponentsEntry extends ItemCard_Entry {
        ...
    }
}
```

## Properties

| **Property**      | **Type**     | **Description**                          | **Scope** |
|-------------------|--------------|------------------------------------------|-----------|
| `EntryHolder_mc`  | `MovieClip`  | MovieClip container for entry elements. | `public`  |
| `currY`           | `Number`     | Current Y position for the next entry.   | `private` |
| `ENTRY_SPACING`   | `Number`     | Spacing between entries.                 | `private` |

## Constants

- `ENTRY_SPACING`: Represents the spacing between individual component entries. It is a constant value set to `0`.

## Constructor

The constructor initializes the `ItemCard_ComponentsEntry`:

```as3
public function ItemCard_ComponentsEntry() {
    super();
    this.currY = 0;
}
```

## Methods

### `PopulateEntry`

Given an object containing components, this method populates the `EntryHolder_mc` with `ItemCard_ComponentEntry_Entry` instances.

**Parameters:**
- `aInfoObj`: An object that includes the `components` array to be displayed.

```as3
override public function PopulateEntry(aInfoObj:Object) : * {
    ...
}
```

**Process:**
1. Clears any existing children in `EntryHolder_mc`.
2. Loops through each component in the `components` array of `aInfoObj`.
3. Creates a new `ItemCard_ComponentEntry_Entry`, sets its text, and adds it to `EntryHolder_mc`.
4. Adjusts the Y position (`currY`) for the next entry.

**Code Block:**

```as3
var component:Object = null;
var newEntry:ItemCard_ComponentEntry_Entry = null;

while(this.EntryHolder_mc.numChildren > 0) {
    this.EntryHolder_mc.removeChildAt(0);
}

this.currY = 0;

for each(component in aInfoObj.components) {
    newEntry = new ItemCard_ComponentEntry_Entry();
    newEntry.SetEntryText(component,BSScrollingList.TEXT_OPTION_SHRINK_TO_FIT);
    this.EntryHolder_mc.addChild(newEntry);
    newEntry.y = this.currY;
    this.currY = this.currY + (newEntry.height + this.ENTRY_SPACING);
}
```

### Usage Example

To create an `ItemCard_ComponentsEntry` and populate it with components:

```as3
var componentsEntry:ItemCard_ComponentsEntry = new ItemCard_ComponentsEntry();
var info:Object = { components: [ /* array of components */ ] };
componentsEntry.PopulateEntry(info);
```

## 🌟 Highlights

- Extends `ItemCard_Entry` for specific functionality regarding item components.
- **Dynamically adds** component entries based on input data.
- Utilizes **zero spacing** between entries for a compact layout.
- **Clears existing entries** before repopulating to ensure fresh information.
