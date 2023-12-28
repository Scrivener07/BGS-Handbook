# BSScrollingList.as Documentation

The `BSScrollingList` class is an ActionScript 3 class that manages a scrolling list component in a Flash-based user interface.
It extends the `MovieClip` class and provides functionality for item selection, scrolling, and event handling.

This class is part of the Shared.AS3 package and is typically used for game interfaces that require scrollable lists.

Below is the documentation for `BSScrollingList.as` with details on its properties, methods, and usage.

## Properties

| Property | Type | Description |
|----------|------|-------------|
| `scrollList` | `MobileScrollList` | The mobile scrolling list used when CompanionApp mode is on. |
| `border` | `MovieClip` | A clip that defines the extents of the border around the scrolling list. |
| `ScrollUp` | `MovieClip` | A clip for the scroll-up button. |
| `ScrollDown` | `MovieClip` | A clip for the scroll-down button. |
| `EntriesA` | `Array` | An array containing the list entries. |
| `EntryHolder_mc` | `MovieClip` | A movie clip that holds all the list entry clips. |
| `iSelectedIndex` | `int` | The index of the currently selected item. |
| `iSelectedClipIndex` | `int` | The clip index of the currently selected item. |
| `bRestoreListIndex` | `Boolean` | Whether to restore the list index upon updating data. |
| `ListEntryClass` | `Class` | The class used for creating new list entry instances. |
| `strTextOption` | `String` | The option for text formatting within list entries. |
| `bDisableSelection` | `Boolean` | Whether item selection within the list is disabled. |
| `bAllowWheelScrollNoSelectionChange` | `Boolean` | Allows mouse wheel scrolling without changing the current selection. |
| `bDisableInput` | `Boolean` | If true, input to the list is disabled. |
| `bMouseDrivenNav` | `Boolean` | Whether navigation through the list is driven by the mouse. |
| `_filterer` | `ListFilterer` | An object that filters the list entries based on a set of criteria. |
| `bReverseList` | `Boolean` | Whether to reverse the order of the list. |
| `bInitialized` | `Boolean` | Indicates if the list has been initialized. |
| `bUpdated` | `Boolean` | Indicates if the list has been updated. |

## Methods

```as3
public function BSScrollingList()
```
Constructor for the `BSScrollingList` class, which sets up default values, event listeners, and initializes necessary components.

```as3
public function ClearList(): *
```
Clears all entries from the list.

```as3
public function InvalidateData(): *
```
Invalidates the list data, triggering a refresh based on the current entries and filter settings.

```as3
public function UpdateList(): *
```
Updates the visual representation of the list, including the visibility and positioning of entries.

```as3
public function moveSelectionUp(): *
```
Moves the current selection up in the list.

```as3
public function moveSelectionDown(): *
```
Moves the current selection down in the list.

## Events

- `SELECTION_CHANGE`: Dispatched when the selected item in the list changes.
- `ITEM_PRESS`: Dispatched when an item in the list is pressed.
- `LIST_PRESS`: Dispatched when a list (but not a specific item) is pressed.
- `LIST_ITEMS_CREATED`: Dispatched when the list items are created.
- `PLAY_FOCUS_SOUND`: Dispatched when a focus sound should be played.

## Usage

To use the `BSScrollingList`, instantiate it and add it to the display list:

```as3
var myList:BSScrollingList = new BSScrollingList();
addChild(myList);
```

Set up the list with the required number of items, entry class, and ensure it is populated with data:

```as3
myList.ListEntryClass = MyCustomListEntryClass;
myList.entryList = myDataArray;
myList.InvalidateData();
```

To react to selection changes, listen to the `SELECTION_CHANGE` event:

```as3
myList.addEventListener(BSScrollingList.SELECTION_CHANGE, onSelectionChange);

function onSelectionChange(event:Event): void {
    // Handle selection change
}
```

## Considerations

- This class assumes a Flash environment with user interaction via mouse or keyboard.
- It is tailored to work with Bethesda Softworks' Companion App mode, which suggests it was used in games like Fallout 4 and Skyrim for their in-game Pip-Boy apps or similar interfaces.
- Since this is a game UI component, it will likely involve graphical assets that align with the theme and style of the game interface.
- The actual rendering and behavior of list items will depend on the implementation of the `BSScrollingListEntry` class or its subclasses.
