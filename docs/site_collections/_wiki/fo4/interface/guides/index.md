---
title: "Guides"
categories: fo4 interface guides
---

See also the [Topics]({{ site.baseurl }}{% link _wiki/fo4/interface/topics/index.md %}) section.


#### Notes
I may need to cover how to decompile vanilla menus early on.
This is because many UI features require the base Bethesda and Scaleform menu code.


### How to topics
- [How do I modify the vanilla menus?](#vanilla)
- [How do I create a custom standalone menu?](#custom)
- [How do I load a custom UI document into an existing menu?](#injection)
- [How do I create new Holotape programs?](#holotapes)
- [How do I create new Vault-Boy art?](#vaultboys)
- [How do I create HUD Framework widgets?](#widgets)


## Flash Primer {#primer}
Provides a Flash primer focused on Fallout 4 Scaleform GFx.


## Vault Boy Art {#vaultboys}
Covers the creation of new Vault Boy art.


## Modify Vanilla Menus {#vanilla}
Provides a guide on modifying the vanilla menus.


## Custom Menu {#custom}
The goal of this project is to create a custom menu which can display information about any provided game data.
It will be capable of describing game references, Papyrus script data, diagnostic information about the UI, and some other odds and ends.

This project will showcase all the F4SE UI features.

This will feature a tabbed menu.
Each tab will represent a view for a certain kind of object.

The base menu will have an array (vector) of `MovieClip` objects which are prepared ahead of time.

When data is passed in from Papyrus, read the `__type__` and look it up in a dictionary that matches the type to the associated `MovieClip` tab view.

Then display the matched tab view.

For UI diagnostics, provide a list of all game menus.

When a menu is selected, show useful information like registered name, file path, visual hierarchy, etc.

For a script type, use f4se to reflect the members.


#### Features
- A *describer* UI view for Player reference information.
- A *describer* UI view for game items.
- A *describer* UI view for reflecting the members of a Papyrus script.
- A *describer* UI view for tracing a target menu's display hierarchy.


### Menu Injection {#injection}
This section will cover loading a custom UI document into an existing menu.


## Holotape Programs {#holotapes}
This section covers the creation of Holotape programs.


## HUD Framework Widgets {#widgets}
This section covers the creation of HUD Framework widgets.


## Links
- https://falloutck.uesp.net/wiki/MenuData_Struct_-_UI
- https://github.com/F4CF/Creation-Framework/blob/master/System.XSE/Interface/Source/System.XSE/F4SE/XSE.as
- https://github.com/ianpatt/f4se
