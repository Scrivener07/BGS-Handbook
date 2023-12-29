---
title: "FavoritesMenu"
---

`FavoritesMenu.as` is an ActionScript 3.0 file that defines the `FavoritesMenu` class, which extends the `IMenu` class from the Shared library.
This class is responsible for managing the user interface and interactions within a favorites menu system.

The *Favorites Menu* is where hot keyed items may be accessed quickly during game play.


## Class
Below is the detailed documentation for the `FavoritesMenu` class, including its properties, methods, and event handlers.


### BGSCodeObj
* `closeMenu : Function()`
* `PlaySound : Function()`
* `useQuickkey : Function()`


### Properties

| Property | Type | Description |
|----------|------|-------------|
| **Cross_mc** | `FavoritesCross` | MovieClip representing the cross-structure of favorites. |
| **ItemName_tf** | `TextField` | TextField to display the name of the selected item. |
| **ItemAmmo_tf** | `TextField` | TextField to display the ammo count of the selected item. |
| **BGSCodeObj** | `Object` | An object to interface with the game's code. |


### Constructor

```actionscript
public function FavoritesMenu() {
    super();
    Extensions.enabled = true;
    this.BGSCodeObj = new Object();
    this.Cross_mc.addEventListener(FavoritesCross.SELECTION_UPDATE, this.onSelectionChange);
    this.Cross_mc.addEventListener(FavoritesEntry.CLICK, this.onFavEntryClick);
    this.Cross_mc.addEventListener(FavoritesCross.ITEM_PRESS, this.onFavEntryClick);
    TextFieldEx.setTextAutoSize(this.ItemName_tf, TextFieldEx.TEXTAUTOSZ_SHRINK);
    TextFieldEx.setTextAutoSize(this.ItemAmmo_tf, TextFieldEx.TEXTAUTOSZ_SHRINK);
}
```


### Methods

| Method | Return Type | Description |
|--------|-------------|-------------|
| **onStageInit** | `*` | Initializes the stage and sets focus to `Cross_mc`. |
| **onSetSafeRect** | `void` | Locks the menu to the safe area on the screen. |
| **set selectedIndex** | `*` | Setter for the selected index in `Cross_mc`. |
| **set favInfoArray** | `*` | Setter for the `infoArray` in `Cross_mc`. |
| **ProcessUserEvent** | `Boolean` | Handles user input events passed to the favorites menu. |


### Event Handlers

| Handler | Event | Description |
|---------|-------|-------------|
| **onSelectionChange** | `Event` | Updates the item name and ammo text fields when selection changes. |
| **onFavEntryClick** | `CustomEvent` | Triggers an action when a favorite entry is clicked or pressed. |


## Usage Example

```actionscript
var favoritesMenu:FavoritesMenu = new FavoritesMenu();

// Set the selectedIndex to an unsigned integer value
favoritesMenu.selectedIndex = 0;

// Set the favInfoArray to an array of favorite items information
favoritesMenu.favInfoArray = [...];

// Handling user events
var isProcessed:Boolean = favoritesMenu.ProcessUserEvent("Cancel", false);
```

## Events
💠 **FavoritesCross.SELECTION_UPDATE**: Dispatched when the selection updates in the favorites cross.
💠 **FavoritesEntry.CLICK**: Dispatched when a favorites entry is clicked.
💠 **FavoritesCross.ITEM_PRESS**: Dispatched when a favorites entry is pressed.


## Notes
- **LockToSafeRect**: This method is used to ensure that the UI elements stay within the safe area of the screen, which is particularly important on different display screens and resolutions.
- **SetTextAutoSize**: This feature is used to automatically resize the text if the content exceeds the bounds of the TextField.
