# Fonts
This section provides details for the font libraries used by Fallout 4.

### Tools
- [Font Forge](https://fontforge.github.io/en-US/) & [Font Forge - Common Problems](https://fontforge.github.io/problems.html)


#### Font Symbol Mappings
```
map "$HandwrittenFont" = "Handwritten_Institute" Normal
map "$MAIN_Font" = "Roboto Condensed" Normal
map "$MAIN_Font_Bold" = "Roboto Condensed" Bold
map "$Terminal_Font" = "Share-TechMono" Normal
map "$Controller_Buttons" = "Controller  Buttons" Normal
map "$Controller_Buttons_inverted" = "Controller  Buttons inverted" Normal
map "$ConsoleFont" = "Arial" Normal
map "$DebugTextFont" = "Consolas" Normal
map "$BRODY" = "Brody" Bold
map "$CClub_Font" = "Eurostile LT Std" Roman
map "$CClub_Font_Bold" = "Eurostile LT Std" Demi
```


# Font Libraries
The fonts displayed in game are stored in a font library.
These font libraries are shared between menus during runtime.
The current font configuration can be found in `Fallout 4\Data\Interface\FontConfig.txt`

#### True Type Fonts
* [Arial](https://docs.microsoft.com/en-us/typography/font-list/arial)
* [Courier New](https://docs.microsoft.com/en-us/typography/font-list/courier-new)
* [Roboto](https://fonts.google.com/specimen/Roboto)

#### Embedded Fonts
* `Adventure.ttf`
* `Press Start 2P.ttf`
* `vir2L_Medium.ttf`


#### Font Information

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $MAIN_Font
* * **Font Family:** Roboto Condensed
* * **Font Style:** Normal
<BR>

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $MAIN_Font_Bold
* * **Font Family:** Roboto Condensed
* * **Font Style:** Bold
<BR>

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $HandwrittenFont
* * **Font Family:** Handwritten_Institute
* * **Font Style:** Normal
<BR>

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $BRODY
* * **Font Family:** "Brody"
* * **Font Style:** Bold
<BR>

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $Terminal_Font
* * **Font Family:** Share-TechMono
* * **Font Style:** Normal
<BR>

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $Controller_Buttons
* * **Font Family:** Controller  Buttons
* * **Font Style:** Normal
<BR>

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $Controller_Buttons_inverted
* * **Font Family:** Controller  Buttons inverted
* * **Font Style:** Normal
<BR>

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $CClub_Font
* * **Font Family:** Eurostile LT Std Roman
* * **Font Style:** None
<BR>

* **Library:** Interface\fonts_en.swf
* * **Font Class:** $CClub_Font_Bold
* * **Font Family:** Eurostile Cyr Std Bold
* * **Font Style:** None
<BR>

* **Library:** Interface\fonts_console.swf
* * **Font Class:** $ConsoleFont
* * **Font Family:** Arial
* * **Font Style:** Normal
<BR>

* **Library:** Interface\fonts_console.swf
* * **Font Class:** $DebugTextFont
* * **Font Family:** Consolas
* * **Font Style:** Normal
<BR>


# Missing Font Error
An example of a missing font error.
The errors are logged into the F4SE.log file.
```
Missing font "Times New Roman" in ".root1.Menu_mc.CreditsContainer.instance18". Search log:
   Searching for font: "Times New Roman" [Device]
      Movie resource: "Times New Roman" [Device] not found.
      Imports       : "Times New Roman" [Device] not found.
      Exported      : "Times New Roman" [Device] not found.
      Registered fonts: "Times New Roman"[Device] not found.
      Searching FontLib: "Times New Roman" [Device] not found.
      Searching FontLib without [Device] flag: "Times New Roman"  not found.
      Searching again without [Device] flag:
         Movie resource: "Times New Roman"  not found.
         Imports       : "Times New Roman"  not found.
         Exported      : "Times New Roman"  not found.
         Registered fonts: "Times New Roman" not found.
   Font not found.
```


# Flash: Fonts
There are three methods for loading fonts.
The last option is how the game works, and is preferable.

**Font: Embedded** </BR>
One is to bake the font directly into your swf, by just making a new font in your library window.

**Font: Authortime Shared Library (ASL)** </BR>
To have your fonts loaded from a separate **FLA** file as a library with ASL (authortime shared library).
In this mode, the FLA is statically baked into the user assembly (SWF).

**Font: Runtime Shared Library (RSL)** </BR>
To have your fonts loaded from a separate **FLA** file as a library with RSL (runtime shared library).
In this mode, the font library produces its own SWF, and is runtime loaded by the user SWF when the menu loads.



### OS Installed Editor Fonts
Keep in mind that the *editor view* usings the fonts installed to your OS.
The game on the other hand will only be able to use embedded or linked fonts.
The editor cannot always determine the runtime loaded font as a preview in the editor, so a substitute font is prompted for when you open some files, as you may have seen.
If you want the editor preview to match the game view of fonts, you must install the game fonts to your OS. This is easy as system installable fonts are an extractable resource from SWF.

These are the actual fonts which can be installed to your OS.
- https://github.com/F4CF/Interface/tree/master/Data/Interface/Source/Bethesda/Shared/Fonts/Resources



### Common Problems
A cause of the problem might be that the relative RSL path is not correct.

#### Font was not setup correctly on the textbox
Another problem might be that the textbox itself is not linked to the correct version of the font.
When selecting a textbox and choosing a font, there a two versions of fonts in the list.
There are all the OS installed fonts of course, but we can only use fonts available to the game via the `fonts_en.swf` which is RSL loaded.

In the font list, fonts which are either embedded or imported have a *leading asterisk* in their name.
Make sure each textbox in the whole menu is using the font with a `*` leading the name.


#### Font was not setup correctly in the editor font embedding settings
Another problem might be that the font information was not entered into the Flash Editor correctly.

- possibly wrong class name on imported font symbol
- possibly not imported for runtime sharing
- possibly the font set of available characters was nto enabled



### Diagnostics Editor Scripts
I have an IDE script for tracing diagnostic info about fonts to the editor Output window if it turns out to be a textbox issue.



### Friend Issue
I see, the controller fonts are set up correctly, but the other font is not.

The imported class name should be one of these class names.
A leading `$` is a valid AS3 identifier btw.

https://github.com/F4CF/Interface/tree/master/Data/Interface/Source/Bethesda/Shared/Fonts

So, `$MAIN_Font` as the name instead of `Monofonto`.
Then add the path to `font_en.swf` and the check boxes like the controller font does it.
