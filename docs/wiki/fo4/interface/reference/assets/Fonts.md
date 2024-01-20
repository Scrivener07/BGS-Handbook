# Fonts
This section provides details for the font libraries used by Fallout 4.

### Tools
- [Font Forge](https://fontforge.github.io/en-US/) & [Font Forge - Common Problems](https://fontforge.github.io/problems.html)




# Font Libraries
The fonts displayed in game are stored in a font library.
These font libraries are shared between menus during runtime.
The current font configuration can be found in `Fallout 4\Data\Interface\FontConfig.txt`

#### True Type Fonts
Some of the fonts can be downloaded for free off the internet.
- [Arial](https://docs.microsoft.com/en-us/typography/font-list/arial)
- [Courier New](https://docs.microsoft.com/en-us/typography/font-list/courier-new)
- [Roboto Condensed](https://fonts.google.com/specimen/Roboto+Condensed)
- - `RobotoCondensed-Regular.ttf`
- - `RobotoCondensed-Bold.ttf`

#### Embedded Fonts
- `Adventure.ttf`
- `Press Start 2P.ttf`
- `vir2L_Medium.ttf`


#### Font Information
The imported class name should be one of these class names.
A leading `$` is a valid AS3 identifier.
For example, we would use `$MAIN_Font` with an RSL path to `font_en.swf` as the font name.

<https://github.com/F4CF/Interface/tree/master/Data/Interface/Source/Bethesda/Shared/Fonts>


# Fonts
The fonts displayed in game are stored in a *Flash File* font library.
These font libraries are shared between menus during runtime.
The current font configuration can be found in `Fallout 4\Data\Interface\FontConfig.txt`.

| Class                          | Family                       | Style  | File                           |
|--------------------------------|------------------------------|--------|--------------------------------|
| `$MAIN_Font`                   | Roboto Condensed             | Normal | `Interface\fonts_en.swf`       |
| `$MAIN_Font_Bold`              | Roboto Condensed             | Bold   | `Interface\fonts_en.swf`       |
| `$HandwrittenFont`             | Handwritten_Institute        | Normal | `Interface\fonts_en.swf`       |
| `$BRODY`                       | Brody                        | Bold   | `Interface\fonts_en.swf`       |
| `$Terminal_Font`               | Share-TechMono               | Normal | `Interface\fonts_en.swf`       |
| `$Controller_Buttons`          | Controller  Buttons          | Normal | `Interface\fonts_en.swf`       |
| `$Controller_Buttons_inverted` | Controller  Buttons inverted | Normal | `Interface\fonts_en.swf`       |
| `$CClub_Font`                  | Eurostile LT Std Roman       | Roman  | `Interface\fonts_en.swf`       |
| `$CClub_Font_Bold`             | Eurostile Cyr Std Bold       | Demi   | `Interface\fonts_en.swf`       |
| `$ConsoleFont`                 | Arial                        | Normal | `Interface\fonts_console.swf`  |
| `$DebugTextFont`               | Consolas                     | Normal | `Interface\fonts_console.swf`  |
| `$Terminal_Font`               | Share-TechMono               | Normal | `Programs\fonts_programs.swf`  |
| `$AtomicCommand_HUD`           | vir2L_Medium                 |        | `Programs\fonts_programs.swf`  |
| `$Grognak`                     | Press Start 2P               |        | `Programs\fonts_programs.swf`  |
| `$PipFallHUD`                  | vir2L_Medium                 |        | `Programs\fonts_programs.swf`  |
| `$PipFallSplashScreen`         | Adventure                    |        | `Programs\fonts_programs.swf`  |


# Missing Font Error
An example of a missing font error.
The errors are logged into the `F4SE.log` file.
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

#### **Font: Embedded**
One is to bake the font directly into your swf, by just making a new font in your library window.

#### **Font: Authortime Shared Library (ASL)**
To have your fonts loaded from a separate **FLA** file as a library with ASL (authortime shared library).
In this mode, the FLA is statically baked into the user assembly (SWF).

#### **Font: Runtime Shared Library (RSL)**
To have your fonts loaded from a separate **FLA** file as a library with RSL (runtime shared library).
In this mode, the font library produces its own SWF, and is runtime loaded by the user SWF when the menu loads.



### OS Installed Editor Fonts
Keep in mind that the *editor view* usings the fonts installed to your OS.
The game on the other hand will only be able to use embedded or linked fonts.
The editor cannot always determine the runtime loaded font as a preview in the editor, so a substitute font is prompted for when you open some files, as you may have seen.
If you want the editor preview to match the game view of fonts, you must install the game fonts to your OS. This is easy as system installable fonts are an extractable resource from SWF.

These are the actual fonts which can be installed to your OS.
- <https://github.com/F4CF/Interface/tree/master/Data/Interface/Source/Bethesda/Shared/Fonts/Resources>



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



# Adobe Font Issue
I am running Windows 10 with the latest Adobe Animate.
I do not have my font library SWF's embedded fonts installed to my Windows operation system.

The current Adobe Animate, and previous available versions, will all incorrectly write the font-class data of a TextField when publishing a SWF file.
This happens if your Font library symbol is imported for runtime sharing (RSL) via an ActionScript linkage identifier.

These fonts are embedded in the other SWF that is used for RSL.
The font library exports the embedded fonts for RSL via AS3 class linkage identifiers.
Im including the actual class names here because there might be a clue into the bug going by the `$BRODY` symbol that Animate writes to every single TextField no matter what.
More on that in a moment.

```
$BRODY
$CClub_Font
$CClub_Font_Bold
$ConsoleFont
$Controller_Buttons
$Controller_Buttons_inverted
$HandwrittenFont
$MAIN_Font
$MAIN_Font_Bold
$Terminal_Font
```

Now as I sure the fine folks at Adobe know, when your Flash document is using RSL fonts, they are populated into the font selection dropdown of a TextField.
There is a special grouped section you will find your RSL fonts, and each of them will be suffixed with an * character.
Now lets say I have a 10 TextFields for each of the above fonts.
If I publish my Flash document to SWF and run it, ALL of the TextFields will be using the `$BRODY` font-class, which does correctly load and display the Brody font for all of them.

The latest versions definitely publish SWF files with incorrect font data.
I verified this by inspecting the SWF data in FFDec which is a community made SWF assembly inspection tool.

If I have a textfield with the font-class `$MAIN_Font`, `$MAIN_Font_Bold`, `$HandwrittenFont`, or anything, then Adobe Animate will ignore that and publish every textfield with `$BRODY` no matter what.
Maybe because it is alphabetically the first RSL font listed in the Adobe Animate editor?

Further testing showed that if I use FFDec to manually edit the SWF by patching the SWF assembly directly, then I can change the incorrect `$BRODY` font-class to the correct class identifier and it works.
I haven't inspected to see if other font properties are corrupted, but its a possibility.


As a secondary issue, while using the Adobe Animate editor, it will constantly reset the chosen font of my TextFields to "Times New Roman".
You can reproduce this by setting a TextField to use an RSL, then drag the textfield on the stage to move it slightly and the font is reset again.
This agrees with the other posters here that have issues with non-RSL fonts.

This is a major issue on large projects with lots of embedded fonts.


### Solution
It appears that this problem can be avoided by having the fonts in question installed to your operating system.
Though the controller button inverted font has been problematic.
