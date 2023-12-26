# MessageBoxButtonEntry Documentation

The `MessageBoxButtonEntry` class is an ActionScript file that extends the functionality of `BSScrollingListEntry` typically used in a modding context for Bethesda Game Studios titles.
Below, you will find comprehensive documentation about the `MessageBoxButtonEntry` class, structured in a way to provide clear understanding and usage of the provided code.

## Table of Contents 📑

- [Class Overview](#class-overview)
- [Constructors](#constructors)
- [Public Methods](#public-methods)
- [Override Methods](#override-methods)

---

## Class Overview

**Filename:** `MessageBoxButtonEntry.as`

The `MessageBoxButtonEntry` class is designed to represent an individual entry in a scrollable list, specifically acting as a button within a message box. It extends from the `BSScrollingListEntry` class.

```actionscript
package {
    import Shared.AS3.BSScrollingList;
    import Shared.AS3.BSScrollingListEntry;

    public class MessageBoxButtonEntry extends BSScrollingListEntry {
        // ... Class contents ...
    }
}
```

## Constructors

- **MessageBoxButtonEntry**
  The constructor method for creating a new `MessageBoxButtonEntry` instance.

**Example:**

```actionscript
public function MessageBoxButtonEntry() {
    super();
}
```

## Public Methods

### CalculateBorderWidth

Calculates the border width of the button based on the text field's width.

**Return:** `Number` - The calculated width of the border around the text field.

**Example:**

```actionscript
public function CalculateBorderWidth() : Number {
    return textField.getLineMetrics(0).width + 30;
}
```

### SetBorderWidth

Sets the border width and adjusts the border position relative to the text field.

**Parameters:**

- `param1:Number` - The new width for the border.

**Usage:**

```actionscript
public function SetBorderWidth(param1:Number) : * {
    border.width = param1;
    border.x = textField.getLineMetrics(0).x - (border.width - textField.getLineMetrics(0).width) / 2 + 2.5;
}
```

## Override Methods

### SetEntryText

Overrides the `SetEntryText` method to ensure the text is displayed in a multi-line format within the list.

**Parameters:**

- `param1:Object` - The object containing the data to be displayed.
- `param2:String` - The string identifier for the text option, defaulted to `BSScrollingList.TEXT_OPTION_MULTILINE`.

**Usage:**

```actionscript
override public function SetEntryText(param1:Object, param2:String) : * {
    super.SetEntryText(param1,BSScrollingList.TEXT_OPTION_MULTILINE);
}
```

---

**Note:** The `MessageBoxButtonEntry` class is used extensively for UI customization in certain games, and understanding its API can be crucial for mod developers looking to enhance user interfaces or create new UI elements.
