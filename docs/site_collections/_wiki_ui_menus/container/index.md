---
title: "ContainerMenu"
categories: fo4 interface menus container
---

The **Container Menu** is used to move items between the *Player* and a *Container*.


## AS3
* `var BGSCodeObj:Object`
* `var ButtonHintBar_mc:BSButtonHintBar`
* `var CapsLabel_tf:TextField`
* `var ContainerInventory_mc:MovieClip`
* `var ContainerList_mc:ItemList`
* `var ItemCard_mc:ItemCard`
* `var PickpocketInfo_mc:MovieClip`
* `var PlayerInventory_mc:MovieClip`
* `var QuantityMenu_mc:MovieClip`
* `var PlayerHasJunk:Boolean`
* `function get containerIsSelected():Boolean`
* `function get selectedIndex():int`
* `function set inspectingFeaturedItem(aValue:Boolean):*`
* `function set playFocusSounds(aValue:Boolean):*`
* `function set playerHasJunk(aValue:Boolean):*`
* `function onIntroAnimComplete():*`
* `function SetContainerInfo(strName:String, auiMode:uint):*`
* `function get playerListArray():Array`
* `function get containerListArray():Array`
* `function set sortButtonLabel(aStr:String):*`
* `function set messageBoxIsActive(aActive:Boolean):*`
* `function InvalidateLists():*`
* `function SwitchToContainerList(aPlaySound:Boolean = true):Boolean`
* `function onQuantityConfirm(event:Event):*`
* `function onAccept():*`
* `function onQuantityAccepted():*`
* `function onTakeAll():*`
* `function onEquipOrStore():*`
* `function onExitMenu():*`
* `function onQuantityCanceled():*`
* `function onInspect():*`
* `function onEndInspect():*`
* `function onKeyUp(event:KeyboardEvent):void`
* `function ProcessUserEvent(strEventName:String, abPressed:Boolean):Boolean`
* `function UpdateEncumbranceAndCaps(aContainer:Boolean, aCurrWeight:uint, aMaxWeight:uint, aCaps:uint, aIncomingCaps:int):*`
* `function UpdatePickpocketInfo(aShow:Boolean, aTaking:Boolean, aSuccessPercent:uint):*`
* `function onQuantityModified(aEvent:Event):*`
* `function onToggleEquip():*`
* `function requestSort():*`


#### BGSCodeObj
* `function PlaySound(name:String):void`
* `function toggleSelectedItemEquipped(index:int, inContainer:Boolean):void`
* `function confirmInvest():void`
* `function inspectItem():void`
* `function getSelectedItemEquipped(index:int, inContainer:Boolean):Boolean`
* `function onIntroAnimComplete():void`
* `function getItemValue(index:int, inContainer:Boolean):*`
* `function getSelectedItemEquippable(index:int, inContainer:Boolean):Boolean`
* `function show3D(index:int, inContainer:Boolean):void`
* `function sendYButton():void`
* `function sendXButton():void`
* `function updateItemPickpocketInfo(index:int, inContainer:Boolean):void`
* `function sortItems(isPlayerInv:Boolean, indexFilter:uint, arg3:Boolean):void`
* `function exitMenu():void`
* `function transferItem(index:int, inContainer:Boolean):void`
* `function takeAllItems():void`
* `function updateSortButtonLabel(isPlayerInv:Boolean, indexFilter:uint):void`


## See Also
- [Container](https://falloutck.uesp.net/wiki/Container)


# ContainerMenu.as Documentation
The `ContainerMenu.as` is an ActionScript file that defines a menu system used for managing items in a container within a game, such as Fallout 4.
This documentation provides an overview of its components and functionalities.

## Components
The `ContainerMenu` class extends the `IMenu` class and contains several components to create the container inventory interface:

| Component | Type | Description |
|-----------|------|-------------|
| `ButtonHintBar_mc` | `BSButtonHintBar` | A bar that displays various button hints for the user. |
| `CapsLabel_tf` | `TextField` | A label displaying the number of caps (currency). |
| `ContainerInventory_mc` | `MovieClip` | The container's inventory display area. |
| `ContainerList_mc` | `ItemList` | The list of items in the container. |
| `ItemCard_mc` | `ItemCard` | A card displaying detailed information about the selected item. |
| `PickpocketInfo_mc` | `MovieClip` | Information display for pickpocketing chances. |
| `PlayerInventory_mc` | `MovieClip` | The player's inventory display area. |
| `QuantityMenu_mc` | `MovieClip` | Menu for selecting the quantity of items to transfer. |
| `PlayerHasJunk` | `Boolean` | Indicates if the player has junk items. |
| `BGSCodeObj` | `Object` | An object containing game-specific code. |

## Buttons and Hints
The menu includes several button hints that prompt the user to perform actions:

| Button | Description |
|--------|-------------|
| `SwitchToPlayerButton` | Switches the view to the player's inventory. |
| `SwitchToContainerButton` | Switches the view to the container's inventory. |
| `AcceptButton` | Confirms a selected action, such as transferring items. |
| `TakeAllButton` | Takes all items from the container. |
| `EquipOrStoreButton` | Equips or stores the selected item. |
| `SortButton` | Sorts the inventory list. |
| `InspectButton` | Inspects the selected item. |
| `ExitButton` | Exits the container menu. |
| `QuantityAcceptButton` | Accepts the selected quantity of items. |
| `QuantityCancelButton` | Cancels the quantity selection. |

## Key Functions
The `ContainerMenu` class has several key functions that handle user interactions and updates to the menu:

- `PopulateButtonBar()`: Sets up the button hint bar with the relevant buttons.
- `SetContainerInfo()`: Sets the name and mode of the container.
- `InvalidateLists()`: Updates the display of item lists.
- `UpdateButtonHints()`: Refreshes the visibility and text of button hints.
- `SwitchToContainerList()`: Changes focus to the container list.
- `SwitchToPlayerList()`: Changes focus to the player list.
- `OpenQuantityMenu()`: Opens the quantity selection menu.
- `CloseQuantityMenu()`: Closes the quantity selection menu.
- `UpdateItemCard()`: Updates the item card with details of the selected item.
- `onItemPress()`: Handles item selection events.
- `onQuantityConfirm()`: Confirms the selected quantity of items.
- `onExitMenu()`: Handles the event to exit the menu.

## Event Listeners
The class listens to various events to handle user input and internal updates:

- Keyboard events to navigate the menu.
- Mouse events to interact with different components.
- Custom events related to item selection and quantity changes.

## Usage
The `ContainerMenu.as` file is typically used within the UI framework of a game, where it manages the interaction between the player and items in a container.
It is responsible for displaying item information, transferring items between the player and the container, and handling user input.

## Conclusion
The `ContainerMenu` class provides a comprehensive system for managing container inventories in a game, with a focus on user interaction and functionality.
It integrates various UI components and handles logic for item transfer, equipping, sorting, and inspecting.
