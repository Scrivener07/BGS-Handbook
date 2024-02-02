# ItemCard_DescriptionEntry
This is the markdown documentation for the ActionScript class `ItemCard_DescriptionEntry`, which is contained in the file `ItemCard_DescriptionEntry.as`.
The `ItemCard_DescriptionEntry` class is part of the `Components` package and extends the `ItemCard_Entry` class.

`ItemCard_DescriptionEntry` is designed to handle the display of text within an entry that is part of an item card.
This class includes properties for the background movie clip and overrides a method to populate the entry with data.

### Class Definition

```actionscript
package Components {
    import flash.display.MovieClip;
    import flash.text.TextFieldAutoSize;
    import scaleform.gfx.TextFieldEx;

    public class ItemCard_DescriptionEntry extends ItemCard_Entry {
        public var Background_mc:MovieClip;

        public function ItemCard_DescriptionEntry() {
            super();
            TextFieldEx.setTextAutoSize(Label_tf, TextFieldEx.TEXTAUTOSZ_NONE);
            Label_tf.autoSize = TextFieldAutoSize.LEFT;
            Label_tf.multiline = true;
            Label_tf.wordWrap = true;
        }

        override public function PopulateEntry(aInfoObj:Object) : * {
            super.PopulateEntry(aInfoObj);
            this.Background_mc.height = Label_tf.textHeight + 5;
        }
    }
}
```

## Properties

- **Background_mc**: This public variable is a `MovieClip` that represents the visual background associated with the description entry text field.

## Constructor

The `ItemCard_DescriptionEntry` constructor initializes the text field properties.

### Constructor Details

| Method | Description |
| ------ | ----------- |
| `ItemCard_DescriptionEntry` | Sets up the text field for the description entry with no auto-size, left alignment, multiline, and word wrapping. |

## Methods

- **PopulateEntry**: Overrides the `PopulateEntry` method from the `ItemCard_Entry` class to adjust the background height based on the text content.

### Method Details

| Method | Description |
| ------ | ----------- |
| `PopulateEntry(aInfoObj:Object)` | Sets the height of `Background_mc` dynamically based on the height of the text in `Label_tf`. Adds an extra 5 units to the calculated height. |

## Usage

To use the `ItemCard_DescriptionEntry` class, create an instance of it and then call its methods to populate it with specific data.

```actionscript
var descriptionEntry:ItemCard_DescriptionEntry = new ItemCard_DescriptionEntry();
var infoObj:Object = { /* data to populate */ };
descriptionEntry.PopulateEntry(infoObj);
```

## 📦 File Details

- **Filename**: ItemCard_DescriptionEntry.as
- **Location**: Inside the `Components` package

## 📝 Additional Notes

- The class extends `ItemCard_Entry`, which likely provides additional functionality and properties related to item card entries.
- The text field's auto-size and word wrap features are configured to better display multiline descriptions.
- The background's dynamic height adjustment ensures the visual element matches the content size.

Remember to include all the necessary imports when utilizing this class in your ActionScript project.
