---
title: "Interface"
categories: fo4 interface
---

The Fallout 4 in-game menus, such as the HUD, and other user interface elements were built using [Adobe Animate](https://www.adobe.com/products/animate.html) and [Autodesk Scaleform](https://en.wikipedia.org/wiki/Scaleform_GFx).
Adobe Flash is a tool for creating vector based graphics and animations.

This tool also offers a scripting language called ActionScript which allows for interactive content, user interfaces, and even standalone applications.

Autodesk Scaleform is a middleware that allows developers integrate Adobe Flash based technology with their game engine.


# Interface Files
The in game *User Interface* and *Menus* are vector based animations created with Adobe Flash via [https://en.wikipedia.org/wiki/Scaleform_GFx Scaleform].
These are commonly referred to as *Flash Files* or *Interface Files*.

There are several kinds flash files with very different purposes.
- **File Extension:** `.swf`, `.fla`, `xfl`, `.as`, `.gfx`

### Movie: `.swf`
These are used by the flash player after being published from a *Movie Project* and *Actionscript*.

### Movie Project: `.fla` or `.xfl`
Movie projects are used in combination with *Actionscript* to publish playable *Movie* files.

### Actionscript: `.as`
Fallout 4 uses the the Actionscript 3.0 language version.
This is the source code for flash animation scripting.


# Flash Documents
All Flash Scaleform documents in Fallout 4 will target `Flash Player 11.2` with `Actionscript 3.0`.

Fallout 4 presets for Adobe Flash Animate are provided in the [by this project](https://github.com/F4CF/Interface/tree/master/--Tools/Adobe%20Animate/Configuration).
Install these configurations to the `...\AppData\Local\Adobe\<SOFTWARE>\en_US\Configuration\` directory where you replace the `<SOFTWARE>` part of the path with the software version you have installed.
The `<SOFTWARE>` for you might be `Flash CS6`, `Animate CC 2019`, `Animate CC 2021`, `Animate CC 2024`, and so on.

### Document Presets
The IDE version used by Bethesda to create the interface for Skyrim and Fallout 4 was likely *Adobe Flash CS6*.
Design full screen menus with the dimensions of `1280x720` which are scaled to the users current resolution.

- **Standard:** A standard full screen scaleform document uses a size of `1280x720` at `30` frames per second.
- **Pipboy:** The Pipboy and Pipboy Tab documents use a size of `876x700` at `30` frames per second.
- **Terminal:** A Terminal document uses a size of `826x700` at `24` frames per second.
- **Vault Boy:** A Vault Boy document uses a size of `550x400` at `24`, `28`, `30`, or `32` frames per second.


# External Resources : Scaleform Relative Paths
A quirk about Bethesda's Scaleform implementation is restricted file access.
Although you can use a path relative to your menu, you cannot "look up" with the `..\` if that directory change would result in entering a parent relative to the menu.

You can use `..\`, but only up to the menus current level.
In other words, it can look down and back up again, but not above.

In practice, this means that your menu that RSL loaded libraries such as the vanilla `fonts_en.swf` MUST be a sibling with your menu.

This would also apply to paths given to the actionscript `MovieClipLoader` class.
