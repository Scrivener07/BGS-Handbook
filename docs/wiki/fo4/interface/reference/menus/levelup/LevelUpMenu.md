The '''Level Up Menu''' is where the [[Player]] may spend points to add or improve [[Perk]]s and attributes.

==== BGSCodeObj ====
* <code>CloseMenu : Function()</code>
* <code>SelectPerk : Function()</code>
* <code>PlaySound : Function()</code>
* <code>onGridAddedToStage : Function()</code>
* <code>RegisterPerkGridComponents : Function()</code>
* <code>GetXPInfo : Function()</code>
* <code>PlayZoomSound : Function()</code>
* <code>StopPerkSound : Function()</code>
* <code>GetPerkInfoByRank : Function()</code>
* <code>PlayPerkSound : Function()</code>


# LevelUpMenu.as Documentation
The `LevelUpMenu.as` file contains the ActionScript code for a user interface menu that likely pertains to a level-up system in a game.
Below is an overview of the code structure and functionalities.

## Overview
The `LevelUpMenu` class extends `IMenu` and is responsible for managing the perk selection interface when a player levels up.
The menu allows players to choose perks, view their descriptions, and confirm their selections.

### Class Properties
The `LevelUpMenu` class contains several public and private properties for handling UI elements, button hints, and perk selection logic.

| Property | Type | Description |
|----------|------|-------------|
| `GridView_mc` | PerkGrid | The grid view that displays available perks. |
| `PerkInfo_mc` | MovieClip | The UI component that shows detailed information about a selected perk. |
| `XPMeterHolder_mc` | MovieClip | Holds the experience (XP) meter for the player. |
| `ButtonHintBar_mc` | BSButtonHintBar | A bar that provides hints for the button controls. |
| `uiPerkCount` | uint | The number of perks the player can select. |
| `errorDisapearTimer` | Timer | A timer to handle the disappearance of error messages. |
| `bConfirming` | Boolean | Indicates if the player is in the process of confirming a perk selection. |
| `AcceptButton`, `CancelButton`, `PrevPerkButton`, `NextPerkButton` | BSButtonHintData | Button data for accepting, canceling, and navigating perks. |

### Constructor
The constructor initializes the UI components and button hints.
It also sets up event listeners for various user interactions.

```actionscript
public function LevelUpMenu() {
    // ... Initialization code ...
}
```

### Public Methods
The class provides methods for handling various actions within the menu.

| Method | Description |
|--------|-------------|
| `onCodeObjCreate()` | Initializes the perk grid and XP information. |
| `onCodeObjDestruction()` | Clears references upon destruction. |
| `ProcessUserEvent()` | Processes user input events, such as button presses. |
| `InvalidateGrid()` | Refreshes the perk grid. |

### Protected Methods
These methods provide internal logic for perk selection, UI updates, and confirmation processes.

| Method | Description |
|--------|-------------|
| `onGridItemPress()` | Handles the event when a perk item is pressed. |
| `TryToAcquirePerk()` | Attempts to acquire a selected perk. |
| `OnSelectPerk()` | Finalizes the perk selection. |
| `UpdateSelectionText()` | Updates text information for the selected perk. |
| `RefreshStarStates()` | Updates the visual state of the perk's rank stars. |
| `SetButtons()` | Configures the visibility and state of control buttons. |
| `StartConfirmation()` | Begins the confirmation process for selecting a perk. |
| `EndConfirmation()` | Ends the confirmation process. |
| `ShowErrorText()` | Displays an error message. |
| `ClearErrorText()` | Clears error messages from the UI. |

### Event Handlers
The class listens for various events and defines handlers accordingly.

| Event | Handler | Description |
|-------|---------|-------------|
| `PerkGrid.SELECTION_CHANGE` | `onGridSelectionChange()` | Invoked when the perk selection changes. |
| `PerkGrid.ZOOMING` | `onGridZoom()` | Invoked when the grid zoom changes. |
| `PerkGrid.TEXTURES_LOADED` | `onGridTexturesLoaded()` | Invoked when the perk textures have loaded. |
| `TimerEvent.TIMER` | `onTimerClearErrorText()` | Invoked when the error message timer elapses. |

## Example Usage

**1. Creating an instance of LevelUpMenu:**
```actionscript
var levelUpMenu:LevelUpMenu = new LevelUpMenu();
```

**2. Responding to a perk selection:**
```actionscript
// This snippet is a simplified example of how a perk might be selected
levelUpMenu.GridView_mc.selectPerk(perkID);
```

**3. Processing a button hint event:**
```actionscript
// Example of handling a user event, such as pressing the "Accept" button
levelUpMenu.ProcessUserEvent("Accept", false);
```

**Emoji Summary:**
- 🎮 The `LevelUpMenu` manages a game's level-up interface.
- ⭐ It includes functionality to display perks and handle player interactions.
- 🛠️ Constructors and methods facilitate the creation and operation of the menu.

**Note**:
The actual usage may differ based on the game's engine and the surrounding framework.
This documentation covers only the specifics of the `LevelUpMenu` class as defined in the provided code snippet.
