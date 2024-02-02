---
title: "UI Menu Control Input"
categories: fo4 interface topics
---

Enable menu control by extending the `IMenu` AS3 class.

A menu needs to extend `IMenu` in order to properly use the `EnableMenuControl:0x08` menu flag.

#### Notes
- The *safe area bound clip* apply a visual masking area for the menu in the form of an invisible rectangle.
- There might be some expected visual structure or the `IMenu` class is fulfilling some native callback implementation.
- Some menu features might need the root MovieClip might to be the conventional `root1.Menu_mc` or `root1.Fader_mc.Menu_mc`.
