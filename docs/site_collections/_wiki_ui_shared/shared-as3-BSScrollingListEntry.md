# BSScrollingListEntry
The `BSScrollingListEntry` class extends the `MovieClip` class and is used to create entries for a scrolling list within a user interface.
It manages the text display and selection state of each entry, as well as dynamic height adjustments based on the content.

Below is a detailed documentation of the `BSScrollingListEntry` class contained in the `Shared.AS3` package.

---

## Class Definition

```actionscript
package Shared.AS3 {
    import Shared.GlobalFunc;
    import flash.display.MovieClip;
    import flash.text.TextField;
    import flash.text.TextFieldAutoSize;
    import scaleform.gfx.Extensions;
    import scaleform.gfx.TextFieldEx;

    public class BSScrollingListEntry extends MovieClip {
        public var border:MovieClip;
        public var textField:TextField;
        protected var _clipIndex:uint;
        protected var _itemIndex:uint;
        protected var _selected:Boolean;
        public var ORIG_BORDER_HEIGHT:Number;
        protected var _HasDynamicHeight:Boolean;

        public function BSScrollingListEntry() {
            super();
            Extensions.enabled = true;
            this.ORIG_BORDER_HEIGHT = this.border != null ? Number(this.border.height) : Number(0);
            this._HasDynamicHeight = true;
        }

        // ... Getters and setters for protected members ...

        public function SetEntryText(aEntryObject:Object, astrTextOption:String) : * {
            // ... Method implementation ...
        }
    }
}
```

---

## Properties

| Property              | Type           | Description                                                                                      |
|-----------------------|----------------|--------------------------------------------------------------------------------------------------|
| **border**            | MovieClip      | The visual border element of the list entry.                                                      |
| **textField**         | TextField      | The text field where the list entry's text is displayed.                                          |
| **ORIG_BORDER_HEIGHT**| Number         | The original height of the entry's border, used for resetting height on dynamic height changes.   |
| **_clipIndex**        | uint           | The index of the movie clip (internal use).                                                       |
| **_itemIndex**        | uint           | The index of the item in the list (internal use).                                                 |
| **_selected**         | Boolean        | Indicates whether the list entry is currently selected.                                           |
| **_HasDynamicHeight** | Boolean        | Indicates whether the list entry has dynamic height enabled.                                      |

---

## Methods

### Constructor

The constructor initializes the list entry and sets up its properties.

```actionscript
public function BSScrollingListEntry()
```

### SetEntryText

Sets the text of the list entry and handles the formatting based on the text options provided.

```actionscript
public function SetEntryText(aEntryObject:Object, astrTextOption:String): *
```

#### Parameters
- `aEntryObject`: The object containing the text to be set.
- `astrTextOption`: A string specifying the text formatting option to use.

---

## Getters and Setters

### clipIndex
- **Getter:** `public function get clipIndex() : uint`
- **Setter:** `public function set clipIndex(newIndex:uint) : *`

### itemIndex
- **Getter:** `public function get itemIndex() : uint`
- **Setter:** `public function set itemIndex(newIndex:uint) : *`

### selected
- **Getter:** `public function get selected() : Boolean`
- **Setter:** `public function set selected(flag:Boolean) : *`

### hasDynamicHeight
- **Getter:** `public function get hasDynamicHeight() : Boolean`

### defaultHeight
- **Getter:** `public function get defaultHeight() : Number`

---

## Usage Example

This class is typically used within the context of a scrolling list UI component. An instance of `BSScrollingListEntry` is created for each list element, and its text and selection state are managed as the user interacts with the list.

---

📝 **Note:** The above documentation assumes familiarity with ActionScript 3 and the Scaleform framework used for game UI development.
