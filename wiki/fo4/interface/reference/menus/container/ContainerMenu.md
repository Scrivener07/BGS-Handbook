The '''Container Menu''' is used to move items between the [[Player]] and a [[Container]].

== AS3 ==
* <code>var BGSCodeObj:Object</code>
* <code>var ButtonHintBar_mc:BSButtonHintBar</code>
* <code>var CapsLabel_tf:TextField</code>
* <code>var ContainerInventory_mc:MovieClip</code>
* <code>var ContainerList_mc:ItemList</code>
* <code>var ItemCard_mc:ItemCard</code>
* <code>var PickpocketInfo_mc:MovieClip</code>
* <code>var PlayerInventory_mc:MovieClip</code>
* <code>var QuantityMenu_mc:MovieClip</code>
* <code>var PlayerHasJunk:Boolean</code>
* <code>function get containerIsSelected():Boolean</code>
* <code>function get selectedIndex():int</code>
* <code>function set inspectingFeaturedItem(aValue:Boolean):*</code>
* <code>function set playFocusSounds(aValue:Boolean):*</code>
* <code>function set playerHasJunk(aValue:Boolean):*</code>
* <code>function onIntroAnimComplete():*</code>
* <code>function SetContainerInfo(strName:String, auiMode:uint):*</code>
* <code>function get playerListArray():Array</code>
* <code>function get containerListArray():Array</code>
* <code>function set sortButtonLabel(aStr:String):*</code>
* <code>function set messageBoxIsActive(aActive:Boolean):*</code>
* <code>function InvalidateLists():*</code>
* <code>function SwitchToContainerList(aPlaySound:Boolean = true):Boolean</code>
* <code>function onQuantityConfirm(event:Event):*</code>
* <code>function onAccept():*</code>
* <code>function onQuantityAccepted():*</code>
* <code>function onTakeAll():*</code>
* <code>function onEquipOrStore():*</code>
* <code>function onExitMenu():*</code>
* <code>function onQuantityCanceled():*</code>
* <code>function onInspect():*</code>
* <code>function onEndInspect():*</code>
* <code>function onKeyUp(event:KeyboardEvent):void</code>
* <code>function ProcessUserEvent(strEventName:String, abPressed:Boolean):Boolean</code>
* <code>function UpdateEncumbranceAndCaps(aContainer:Boolean, aCurrWeight:uint, aMaxWeight:uint, aCaps:uint, aIncomingCaps:int):*</code>
* <code>function UpdatePickpocketInfo(aShow:Boolean, aTaking:Boolean, aSuccessPercent:uint):*</code>
* <code>function onQuantityModified(aEvent:Event):*</code>
* <code>function onToggleEquip():*</code>
* <code>function requestSort():*</code>

==== BGSCodeObj ====
* <code>function PlaySound(name:String):void</code>
* <code>function toggleSelectedItemEquipped(index:int, inContainer:Boolean):void</code>
* <code>function confirmInvest():void</code>
* <code>function inspectItem():void</code>
* <code>function getSelectedItemEquipped(index:int, inContainer:Boolean):Boolean</code>
* <code>function onIntroAnimComplete():void</code>
* <code>function getItemValue(index:int, inContainer:Boolean):*</code>
* <code>function getSelectedItemEquippable(index:int, inContainer:Boolean):Boolean</code>
* <code>function show3D(index:int, inContainer:Boolean):void</code>
* <code>function sendYButton():void</code>
* <code>function sendXButton():void</code>
* <code>function updateItemPickpocketInfo(index:int, inContainer:Boolean):void</code>
* <code>function sortItems(isPlayerInv:Boolean, indexFilter:uint, arg3:Boolean):void</code>
* <code>function exitMenu():void</code>
* <code>function transferItem(index:int, inContainer:Boolean):void</code>
* <code>function takeAllItems():void</code>
* <code>function updateSortButtonLabel(isPlayerInv:Boolean, indexFilter:uint):void</code>

== See Also ==
*[[Container]]
*[[Menu]]
*[[User Interface]]




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
