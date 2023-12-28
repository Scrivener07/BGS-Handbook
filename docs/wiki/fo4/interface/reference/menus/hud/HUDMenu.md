### HUD
The Heads-Up Display is an essential part of the UI, displaying vital information such as health, action points, ammo, and a compass.
It is designed to be non-intrusive, with the ability to toggle elements on or off and customize colors and transparency.

The **HUD Menu**, or Heads-Up Display is an on-screen interface that provides players with essential information and quick access to various in-game elements.
The HUD menu color and transparency may be customized by user preference.

The key components of the HUD menu are:
- Health Bar: Located at the bottom center of the screen, the health bar represents the player's current health status. It depletes as the player takes damage and regenerates when the player heals.
- Action Points (AP) Bar: Situated right above the health bar, the AP bar indicates the player's available action points, which are consumed when performing actions like sprinting, using VATS, or executing special attacks in melee combat.
- Compass: Found at the bottom of the screen, the compass shows the direction the player is facing, along with markers for nearby locations, objectives, and enemies.
- Ammo Counter: Displayed in the bottom right corner, the ammo counter shows the remaining ammunition for the currently equipped weapon, as well as the total ammunition in the player's inventory.
- Weapon and Item Icons: The currently equipped weapon or item is represented by an icon on the lower right side of the screen.
- Enemy Health and Status: When targeting an enemy, their health bar and any status effects (such as being crippled or poisoned) will appear at the top of the screen.
- Experience Points (XP) and Level Progress: Upon gaining XP, a small progress bar appears at the top left corner of the screen, indicating the progress towards the next level.
- Notifications: Temporary messages appear in the top left corner, notifying players of completed objectives, new quests, and other important information.
- Quick Loot Menu: When looking at a container or a fallen enemy, a small menu appears, showing the items available for looting, allowing players to quickly grab the desired items.

## AS3
- `var BGSCodeObj:Object`
- `var FloatingQuestMarkerBase:MovieClip`
- `var HUDNotificationsGroup_mc:MovieClip`
- `var TopCenterGroup_mc:MovieClip`
- `var TopRightGroup_mc:MovieClip`
- `var CenterGroup_mc:MovieClip`
- `var LeftMeters_mc:MovieClip`
- `var BottomCenterGroup_mc:MovieClip`
- `var SafeRect_mc:MovieClip`
- `function onSetSafeRect() : void`
- `function onCodeObjCreate() : *`
- `function onCodeObjDestruction() : *`

#### `BGSCodeObj`
- `function PlaySound()`
- `function GetButtonFromUserEvent(param1:String, param2:Boolean)`





# HUDMenu.as Documentation
This is the documentation for the ActionScript file `HUDMenu.as`.
The code represents a dynamic class `HUDMenu` which extends `IMenu`, intended to be used within a HUD (Heads-Up Display) in a graphical user interface.

The `HUDMenu` class manages various HUD elements and their positioning.

## Table of Contents
- [Class Definition](#class-definition)
- [Properties](#properties)
- [Constructor](#constructor)
- [Functions](#functions)
  - [onSetSafeRect](#onsetsaferect)
  - [onCodeObjCreate](#oncodeobjcreate)
  - [onCodeObjDestruction](#oncodeobjdestruction)

## Class Definition
The `HUDMenu` class is declared as dynamic, allowing properties to be added at runtime, and it inherits from `IMenu`.
```actionscript
public dynamic class HUDMenu extends IMenu
```

## Properties
| Property Name | Type | Description |
| ------------- | ---- | ----------- |
| `FloatingQuestMarkerBase` | `MovieClip` | Holds the movie clip for floating quest markers. |
| `HUDNotificationsGroup_mc` | `MovieClip` | Movie clip grouping HUD notifications. |
| `TopCenterGroup_mc` | `MovieClip` | Top center group in the HUD. |
| `TopRightGroup_mc` | `MovieClip` | Top right group in the HUD. |
| `CenterGroup_mc` | `MovieClip` | Center group in the HUD. |
| `LeftMeters_mc` | `MovieClip` | Left side meters in the HUD. |
| `BottomCenterGroup_mc` | `MovieClip` | Bottom center group in the HUD. |
| `RightMeters_mc` | `MovieClip` | Right side meters in the HUD. |
| `SafeRect_mc` | `MovieClip` | Movie clip used for safe area calculations. |
| `BGSCodeObj` | `Object` | An object for storing code-related data. |

## Constructor
The constructor initializes the `HUDMenu` by setting `BGSCodeObj` to a new `Object` and enabling `Extensions`.
```actionscript
public function HUDMenu()
{
    super();
    this.BGSCodeObj = new Object();
    Extensions.enabled = true;
}
```

## Functions

### onSetSafeRect
This method is responsible for locking the HUD elements to the safe areas of the screen to ensure visibility across different display sizes.
```actionscript
override protected function onSetSafeRect() : void
{
    GlobalFunc.LockToSafeRect(this.HUDNotificationsGroup_mc, "TL", SafeX, SafeY);
    GlobalFunc.LockToSafeRect(this.TopCenterGroup_mc, "TC", SafeX, SafeY);
    GlobalFunc.LockToSafeRect(this.TopRightGroup_mc, "TR", SafeX, SafeY);
    GlobalFunc.LockToSafeRect(this.CenterGroup_mc, "CC", SafeX, SafeY);
    GlobalFunc.LockToSafeRect(this.LeftMeters_mc, "BL", SafeX, SafeY);
    GlobalFunc.LockToSafeRect(this.BottomCenterGroup_mc, "BC", SafeX, SafeY);
    GlobalFunc.LockToSafeRect(this.RightMeters_mc, "BR", SafeX, SafeY);
}
```

### onCodeObjCreate
This method assigns `BGSCodeObj` to the `codeObj` property of `PAWarningText`, which is part of the `RightMeters_mc` movie clip hierarchy.
```actionscript
public function onCodeObjCreate() : *
{
    (this.RightMeters_mc.PowerArmorLowBatteryWarning_mc.WarningTextHolder_mc as PAWarningText).codeObj = this.BGSCodeObj;
}
```

### onCodeObjDestruction
This method clears the `BGSCodeObj` and the associated `codeObj` within `PAWarningText` to prevent memory leaks upon the destruction of the code object.
```actionscript
public function onCodeObjDestruction() : *
{
    this.BGSCodeObj = null;
    (this.RightMeters_mc.PowerArmorLowBatteryWarning_mc.WarningTextHolder_mc as PAWarningText).codeObj = null;
}
```

## Notes
- **Dynamic class**: Allows runtime property addition.
- **SafeRect**: Ensures HUD elements are visible within the safe area of the screen.
- **CodeObj**: A generic object container used to hold code-related data, possibly for interactions with game logic.

This documentation provides an overview of the `HUDMenu` class usage and structure for developers working on HUD systems within ActionScript-based applications or games.
