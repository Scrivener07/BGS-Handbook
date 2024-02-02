---
title: "Flash Restoring Menus"
categories: fo4 interface topics
---

This document explains how to restore a decompiled menu by fixing common errors.

Decompiling and republishing the vanilla menus using a tool like FFDec is no easy task.
This can be a very tedious process. 😅


#### Common Problems
There are many errors you can expect to find in a freshly decompiled menu.
- The "automatically declare stage instances" publish option must be disabled.
- The authortime shared libraries (ASL) get unlinked from their Flash document library objects.
- The runtime shared libraries (RSL) get unlinked from their Flash document library objects.
- Flash document library objects will have lost their object names and library folder organization.
- Tweened animation timelines become exploded into individual key frames, and are no longer tweens.
- All `TextField` objects must have their font relinked to the `fonts_en.swf` runtime shared library.


### Note: Decompiled AS3 Code
SWF stands for "small web format" and has lots of compilation and linking options to well, make it smaller.
Usually, you can count on a SWF to statically compile, which means that all the code dependencies are baked into the output SWF.
But due to optimizations in the Flash publisher, no one menu will have the complete code base baked into it.


### Error: Automatically declared stage instances
The "automatically declare stage instances" publish option must be disabled in most cases.


### Error: Missing Imports
In some cases your code may not compile because it is missing library code.
There might be code attached to stage objects has an AS3 linkage to a class that cannot be found.

You may also have many other errors that are resolved once you add the missing code import.
The rest of the errors that seemed to disappear are called cascading errors.


### Restoring Library Object Names
It can be repaired, just be careful not to delete any instance names.


### Restoring Tweened Animations
FFDec will ruin all tweens by baking them as static key frames.
