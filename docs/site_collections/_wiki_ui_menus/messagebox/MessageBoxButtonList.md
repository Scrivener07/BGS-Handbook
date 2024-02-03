---
title: "MessageBoxButtonList"
categories: fo4 interface menus messagebox
---

The `MessageBoxButtonList` class is an extension of the `BSScrollingList` class, which is designed to handle a list of message box button entries with dynamic border widths based on the content.

Filename: `MessageBoxButtonList.as`

## Class Declaration

```actionscript
package {
    import Shared.AS3.BSScrollingList;

    public class MessageBoxButtonList extends BSScrollingList {
        // Constructor and methods follow...
    }
}
```

## Constructor

**MessageBoxButtonList**

Initializes a new instance of the `MessageBoxButtonList` class.

```actionscript
public function MessageBoxButtonList() {
    super();
}
```

## Methods

### `InvalidateData`

Overrides the parent class's `InvalidateData` method to refresh the list and adjust entry border widths as necessary.

```actionscript
override public function InvalidateData() : * {
    super.InvalidateData();
    this.SetEntryBorderWidths();
}
```

### `SetEntryBorderWidths`

A private method that calculates and sets the border width for each entry in the list based on the widest entry.

```actionscript
private function SetEntryBorderWidths() : * {
    var _loc4_:MessageBoxButtonEntry = null;
    var _loc5_:Number = NaN;
    var _loc6_:MessageBoxButtonEntry = null;
    var _loc1_:Number = 0;
    var _loc2_:uint = 0;

    // Determine the maximum border width required by any entry
    while(_loc2_ < uiNumListItems) {
        _loc4_ = GetClipByIndex(_loc2_) as MessageBoxButtonEntry;
        if(_loc4_ && _loc4_.textField) {
            _loc5_ = _loc4_.CalculateBorderWidth();
            if(_loc5_ > _loc1_) {
                _loc1_ = _loc5_;
            }
        }
        _loc2_++;
    }

    // Set the calculated border width for all entries
    var _loc3_:uint = 0;
    while(_loc3_ < uiNumListItems) {
        _loc6_ = GetClipByIndex(_loc3_) as MessageBoxButtonEntry;
        if(_loc6_) {
            _loc6_.SetBorderWidth(_loc1_);
        }
        _loc3_++;
    }
}
```

### `updateScrollPosition`

Overrides the `updateScrollPosition` method from the base class to maintain border widths when the scrolling position is updated.

```actionscript
override protected function updateScrollPosition(param1:uint) : * {
    super.updateScrollPosition(param1);
    this.SetEntryBorderWidths();
}
```

## Properties
The `MessageBoxButtonList` class inherits all properties from its base class, `BSScrollingList`, but does not introduce new properties of its own.

## Remarks

📌 The `SetEntryBorderWidths` method is responsible for ensuring that all entries in the `MessageBoxButtonList` have consistent border widths.

📌 It is worth noting that the implementation details of `GetClipByIndex`, `CalculateBorderWidth`, and `SetBorderWidth` are not provided in the provided code snippet and are assumed to be part of the `MessageBoxButtonEntry` class or the parent `BSScrollingList`.

📌 This class is likely part of a user interface system for a game where actionscript is employed for UI component creation and manipulation.

### Table of Methods

| **Method** | **Visibility** | **Description** |
| ---------- | -------------- | --------------- |
| `MessageBoxButtonList` | Public | Constructor initializing the class instance. |
| `InvalidateData` | Public (Override) | Refreshes the list and adjusts entry border widths. |
| `SetEntryBorderWidths` | Private | Calculates the optimal border width for all list entries. |
| `updateScrollPosition` | Protected (Override) | Updates the scroll position and maintains border widths. |

**Note**: The `*` return type in the ActionScript language represents an untyped reference, which means that the method can return any type of value or object.
