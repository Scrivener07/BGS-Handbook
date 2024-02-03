---
title: "BarterMenu"
categories: fo4 interface menus container-barter
---

The **Barter Menu** is used to trade items between the *Player* and an *Actor*.
This menu is usually opened through *Actor* dialogue scripts using the `Actor.ShowBarterMenu()` Papyrus function.

## AS3
The ActionScript instance variable which points to the `BarterMenu` class is `root1.FilterHolder_mc.Menu_mc` where `Menu_mc` is an instance of `BarterMenu.as`.
The `BarterMenu` class in ActionScript directly inherits (extends) the `ContainerMenu.as` class.


#### BGSCodeObj
- `function PlaySound(name:String):void`
- `function toggleSelectedItemEquipped(index:int, inContainer:Boolean):void`
- `function confirmInvest():void`
- `function inspectItem():void`
- `function getSelectedItemEquipped(index:int, inContainer:Boolean):Boolean`
- `function onIntroAnimComplete():void`
- `function getItemValue(index:int, inContainer:Boolean):*`
- `function getSelectedItemEquippable(index:int, inContainer:Boolean):Boolean`
- `function show3D(index:int, inContainer:Boolean):void`
- `function sendYButton():void`
- `function sendXButton():void`
- `function updateItemPickpocketInfo(index:int, inContainer:Boolean):void`
- `function sortItems(isPlayerInv:Boolean, indexFilter:uint, arg3:Boolean):void`
- `function exitMenu():void`
- `function transferItem(index:int, inContainer:Boolean):void`
- `function takeAllItems():void`
- `function updateSortButtonLabel(isPlayerInv:Boolean, indexFilter:uint):void`


## See Also
- [Actor]()
- [ShowBarterMenu - Actor]()
- [ContainerMenu](../container)
- [Menu]()
- [User Interface]()
