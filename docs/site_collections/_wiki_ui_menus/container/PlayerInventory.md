---
title: "PlayerInventory"
categories: fo4 interface menus container
---

The `PlayerInventory` class is an ActionScript file that extends `MovieClip` to provide a dynamic user interface for a game's player inventory system.
Below is the detailed documentation of the `PlayerInventory.as` file.

## File Overview

**Filename:** `PlayerInventory.as`

**Package:** (root package)

**Imports:**
- `flash.display.MovieClip`
- `flash.text.TextField`

**Description:**
The `PlayerInventory` class is designed to handle the in-game player inventory interface.
It contains references to various text fields and movie clips that make up the inventory HUD (Heads-Up Display).

## Class Definition

```actionscript
package {
    import flash.display.MovieClip;
    import flash.text.TextField;

    public dynamic class PlayerInventory extends MovieClip {
        // Class properties
        public var RightHitBox_tf:TextField;
        public var PlayerCaps_tf:TextField;
        public var LeftHitBox_tf:TextField;
        public var PlayerListHeader:ListHeader;
        public var PlayerWeight_tf:TextField;
        public var PlayerList_mc:PlayerList;
        public var PlayerBracketBackground_mc:MovieClip;
        public var PlayerSwitchButton_tf:TextField;

        // Constructor
        public function PlayerInventory() {
            super();
            this.__setProp_PlayerList_mc_PlayerInventory_Layer1_0();
        }

        // Private method
        function __setProp_PlayerList_mc_PlayerInventory_Layer1_0() : * {
            try {
                this.PlayerList_mc["componentInspectorSetting"] = true;
            } catch(e:Error) {
            }
            this.PlayerList_mc.listEntryClass = "PlayerListEntry";
            this.PlayerList_mc.numListItems = 9;
            this.PlayerList_mc.restoreListIndex = true;
            this.PlayerList_mc.textOption = "Shrink To Fit";
            this.PlayerList_mc.verticalSpacing = 0;
            try {
                this.PlayerList_mc["componentInspectorSetting"] = false;
            } catch(e:Error) {
            }
        }
    }
}
```

## Properties

The following table describes the properties within the `PlayerInventory` class:

| Property Name                  | Type            | Description                                    |
|--------------------------------|-----------------|------------------------------------------------|
| **RightHitBox_tf**             | TextField       | A text field for the right hitbox area.        |
| **PlayerCaps_tf**              | TextField       | A text field showing the number of player caps.|
| **LeftHitBox_tf**              | TextField       | A text field for the left hitbox area.         |
| **PlayerListHeader**           | ListHeader      | The header for the player list.                |
| **PlayerWeight_tf**            | TextField       | A text field showing the player's weight.      |
| **PlayerList_mc**              | PlayerList      | The movie clip that contains the player list.  |
| **PlayerBracketBackground_mc** | MovieClip       | The background movie clip for the bracket.     |
| **PlayerSwitchButton_tf**      | TextField       | A text field for the player switch button.     |

## Constructor

The constructor of the `PlayerInventory` class calls the `super()` method to inherit properties and methods from the `MovieClip` class. It also initializes the player list component by calling the `__setProp_PlayerList_mc_PlayerInventory_Layer1_0` method.

## Methods

### __setProp_PlayerList_mc_PlayerInventory_Layer1_0

This private method is responsible for configuring the `PlayerList_mc` movie clip.
It sets various properties such as the list entry class name, the number of list items, restoration of list indices, text options for the entries, and vertical spacing between list items.

**Configurations**:
- **listEntryClass:** "PlayerListEntry"
- **numListItems:** 9
- **restoreListIndex:** true
- **textOption:** "Shrink To Fit"
- **verticalSpacing:** 0

## Conclusion

The `PlayerInventory` class provides a structured approach to managing the player's inventory within a game.
It incorporates various UI components that are essential for displaying and interacting with inventory items.

The class is thoughtfully designed to be both flexible and intuitive for programmers to adapt and extend according to the game's specific needs.
