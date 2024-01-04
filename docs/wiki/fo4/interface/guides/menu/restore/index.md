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

We might want to do this if we want to add or modify the functionality or visuals or an existing menu for which you do not have the source files.
To demonstrate the process we will restore and modify `MessageBoxMenu.swf` menu.
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

### Fixing the errors
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
When setting the *Output name* for your Flash document, be sure to always use a relative path.
Do not use a full path with a drive letter on the front.

For this menu, use an *Output name* of `../../MessageBoxMenu` which will put the file two directories above its current directory.
Or in others words, two folders above relative to itself.
You can delete the stray `MessageBoxMenu.swf` and `MessageBoxMenu.html` that may have ended up in your `Fallout 4\Data\Interface\Source\MessageMarkdown\` folder from our first publish attempt.
The game will only consider the `Fallout 4\Data\Interface\MessageBoxMenu.swf` path for archive override replacers.

Now click the **ActionScript Settings** button which is the small wrench icon.
On the *ActionScript Settings*, disable the *Automatically declare stage instances* option.
Press *Ok* to close the **ActionScript Settings** window, and then press *Ok* again to close the **Publish Settings** windows.

Now again, press the keyboard shortcut `ALT + SHIFT + F12` to publish your document.


### Fixing the warnings
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


### Fixing the fonts
Our menu has almost reached a functional state.
The last task will be repairing the font resource linkage pointing to the shared `fonts_en.swf`.
This fonts library contains all the fonts used by the game and is imported by each menu at runtime.

The `TextField` types in our Flash document will not be able to render text properly without either re-linking the runtime shared library (RSL) information for `fonts_en.swf`, or by directly embedding fonts into our menu.
We will be loading our fonts from `fonts_en.swf` as the vanilla menu does.

**TODO: Link to the font topic which describes the font embed values to use.**

Now that the fonts are setup correctly for runtime sharing we must tell each of our `TextField` instances to use this imported font instead of a system installed font.
Your system installed fonts are not accessible by the game and will render as vertical rectangles if you do not change the font.

There are two `TextField` types on this menu which need to be updated.
- Symbol 4: `textField`, with `MessageBoxButtonEntry`, and `$MAIN_Font_Bold`
- Symbol 13: `Body_tf`, with `MessageBoxMenu`, and `$MAIN_Font`

Once you have updated the font used by each `TextField` you will have successfully restored the source files for the vanilla `MessageBoxMenu`.
Well done!


### Organizing the library objects.
Organizing the library objects and layers is not critical to the functionality of the menu, but you will be happier for it.
Consider this optional suggestions.
- Rename each layer to match the stage instance name.
- - If the layer holds a `Shape`, name the layer "Shape" or "Foo Shape".
- - If the layer holds a `Graphic` name it "Graphic" or "Foo Graphic".
- - Lock every layer you are not actively editing to avoid wild or dirty edits. Relock the layer when done editing.
- Give all library symbols meaningful names. If a library object has class linkage, use that as the library object name.


### Testing the menu in-game
So far the objective has been to restore the source files for the `MessageBoxMenu` for the purpose of republishing a visually and functionally identical to the vanilla menu.
This gives our project a starting point for customizations.
A challenge for testing such a thing in game is that if our new `MessageBoxMenu.swf` is visually and functionally identical to the vanilla menu then its hard to tell if its working or not.

To make the in-game test exciting, go to the root stage and add a new topmost layer.
On the Adobe Animate **Tools** strip, select some of the shape, pencil, or brush tools and go crazy scribbling on top of the menu to make it obvious our version of the menu is running.
Press the keyboard shortcut `ALT + SHIFT + F12` to publish your document.

Start Fallout 4 and `COC` into your favorite test cell.
Once the game has finished loading it will be time to test our progress.
Open the message box menu in Fallout 4 by executing this console command.

```
CFG "Debug.MessageBox" "Hello World!"
```

It works, amazing!
Now, without exiting Fallout 4, switch your focus back to Adobe Animate and delete the silly test layer.
Republish your menu and switch your focus back to Fallout 4.
Re-execute the previous console command and see that the game is capable of hot-reloading non-persisted game menus.

With that, this tutorial is concluded.
Check out the guides and tutorials for more advanced topics.


## Notes
These are some additional notes on topics covered here.

### Flash Hot-Reloading
Hot-reloading does not work on every menu such as the HUD menu.
This is because persisted menus like the HUD are loaded once per game session, and then stay alive for the remainder.
If you are developing a persisted menu then the SWF your started the game with will be baked into the remainder of that game session.
This simply means you only need to restart the game to test changes to your menu, so no hot-reloading for these.


### Using COC from the main menu
If you use the developer console to execute the `COC` (center-on-cell) command from the Fallout 4 main menu, then take caution.
Keep in mind that doing this will not initialize the game into a fully playable state.
Regardless, using the `COC` command from the main menu is a useful testing technique for developers.

If you use `COC` from the main menu then be aware of the following limitations.

**Broken quests:**
Many storyline and game system related quests will not properly start.

**Broken interior cell path finding:**
The AI path finding system for navmeshes will be non-functional if you `COC` directly to an interior cell.
Actors will refuse to move.
The game uses the the transition from an interior cell to an exterior as a signal to begin normal game startup.
There are still more problems with `COC` from the main menu, but these examples get the point across well enough.

#### Skyrim main menu notes
In Skyrim, Bethesda literally let the cell void be fully visible at the main menu!

It features a 3D mesh of the Skyrim logo, a light source, and a mist effect all dangling in front of the player camera.
Yea, the *Player* is loaded at the main menu too.
You can even execute console commands on your own *Player* reference.

The main menu cell in Skyrim.
The only thing you will see in the Creation Kit is a `COCMarkerHeading`.

Instead, look at default object manager in the Creation Kit and you can see that the "Use" property called `Main Menu Cell` that binds to the `MainMenuCell` EditorID, which is the `Cell`.
Default objects are special properties that the Creation Kit exposes directly to the game engine for use.
This explains some of the magic behind some objects having unexplained or special behavior.
The engine probably uses this default object property to register for cell transition events to trigger game startup.

- Default Object: `Main Menu Cell` :: `MainMenuCell`
- Cell EditorID: `MainMenuCell`
- Cell Name: `Main Menu Cell`
