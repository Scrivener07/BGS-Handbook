---
title: "PowerArmorHUDMenu"
---


## Overview :page_facing_up:
The `PowerArmorHUDMenu.as` file contains a single ActionScript class intended for use in a gaming context.
This class is responsible for creating a Heads-Up Display (HUD) Menu specifically for a Power Armor user interface.

It extends the `IMenu` class, which presumably provides foundational menu functionality within the game's UI system.

## Class Definition :classical_building:

**File Name**: `PowerArmorHUDMenu.as`

**Package**: (Root package)

**Imports**:
- `Shared.IMenu`

**Class**: `PowerArmorHUDMenu`

**Inheritance**: `PowerArmorHUDMenu` is a dynamic subclass of `IMenu`.

### Properties :straight_ruler:

| Property | Type | Description |
|----------|------|-------------|
| **CompassWidget_mc** | `HUDCompassWidget` | A member variable intended to represent the compass widget on the HUD. |

### Constructor :construction:
The constructor method initializes the `PowerArmorHUDMenu` class.

```actionscript
public function PowerArmorHUDMenu() {
    super();
}
```

## Usage :video_game:
To use the `PowerArmorHUDMenu` class within the game, one would need to create an instance of it, which will in turn initialize its superclass, `IMenu`.
The `CompassWidget_mc` property is accessible for further manipulation if needed, such as setting its position, visibility, or any other relevant functionality provided by the `HUDCompassWidget` class.

## Example :memo:
Below is a simple example of how the `PowerArmorHUDMenu` might be instantiated within the game's code:

```actionscript
// Create an instance of the PowerArmorHUDMenu
var hudMenu:PowerArmorHUDMenu = new PowerArmorHUDMenu();

// Assuming additional functionality on the CompassWidget_mc
hudMenu.CompassWidget_mc.show();
```

**:warning: Note**: Since this is a high-level documentation based on the provided code snippet, the actual implementation details and the methods available on `CompassWidget_mc` may vary.

**Bold Elements**: Elements such as class names, method names, and property names have been **bolded** for quick identification.

**:sparkles: Emoji Guide**:
- :page_facing_up: - Indicates documentation or information sections.
- :classical_building: - Represents the class definition and structure.
- :straight_ruler: - Used for outlining properties or variables.
- :construction: - Marks the constructor of the class.
- :video_game: - Signals usage or behavioral context within the game.
- :memo: - Suggests an example or code snippet.
- :warning: - Denotes attention or caution regarding the code or its usage.
