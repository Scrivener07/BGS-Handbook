---
title: "Menu Restoration"
---


#### Objectives
- This example will be fully Xbox compatible.
- Demonstrate the built in HTML text capability of Flash text fields.
- Restore the `MessageBoxMenu` source files for editing in Adobe Animate.
- Add custom rendering support for formatted `Message` forms.
- - Simple markdown support for the body text of a `Message` form.
- - Create a runtime shared emoji art library to support rendering emoji text tags. Such as writing `:smile:` in the body text of a `Message` form.

#### Uses
- [FFDec](/wiki/tooling/FFDec) (using v20.1.0)
- Adobe Animate (CC 2024)
- Emojis (<https://openmoji.org/>)


## Guide
This document provides a guide on restoring source files for the Fallout 4 game menus.

The menus in Fallout 4 are each distributed as a published `*.swf` file that is playable by the game.
Although FFDec provides a way to patch modifications directly into a published `*.swf` file, this is not the conventional way to edit such a file.

A `*.swf` files starts its life as an `*.fla` file which is not playable by the game.

~~We might want to do this if we want to add or modify the functionality or visuals or an existing menu for which you do not have the source files.~~
~~To demonstrate the process we will restore and modify `MessageBoxMenu.swf` menu.~~

Getting these source files requires decompiling `MessageBoxMenu.swf` into a `MessageBoxMenu.fla` and it's associated `*.as` files.
For this task we will use a tool called [FFDec](/wiki/tooling/FFDec), also known as JPEXS Free Flash Decompiler.



### Decompiling with FFDec
From `Fallout4 - Interface.ba2`, extract both `MessageBoxMenu.swf` and `fonts_en.swf` to your `Data\Interface\` folder.
Now open `MessageBoxMenu.swf` with FFDec.

You may get the following message in FFDec concerning external SWF assets.

```
The SWF files uses assets from an imported SWF file: fonts_en.swf
Do you want the assets to be loaded from that URL?
```

This is nothing to worry and is not an error.
Choose *Yes* to allow FFDec to import the assets.
This imported asset is often `fonts_en.swf`.

Allowing FFDec to import the `fonts_en.swf` font library gives an accurate preview of the fonts used in game.
Without importing external assets related to fonts, FFDec with have to substitute game fonts with system installed fonts.
This font substitution is only used for the in tool preview and has no affect on the file.
It is acceptable to skip loading `fonts_en.swf` if you do not care about fonts being represented accurately in the previews.

Navigate to the **File** tab of the FFDec tool strip and select **Export to FLA**.
Choose an appropriate FLA version.
I recommend saving as *Flash CS 6 Document (*.fla)* because it has the widest compatibility with tool versions.
Bethesda used *Adobe Flash CS4 Professional* to publish their `MessageBoxMenu.swf` according to meta data, but saving as higher Flash versions can be done for most menus.

Our project code name will be "MessageMarkdown" with a pretty display name of "Message Markdown Extensions".
Name the file `MessageBoxMenu.fla` and save it to `Fallout 4\Data\Interface\Source\MessageMarkdown\MessageBoxMenu.fla`.

Once the FLA finishes exporting, close FFDec.
We are now done with using FFDec for the remainder of this tutorial.


## Restoring
Now navigate to `Fallout 4\Data\Interface\Source\MessageMarkdown\` and take a moment to observe the files and folders.
The `MessageBoxMenu.fla` file serves as the primary working document in Adobe Animate.
This file us used for creating and publishing a SWF file, similar to how a `*.psd` file functions in Adobe Photoshop.

The `.as` ActionScript files that are direct siblings of `MessageBoxMenu.fla` are scripts specific to this menu.
The `MessageBoxMenu.as` script is the primary class that controls the menu functionality.
The `MessageBoxButtonList.as` and `MessageBoxButtonEntry.as` scripts are an implementation of the shared scrolling list UI component.
The other `.as` files within the `scaleform`, `Shared`, and `Mobile` directories are shared class libraries used by all the menus in Fallout 4.

```
Fallout 4\Data\Interface\Source\MessageMarkdown\MessageBoxMenu.fla
|   MessageBoxButtonEntry.as
|   MessageBoxButtonList.as
|   MessageBoxMenu.as
|   MessageBoxMenu.fla
|
+---Mobile
|   \---ScrollList
|           EventWithParams.as
|           FlashUtil.as
|           MobileListItemRenderer.as
|           MobileScrollList.as
|
+---scaleform
|   \---gfx
|           DisplayObjectEx.as
|           Extensions.as
|           InteractiveObjectEx.as
|           TextFieldEx.as
|
\---Shared
    |   BGSExternalInterface.as
    |   GlobalFunc.as
    |   IMenu.as
    |   PlatformChangeEvent.as
    |   PlatformRequestEvent.as
    |
    \---AS3
        |   BSScrollingList.as
        |   BSScrollingListEntry.as
        |   ListFilterer.as
        |
        \---COMPANIONAPP
                BSScrollingListInterface.as
                CompanionAppMode.as
                MobileScrollListProperties.as
```

Now open the `MessageBoxMenu.fla` file with Adobe Animate and wait for it to finish loading.
Once the document is loaded you will see that the `MessageBoxMenu` is relatively simple compared to the other menus.
This menu features a scrolling list of button entries and a `TextField` for the message body text.

Before we begin restoring the source for this menu, lets try to publish it as-is.
Press the keyboard shortcut `ALT + SHIFT + F12` to publish your document immediately.

Take notice of the **Output** and **Compiler Errors** panel in Adobe Animate which shows the document had problems and could not be published.
These problems are listed below.

**Output**
```
Fonts should be embedded for any text that may be edited at runtime, other than text with the "Use Device Fonts" setting.
Use the Text > Font Embedding command to embed fonts.
```

**Compiler Errors**
```
...\MessageBoxButtonEntry.as, Line 3, Column 25	1152: A conflict exists with inherited definition Shared.AS3:BSScrollingListEntry.border in namespace public.
...\MessageBoxButtonEntry.as, Line 6, Column 2	1152: A conflict exists with inherited definition Shared.AS3:BSScrollingListEntry.textField in namespace public.
...\MessageBoxButtonList.as, Line 1, Column 1	5000: The class 'MessageBoxButtonList' must subclass 'flash.display.MovieClip' since it is linked to a library symbol of that type.
...\MessageBoxMenu.as, Line 1, Column 1	5000: The class 'MessageBoxMenu' must subclass 'flash.display.MovieClip' since it is linked to a library symbol of that type.
```

Now press the keyboard shortcut `CTRL + SHIFT + F12` to open the **Publish Settings** window for your Flash document.
Disable the *HTML Wrapper* publish format and ensure only the *Flash (.swf)* format is enabled.
The target Flash player version is usually *Flash Player 11.2*.
The script type is always *ActionScript 3.0*.

Now we will set the *Output name* to publish the SWF file to `Fallout 4\Data\Interface\MessageBoxMenu.swf` which will override the original version stored in `Fallout4 - Interface.ba2`.
When setting the *Output name* for your Flash document, be sure to always use a relative path, and not a full path with a drive letter on the front.

For this menu, use an *Output name* of `../../MessageBoxMenu` which will put the file two directories above its current directory.
Or in others words, two folders above relative to itself.
You can delete the stray `MessageBoxMenu.swf` and `MessageBoxMenu.html` that may have ended up in your `Fallout 4\Data\Interface\Source\MessageMarkdown\` folder from our first publish attempt.
The game will only consider the `Fallout 4\Data\Interface\MessageBoxMenu.swf` path for archive override replacers.

Now click the **ActionScript Settings** button which is the small wrench icon.
On the *ActionScript Settings*, disable the *Automatically declare stage instances* option.
Press *Ok* to close the **ActionScript Settings** window, and then press *Ok* again to close the **Publish Settings** windows.

Now again, press the keyboard shortcut `ALT + SHIFT + F12` to publish your document.

Our SWF file was successfully published and the **Compiler Errors** panel no longer has errors.
Although no errors are present, we have 3 new warnings.
Lets take a look at these ActionScript files to see what the warnings are telling us.
Double clicking the warning will open the associated ActionScript file and line number.

**Output**
```
Fonts should be embedded for any text that may be edited at runtime, other than text with the "Use Device Fonts" setting.
Use the Text > Font Embedding command to embed fonts.
```

**Compiler Errors**
```
...\Shared\AS3\BSScrollingList.as, Line 658, Column 16	Warning: 1100: Assignment within conditional.  Did you mean == instead of =?
...\Shared\AS3\BSScrollingList.as, Line 677, Column 16	Warning: 1100: Assignment within conditional.  Did you mean == instead of =?
...\MessageBoxButtonList.as, Line 41, Column 16	Warning: 1100: Assignment within conditional.  Did you mean == instead of =?
```

**MessageBoxButtonList.as, Line 41**
```as
if(_loc6_ = GetClipByIndex(_loc3_) as MessageBoxButtonEntry)
```

**Shared\AS3\BSScrollingList.as, Line 658**
```as
if(_loc7_ = this.GetClipByIndex(_loc5_))
```

**Shared\AS3\BSScrollingList.as, Line 677**
```as
if(_loc8_ = this.GetClipByIndex(this.iListItemsShown))
```


These lines all give the *Assignment within conditional* warning which is given when the Flash compiler suspects the programmer has made a logical error rather than a syntactical error.
The Flash compiler will only prevent compilation for outright syntax errors, but suspected logical errors are issued as warnings.

When *assignment within conditional* occurs in code it usually is an error made by the programmer but in this case it was due to the way FFDec reconstructs and writes out decompiled scripts.
These lines were likely written differently in Bethesda's original code base, but decompilers for most languages are not able to reconstruct source that represents the original perfectly in all cases.
A decompiler only gives an approximation of the original source code because much of that is not stored in the final SWF file.

In this case, it is totally a benign warning that could be ignored, but we will make a simple change to make the compiler stop complaining.
Make the following edits to these class files.

**MessageBoxButtonList.as, Line 41**
```as
_loc6_ = GetClipByIndex(_loc3_) as MessageBoxButtonEntry
if(_loc6_)
```

**Shared\AS3\BSScrollingList.as, Line 658**
```as
_loc7_ = this.GetClipByIndex(_loc5_)
if(_loc7_)
```

**Shared\AS3\BSScrollingList.as, Line 677**
```as
_loc8_ = this.GetClipByIndex(this.iListItemsShown)
if(_loc8_)
```


Press the keyboard shortcut `ALT + SHIFT + F12` to publish your document.
We no longer have any errors or warnings.


Though we still have one final message in the **Output** panel which says the following.

**Output**
```
Fonts should be embedded for any text that may be edited at runtime, other than text with the "Use Device Fonts" setting.
Use the Text > Font Embedding command to embed fonts.
```


### Font Imports
Our menu has almost reached a functional state.
The last task will be repairing the font resource linkage pointing to the shared `fonts_en.swf`.
This fonts library contains all the fonts used by the game and is read by each menu at runtime.

The `TextField` types in our Flash document will not be able to render text properly without either re-linking the runtime shared library (RSL) information for `fonts_en.swf`, or by directly embedding fonts into our menu.
We will be loading our fonts from `fonts_en.swf` as the vanilla menu does.

**TODO:** Link to the font topic which describes the font embed values to use.

Now that the fonts are setup correctly for runtime sharing we must tell each of our `TextField` instances to use this imported font instead of a system installed font.
Your system installed fonts are not accessible by the game and will render as vertical rectangles if you do not change the font.


### TextField Fonts
There are two `TextField` types on this menu which need to be updated.
- Symbol 4: `textField`, with `MessageBoxButtonEntry`, and `$MAIN_Font_Bold`
- Symbol 13: `Body_tf`, with `MessageBoxMenu`, and `$MAIN_Font`

Once you have updated the font used by each `TextField` you will have successfully restored the source files for the vanilla `MessageBoxMenu`.
Well done!