---
title: "MenuItemList"
categories: fo4 interface menus terminal
---

The `MenuItemList` class extends the `BSScrollingList` from the package `Shared.AS3`.
It provides additional functionality to manage and animate text within menu items in a scrollable list format.

## Class Definition

```actionscript
package {
    import Shared.AS3.BSScrollingList;
    import flash.display.MovieClip;
    import flash.geom.Point;
    import flash.geom.Rectangle;
    import flash.text.TextField;

    public class MenuItemList extends BSScrollingList {
        public function MenuItemList() {
            super();
        }

        // ... Additional methods ...
    }
}
```

## Public Methods

### MenuItemList()

The constructor of the `MenuItemList` class. It calls the constructor of the superclass `BSScrollingList`.

**Syntax:**

```actionscript
public function MenuItemList()
```

### ConvertToGlobal(param1:TextField): Point

Converts the position of the last character in a `TextField` to a global position.

**Parameters:**

- `param1`: The `TextField` from which to calculate the global position.

**Returns:**

- A `Point` object representing the global position of the last character in the provided `TextField`.

**Syntax:**

```actionscript
public function ConvertToGlobal(param1:TextField): Point
```

### AnimateText(param1:Boolean, param2:MovieClip, param3:uint): Boolean

Animates text within the menu items. It can either reveal the text by slicing or display the full text instantly.

**Parameters:**

- `param1`: A `Boolean` indicating whether to display full text instantly (`true`) or to animate the text by slicing characters (`false`).
- `param2`: The `MovieClip` to which the position of the animated text will be set.
- `param3`: A `uint` value indicating the number of characters to slice per animation frame when `param1` is `false`.

**Returns:**

- A `Boolean` indicating whether the animation has finished.

**Syntax:**

```actionscript
public function AnimateText(param1:Boolean, param2:MovieClip, param3:uint): Boolean
```

## Usage Example

Below is a usage example of how `MenuItemList` methods can be utilized:

```actionscript
var menuItemList:MenuItemList = new MenuItemList();

// Assume we have a TextField instance and MovieClip instance
var someTextField:TextField;
var someMovieClip:MovieClip;

// Convert the position of the last character to a global position
var globalPoint:Point = menuItemList.ConvertToGlobal(someTextField);

// Start text animation in the menu items
var animationFinished:Boolean = menuItemList.AnimateText(false, someMovieClip, 1);

if (animationFinished) {
    // Animation has finished, proceed with additional logic
}
```

## 📌 Important Notes

- The `AnimateText` method relies on the internal state of `EntriesA`, which is likely an array inherited from `BSScrollingList` representing the list entries.
- The `AnimateText` method updates the state of each entry in `EntriesA` and may modify the `x` and `y` properties of `param2` (`MovieClip`) to match the global position of the current animated text.
- `iListItemsShown` is likely a property inherited from `BSScrollingList` which defines how many list items are displayed at once.
- The `GetClipByIndex` method is used to retrieve a specific `MovieClip` associated with a list entry, implying that each entry has a corresponding `MovieClip` representing its visual component.
- `disableInput` is set based on the state of the animation and list contents, suggesting an interaction mechanism with the list items.

## 📖 Best Practices

- Ensure that `EntriesA` is correctly initialized and populated before calling `AnimateText`.
- Handle the `animationFinished` state appropriately after calling `AnimateText` to synchronize any dependent logic with the animation state.
- Be mindful of the visual and interactive states of the list items when manipulating `disableInput`.
