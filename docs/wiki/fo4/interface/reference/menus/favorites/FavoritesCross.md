---
title: "FavoritesCross"
---

`FavoritesCross.as` is an ActionScript class that extends the `BSUIComponent` from the `Shared.AS3` package. It is responsible for managing a user interface component that likely deals with a selection system, probably for a favorite items list in a game or application. The component handles selection updates, item presses, and keyboard navigation.

## Table of Contents
- [Constants](#constants)
- [Public Properties](#public-properties)
- [Constructor](#constructor)
- [Public Methods](#public-methods)
- [Private Methods](#private-methods)
- [Event Handlers](#event-handlers)

## Constants
The class defines a set of constants that are used to represent different selection states and events:

| Constant             | Description                             |
| -------------------- | --------------------------------------- |
| `SELECTION_UPDATE`   | Event string for selection updates.     |
| `ITEM_PRESS`         | Event string for item presses.          |
| `FS_*`               | Constants representing directional keys and a none state. |

## Public Properties

- `EntryHolder_mc` (MovieClip): A movie clip that holds entries.
- `Selection_mc` (MovieClip): A movie clip that shows the current selection.
- `_HideEmptySlots` (Boolean): A flag indicating whether to hide empty slots.

## Constructor
The `FavoritesCross` constructor initializes the component and sets up event listeners for keyboard and mouse events.

```actionscript
public function FavoritesCross() {
    // Constructor code...
}
```

## Public Methods

- `CanAcceptAimlessClicking()`: Determines if the component can accept aimless clicking.
- `infoArray`: Setter method to update the favorites information array.
- `selectedIndex`: Getter and setter methods for the selected index.
- `selectedEntry`: Getter for the selected entry object.
- `hideEmptySlots`: Getter and setter for the _HideEmptySlots property.
- `selectionSound`: Getter for the selection sound, depending on the selected index.
- `GetEntryClip(index: uint)`: Retrieves the `FavoritesEntry` clip based on an index.
- `redrawUIComponent()`: Redraws the UI component and updates its state.
- `ProcessUserEvent(eventName: String, isDown: Boolean)`: Processes user input events.
- `SelectItem()`: Dispatches an item press event when an item is selected.

## Private Methods

- `ShouldHideSlot(index: uint)`: Determines whether a slot should be hidden.
- `ClampSelection(index: uint)`: Clamps the selection index within valid bounds, considering whether empty slots are hidden.

## Event Handlers

- `onKeyUp(event: KeyboardEvent)`: Handles keyboard up events to navigate through items.
- `onFavEntryMouseover(event: Event)`: Handles mouse-over events on favorite entries.
- `onFavEntryMouseleave(event: Event)`: Handles mouse-leave events on favorite entries.

## Code Example

Here is an example of how the selectedIndex is handled in this class:

```actionscript
public function set selectedIndex(param1:uint): * {
    var _loc3_:int = 0;
    var _loc2_:int = this.ClampSelection(param1);
    if (this._SelectedIndex != _loc2_) {
        _loc3_ = this._SelectedIndex;
        this._SelectedIndex = _loc2_;
        dispatchEvent(new CustomEvent(SELECTION_UPDATE, _loc3_, true, true));
        SetIsDirty();
    }
}
```

This snippet shows how the class handles the update of the selected index. It clamps the incoming value to ensure it is within valid bounds, then checks if the value has changed from the previous state. If there is a change, it dispatches a `SELECTION_UPDATE` event and marks the UI component as dirty, indicating that it needs to be redrawn.

📁 **File name:** FavoritesCross.as

💡 **Note:** This documentation is based on the provided code snippet. Some assumptions were made about the functionality due to the incomplete context.
