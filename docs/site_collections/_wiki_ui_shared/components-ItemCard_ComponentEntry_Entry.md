---
---
# ItemCard_ComponentEntry_Entry
The `ItemCard_ComponentEntry_Entry` class is an ActionScript file designated to handle the visual representation of a list entry within a scrollable list component.
It extends the functionality of `BSScrollingListEntry` to accommodate the specific needs of Item Cards in a user interface.

Below is the detailed markdown documentation for this class.

## Class Overview

```actionscript
package Components {
    import Shared.AS3.BSScrollingListEntry;
    import flash.display.MovieClip;

    public class ItemCard_ComponentEntry_Entry extends BSScrollingListEntry {
        public var FavIcon_mc:MovieClip;

        public function ItemCard_ComponentEntry_Entry() {
            super();
        }

        override public function SetEntryText(aEntryObject:Object, astrTextOption:String) : * {
            super.SetEntryText(aEntryObject,astrTextOption);

            if(aEntryObject.count != 1 && aEntryObject.count != undefined) {
                textField.appendText(" (" + aEntryObject.count + ")");
            }

            var rightTextX:Number = textField.x + textField.width / 2 + textField.textWidth / 2 + 15;

            if(this.FavIcon_mc != null) {
                this.FavIcon_mc.x = rightTextX;
                this.FavIcon_mc.visible = aEntryObject.favorite > 0 || aEntryObject.taggedForSearch;
            }
        }
    }
}
```

## File Details

- **Filename**: `ItemCard_ComponentEntry_Entry.as`
- **Package**: `Components`

## Class Description

- **Class Name**: `ItemCard_ComponentEntry_Entry`
- **Extended Class**: `BSScrollingListEntry`

### Properties

| Property Name | Type         | Description                       |
|---------------|--------------|-----------------------------------|
| `FavIcon_mc`  | `MovieClip`  | Holds the favorite icon movie clip. |

### Constructor

**Constructor Name**: `ItemCard_ComponentEntry_Entry`

**Description**: Initializes the entry with default properties by calling the super class (`BSScrollingListEntry`) constructor.

### Methods

#### `SetEntryText`

**Description**: Overrides the `SetEntryText` method from `BSScrollingListEntry` to customize the text displayed for an item entry.

**Parameters**:

| Parameter Name   | Type     | Description                            |
|------------------|----------|----------------------------------------|
| `aEntryObject`   | `Object` | The object containing entry data.      |
| `astrTextOption` | `String` | String option for text customization.  |

**Return Type**: `*` (Any type, based on the super method's return type)

**Logic Description**:
1. Calls the super method `SetEntryText` with the provided parameters.
2. If the entry object's count is not equal to `1` and is defined, appends the count in parentheses to the `textField`'s text.
3. Calculates the horizontal position `rightTextX` for the favorite icon based on the `textField` properties.
4. If the `FavIcon_mc` is not null, it positions the icon at `rightTextX` and adjusts its visibility based on whether the entry object is marked as a favorite or tagged for search.

### Usage Instructions

🔸 To use the `ItemCard_ComponentEntry_Entry` class, create an instance of it, and call the `SetEntryText` method with the appropriate data object and text option.

🔸 Ensure that graphical assets like the `FavIcon_mc` are properly linked for visibility manipulations to work as expected.

## Notes

- It is implied that `textField`, a property inherited from `BSScrollingListEntry`, is a text field used to display the entry's text.
- The favorite icon's visibility toggling supports indicating an entry as a favorite or as being tagged for search functionality within a list.

---

📌 **This is auto-generated documentation for the `ItemCard_ComponentEntry_Entry` class. Ensure you review the code and understand its functionality before integration.**
