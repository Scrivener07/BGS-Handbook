---
---
# ItemCard_Entry
This documentation explains the `ItemCard_Entry` class found in the `ItemCard_Entry.as` file, which resides within the `Components` package.
This class extends the `MovieClip` class and is responsible for managing individual entries in an item card, including their label, value, and comparison indicators.

## Class Hierarchy

```plaintext
flash.display.MovieClip
└── Components.ItemCard_Entry
```

## Import Statements

```actionscript
import Shared.GlobalFunc;
import flash.display.MovieClip;
import flash.text.TextField;
import scaleform.gfx.Extensions;
import scaleform.gfx.TextFieldEx;
```

## Public Properties

| Property        | Type             | Description                                                                  |
|-----------------|------------------|------------------------------------------------------------------------------|
| `Label_tf`      | `TextField`      | TextField to display the label of an item entry.                             |
| `Value_tf`      | `TextField`      | TextField to display the value of an item entry.                             |
| `Comparison_mc` | `MovieClip`      | MovieClip to display the comparison indicator (e.g., better, worse, best).   |

## Constructor

**ItemCard_Entry()**

Initializes the `ItemCard_Entry` object and sets text auto-sizing for the label and value text fields if they are not null.

```actionscript
public function ItemCard_Entry() {
    super();
    Extensions.enabled = true;

    if(this.Label_tf != null) {
        TextFieldEx.setTextAutoSize(this.Label_tf,TextFieldEx.TEXTAUTOSZ_SHRINK);
    }

    if(this.Value_tf != null) {
        TextFieldEx.setTextAutoSize(this.Value_tf,TextFieldEx.TEXTAUTOSZ_SHRINK);
    }
}
```

## Public Static Methods

### ShouldShowDifference(aInfoObj:Object) : Boolean

Determines if the difference value provided in the `aInfoObj` is significant based on the specified precision and returns a boolean value indicating whether the comparison indicator should be shown.

- **Parameters**: `aInfoObj` - An object containing the difference value and precision.
- **Returns**: Boolean indicating if the comparison indicator should be shown.

## Public Methods

### PopulateEntry(aInfoObj:Object) : *

Populates the item entry with the label and value based on the provided `aInfoObj`, and sets the comparison indicator if necessary.

- **Parameters**: `aInfoObj` - An object containing the text, value, precision, duration, and difference rating for the item entry.
- **Returns**: The method does not return a value.

## Usage Example

```actionscript
var entry:ItemCard_Entry = new ItemCard_Entry();
var info:Object = {
    text: "Damage",
    value: 50,
    precision: 2,
    duration: 1,
    difference: 0.05,
    diffRating: 1  // Represents the "Good" rating
};
entry.PopulateEntry(info);
```

👉 Note: This code excerpt assumes relevant instances of the `TextField` and `MovieClip` classes referred to by `Label_tf`, `Value_tf`, and `Comparison_mc` are part of the `ItemCard_Entry` MovieClip and have been properly initialized.

**Remember**: Always provide the necessary context and instances for the `ItemCard_Entry` class to function correctly within your ActionScript 3.0 environment.
