---
title: "Guides"
---

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


# Features
- A *describer* UI view for Player reference information.
- A *describer* UI view for game items.
- A *describer* UI view for reflecting the members of a Papyrus script.
- A *describer* UI view for tracing a target menu's display hierarchy.

# Topics
- Adding the base source directory to the Flash document source imports.
- Add a package namespace for `Diagnostics`.
- Show how static unconfigured font symbols will appear fine, but turn to rectangles if you change the text through code.

# Topics
- How to open the menu by key press.
- How to open the menu by object activation.
- How to open the menu by item activation/consumption.
- How to open the menu by equipped item type.

# Data Communication
- Send and display game object data.
- Send and display script object data.
- Send and display an array of a single type.
- Send and display an array of arrays.

# User Interface
- Explain the menu flags and their combinations.
- Menu persistence with `DoNotDeleteOnClose` menu flag.
- Explain menu depth layers and application domains.
- Explain the injected `f4se` object and root/first-level callback.
- Explain how to runtime inject Flash documents into other menus.

# Other
- Input for Keyboard, Mouse, and controller.
- How to read TXT, XML, JSON, and other files on disk.
- Explain how the UI resolution scaling works and the effects on ultra-wide.


# Links
- https://falloutck.uesp.net/wiki/MenuData_Struct_-_UI
- https://github.com/F4CF/Creation-Framework/blob/master/System.XSE/Interface/Source/System.XSE/F4SE/XSE.as
- https://github.com/ianpatt/f4se
