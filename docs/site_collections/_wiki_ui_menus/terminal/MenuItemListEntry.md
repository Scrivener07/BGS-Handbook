---
title: "MenuItemListEntry"
categories: fo4 interface menus terminal
---

`MenuItemListEntry.as` is an ActionScript file that defines a dynamic class which extends the `BSScrollingListEntry` class.
This class is used to create menu item entries for a scrolling list in a user interface, likely within a game or an application that uses Scaleform for UI components.

## Class Definition

📝 **Filename**: `MenuItemListEntry.as`

Below is the outlined structure of the `MenuItemListEntry` class:

```actionscript
package {
    import Shared.AS3.BSScrollingListEntry;

    public dynamic class MenuItemListEntry extends BSScrollingListEntry {
        public function MenuItemListEntry() {
            super();
        }
    }
}
```

## Constructor

| Constructor | Description |
|-------------|-------------|
| `public function MenuItemListEntry()` | The constructor function for the `MenuItemListEntry` class. It calls the constructor of the parent class `BSScrollingListEntry` using `super()`. |

## Inheritance

**Base Class**: `BSScrollingListEntry`

The `MenuItemListEntry` class inherits from `BSScrollingListEntry`, which means it acquires all public and protected properties and methods from the `BSScrollingListEntry` class.

### Dynamic Class

`MenuItemListEntry` is a **dynamic class**, which allows instances of the class to have variables and methods added to them at runtime.

## Usage

To use the `MenuItemListEntry` class, you would typically instantiate it within a user interface that utilizes a scrolling list to represent a collection of options or menu items.
The `MenuItemListEntry` would be responsible for representing a single entry within that list.

## Example

Below is an example of how the `MenuItemListEntry` might be utilized:

```actionscript
// Create a new instance of MenuItemListEntry
var menuItem:MenuItemListEntry = new MenuItemListEntry();

// Assuming the existence of a function to add the entry to a scrolling list
addEntryToList(menuItem);
```

## Conclusion

The `MenuItemListEntry` is a straightforward extension of the `BSScrollingListEntry` class, designed to represent individual entries in a scrolling list without adding additional functionality beyond the base class.
This class could be further customized to include more specific behavior or properties for menu entries as per the requirements of the user interface it's intended for.
