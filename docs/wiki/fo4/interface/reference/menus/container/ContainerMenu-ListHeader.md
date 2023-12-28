# ListHeader.as Documentation

The `ListHeader.as` file defines the `ListHeader` class which extends the `MovieClip` class from the Adobe Flash library.
It's primarily used for managing the header section of lists which include the title text and accompanying left and right navigation arrows.

## Class Definition

```actionscript
package {
    import Shared.GlobalFunc;
    import flash.display.MovieClip;
    import flash.text.TextField;
    import flash.text.TextLineMetrics;
    import scaleform.gfx.Extensions;
    import scaleform.gfx.TextFieldEx;

    public class ListHeader extends MovieClip {
        public var textField:TextField;
        public var LeftArrow:MovieClip;
        public var RightArrow:MovieClip;

        public function ListHeader() {
            super();
            Extensions.enabled = true;
            TextFieldEx.setTextAutoSize(this.textField, "shrink");
        }

        public function get headerText() : String {
            return this.textField.text;
        }

        public function get headerWidth() : * {
            return this.RightArrow.x + this.RightArrow.width;
        }

        public function set headerText(strText:String) : void {
            var metrics:TextLineMetrics = null;
            if (this.textField && strText) {
                GlobalFunc.SetText(this.textField,strText,false);
                metrics = this.textField.getLineMetrics(0);
                this.RightArrow.x = this.textField.x + metrics.width + 10;
            }
        }

        public function SetArrowVisibility(abVisible:Boolean) : * {
            this.LeftArrow.visible = abVisible;
            this.RightArrow.visible = abVisible;
        }
    }
}
```

## Class Members

### Public Variables

| Variable     | Type         | Description                  |
| ------------ | ------------ | ---------------------------- |
| `textField`  | TextField    | The text field for the header text. |
| `LeftArrow`  | MovieClip    | The left navigational arrow movie clip. |
| `RightArrow` | MovieClip    | The right navigational arrow movie clip. |

### Constructor

- **ListHeader()**
  Initializes a new instance of the `ListHeader` class. It enables the Scaleform extensions and sets the text auto-sizing to "shrink" for the text field.

### Public Functions

- **headerText**: String (_getter_)
  Returns the current text of the header's text field.

- **headerWidth**: * (_getter_)
  Returns the calculated width of the header based on the position and width of the `RightArrow`.

- **set headerText(strText: String)**: void (_setter_)
  Sets the text of the header's text field and adjusts the `RightArrow`'s position based on the text width.

  _**Arguments**_:

  | Argument | Type   | Description              |
  | -------- | ------ | ------------------------ |
  | `strText`| String | The text to set.         |

- **SetArrowVisibility(abVisible: Boolean)**: *
  Sets the visibility of both `LeftArrow` and `RightArrow` based on the provided boolean value.

  _**Arguments**_:

  | Argument   | Type    | Description                         |
  | ---------- | ------- | ----------------------------------- |
  | `abVisible`| Boolean | `true` to show arrows, `false` to hide. |

## Usage Example

```actionscript
// Create an instance of ListHeader
var header:ListHeader = new ListHeader();

// Set the header text
header.headerText = "Main Menu";

// Adjust arrow visibility
header.SetArrowVisibility(true);
```

This example demonstrates how to create an instance of the `ListHeader` class, set the header text, and adjust the visibility of the navigation arrows.

## Additional Notes ✏️

- The class utilizes Scaleform extensions, which are specific to Adobe Flash and may not be available or necessary in other environments.
- The `get` and `set` functions for `headerText` enable the encapsulation of the text field's content.

**💡 Tip**: Always ensure that the `textField` is properly initialized before setting text or calculating widths to avoid runtime errors.
