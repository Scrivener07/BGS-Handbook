# BSScrollingListFadeEntry Documentation

The `BSScrollingListFadeEntry` class extends the `BSScrollingListEntry` class to provide functionality for a scrolling list entry with fade effect on its border based on focus and selection.

## Table of Contents
- [Class Overview](#class-overview)
- [Constructor](#constructor)
- [Functionality](#functionality)
- [Properties](#properties)

## Class Overview

**Filename:** `BSScrollingListFadeEntry.as`

```actionscript
package Shared.AS3 {
    public class BSScrollingListFadeEntry extends BSScrollingListEntry {
        // ...
    }
}
```

## Constructor

The constructor calls the parent's constructor to initialize the scrolling list entry.

```actionscript
public function BSScrollingListFadeEntry() {
    super();
}
```

## Functionality

### SetEntryText

Overrides the `SetEntryText` method from the `BSScrollingListEntry` class to include fading effects on the border based on the focus state of the entry.

**Parameters:**
- `param1:Object`: Data object containing the text to be displayed.
- `param2:String`: The text format to be used.

```actionscript
override public function SetEntryText(param1:Object, param2:String) : * {
    super.SetEntryText(param1, param2);

    // Determine if the current stage focus is on this entry or its parent.
    var _loc3_:* = stage.focus == this.parent;
    if (!_loc3_ && this.parent != null) {
        _loc3_ = stage.focus == this.parent.parent;
    }

    // Set the border alpha value based on the focus and selection state.
    if (!_loc3_ && this.selected) {
        border.alpha = this.fUnselectedBorderAlpha;
    }
}
```

## Properties

### fUnselectedBorderAlpha

A constant representing the alpha transparency of the border when an entry is selected but not focused.

| Property                 | Type    | Description                                      |
|--------------------------|---------|--------------------------------------------------|
| **fUnselectedBorderAlpha** | Number | The alpha value for the unselected border (0.5). |

## Example Usage

The `BSScrollingListFadeEntry` class could be used in a game's user interface to display a list of items with a visual indication (fading effect) when an item is selected but not currently focused. This visual feedback can improve user experience by clearly indicating which item is selected without the need for direct focus.

```actionscript
var fadeEntry:BSScrollingListFadeEntry = new BSScrollingListFadeEntry();
fadeEntry.SetEntryText({text: "Item Name"}, "default");
```

This is part of the Shared.AS3 package and would typically be used in ActionScript 3 projects within a larger application, such as a game interface built with a Flash-based framework like Scaleform.
