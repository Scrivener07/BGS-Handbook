---
title: "ItemList"
---

The `ItemList.as` file is an ActionScript file that defines a custom scrolling list class called `ItemList`.
This list is designed to be used within a user interface where elements in the list can be selected, and different behaviors such as a transfer arrow visibility are managed upon selection.

Below is the detailed documentation for the `ItemList` class:


## Class Definition

```as3
package {
    import Shared.AS3.BSScrollingList;
    import flash.display.MovieClip;
    import flash.events.Event;
    import flash.events.MouseEvent;

    public class ItemList extends BSScrollingList {
        ...
    }
}
```

The `ItemList` class extends the `BSScrollingList` class, which provides basic scrolling list functionality.


## Constants

| Constant | Type | Description |
| -------- | ---- | ----------- |
| **`MOUSE_OVER`** | `String` | A static const representing the mouse over event name for the `ItemList`. |


## Properties

| Property | Type | Description |
| -------- | ---- | ----------- |
| **`TransferArrow_mc`** | `MovieClip` | A `MovieClip` object representing the transfer arrow displayed when an item is selected. |
| **`ScrollUp_mc`** | `MovieClip` | A `MovieClip` object representing the scroll up button. |
| **`ScrollDown_mc`** | `MovieClip` | A `MovieClip` object representing the scroll down button. |


## Constructor

```as3
public function ItemList() {
    super();
    if(this.TransferArrow_mc != null) {
        this.TransferArrow_mc.visible = false;
    }
    addEventListener(MouseEvent.MOUSE_OVER, this.onMouseOver);
    addEventListener(BSScrollingList.SELECTION_CHANGE, this.onSelectionChange);
}
```

The constructor initializes the `ItemList` by hiding the `TransferArrow_mc` if it exists and adding event listeners for mouse over and selection change events.


## Event Handlers

### onSelectionChange
```as3
private function onSelectionChange(event:Event) : * {
    if(this.TransferArrow_mc != null) {
        if(this.selectedIndex == -1) {
            this.TransferArrow_mc.visible = false;
        } else {
            this.TransferArrow_mc.y = GetClipByIndex(this.selectedEntry.clipIndex).y;
            this.TransferArrow_mc.visible = true;
        }
    }
}
```

This method controls the visibility and position of the `TransferArrow_mc` based on the selection state of the list.

### onMouseOver
```as3
private function onMouseOver(event:MouseEvent) : * {
    dispatchEvent(new Event(MOUSE_OVER, true, true));
}
```

When a mouse over event is detected, the `onMouseOver` handler dispatches a custom `MOUSE_OVER` event.

## Usage Example
In a user interface where an `ItemList` instance has been added, the list will handle user interactions to visually indicate selected items with the transfer arrow and provide responsiveness to mouse events.

## Conclusion
The `ItemList` class is a customized scrolling list suitable for user interfaces where list selections are visually indicated.
It extends the functionality of the `BSScrollingList` by adding specific behavior for item selection and mouse over events.
