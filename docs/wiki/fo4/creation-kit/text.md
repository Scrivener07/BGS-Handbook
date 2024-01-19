---
title: "Text"
---


### See Also
- [Fonts](/wiki/fo4/interface/reference/assets/Fonts)
- [MessageBoxMenu](/wiki/fo4/interface/reference/menus/messagebox)
- [BookMenu](/wiki/fo4/interface/reference/menus/book)


### Creation Kit
- <https://falloutck.uesp.net/wiki/Message>
- <https://falloutck.uesp.net/wiki/Message_Script>
- <https://falloutck.uesp.net/wiki/MessageBox_-_Debug>
- <https://falloutck.uesp.net/wiki/Text_Replacement>
- <https://falloutck.uesp.net/wiki/Button_Tag_Replacement>


## Text: Replacement Tags
The **Text Replacement** game system parses value tokens and formatting tags.
This is used on a several forms like [Books](/wiki/fo4/creation-kit/objects/book) and [[Terminal]]s.

## Tokens
Quest-associated books can contain tokens used for **Text Replacement** if you add a book alias to the quest and set "Uses Stored Text" flag on this alias.

## Markup
Some text fields support a variety of **Markup** tags used with formatting.

### Example
```html
<!--This is the example for text markup-->
<font face='$HandwrittenFont' size='35'>Hello World!</font>
<b><i><u>This is bold, italic, and underlined.</u></i></b>
<BR>These are some colors I like.
<ul>
<li>Black</li>
<li>White</li>
<li>Red</li>
<li>Green</li>
<li>Blue</li>
</ul>
[pagebreak]
<!--A new page has starts here-->
<p align='center'>My center aligned text.
<p align='left'>My left aligned text.
```


### Example
```html
<P ALIGN="LEFT">
<FONT FACE="Normal" SIZE="12" COLOR="#000000" LETTERSPACING="0" KERNING="0">
    <i>Lorem ipsum</i>
</FONT>
<FONT FACE="Title" SIZE="14" COLOR="#2010ff" LETTERSPACING="0" KERNING="0">dolor sit amet.</FONT>
</P>
```


### Syntax


## Comment Tag
- Tag: `&lt;!--Comment text--&gt;`
Comments tell the renderer not display the text wrapped within the tags while still retaining the text in the editor.


## Bold Tag
- Tag: `<b></b>`
Text surrounded by bold tags will be **bolded**.


## Italic Tag
- Tag: `<i></i>`
Text surrounded by italics tags will be *italicized*.


## Underline Tag
- Tag: `<u></u>`
Text surrounded by underline tags will be `<u>underlined</u>`.


## List Tag
- Tag: `<ul><li>ITEM 1</li><li>ITEM 2</li></ul>`
Creates list items with an empty square for the icon.
Each list item is indented and separated by an empty line.

Example:
```html
<ul>
    <li>Red</li>
    <li>Green</li>
    <li>Blue</li>
</ul>
```


## Line-Break Tag
- Tag: `<br>`
Breaks the text to the next line.
Strictly speaking, this tag isn't necessary.
You can just as easily add blank lines to the book text.


## Page-Break
- Tag: `[pagebreak]`
Breaks to the next page.
Must be on its own line.
Text automatically breaks to the next page once it reaches the end.

Note: images do not, so if you notice your images running off the edge of the page, manually place a page-break or reduce the size of your image.



## Paragraph Tag
- Tag: `<p>`
Aligns and delineates a block of text as a paragraph.

**Alignment**
- Tag: `<p align='center'>`
Aligns the surrounded text.  Valid values are 'left', 'right', 'justify', 'center'.

Note: If you want to place an image within some text so that it wraps around it, the text containing the image needs to be within paragraph tags.





## Font Tags
- Tag: `<font>`
Changes the font attributes of the surrounded text.

**Color**
- Tag: `<font color='#FFFFFF'></font>`
Changes the font's color.

**Face**
- Tag: `<font face='$HandwrittenFont'></font>`
Changes the typeface of the font. See the fonts section for valid typeface names.

**Point Size**
- Tag: `<font size='20'></font>`
Changes the font size. See below for the line lengths you can accommodate using different font sizes.

**Alpha**
- Tag: `<font alpha='#FF'></font>`
Changes the font's transparency. Two-digit hexadecimal values from `'#00'` (fully transparent) through `'#FF'` (fully opaque) are supported.




## Image tags
Places an image on the page.

Tag:
```html
<img>
```


**Source Filename**
This attribute specifies the filename of the image you want to show up.
You need to use the texture path to an image.
Make sure the filename begins with `img://`.

Tag:
```html
<img src='img://example.dds'>
```

**Height and Width**
Sets the height and width of the image in pixels.

Tag:
```html
<img src='example.dds' height='40' width='40'>
```

**Illuminated Letters**
Used for adding special illuminated letters at the beginning of books.
Replace the "X" with any letter or number.

Tag:
```html
<img src='img://Textures/Interface/Books/Illuminated_Letters/X_letter.png'>
```


# Fonts
The fonts displayed in game are stored in a [[Flash File]] font library.
These font libraries are shared between menus during runtime.
The current font configuration can be found in ''`Fallout 4\Data\Interface\FontConfig.txt`''

#### **Library:** Interface\fonts_en.swf
Example of the main Fallout 4 font
- **Font Class:** $MAIN_Font
- **Font Family:** Roboto Condensed
- **Font Style:** Normal

#### **Library:** Interface\fonts_en.swf
Example of the main Fallout 4 font, bolded.
- **Font Class:** $MAIN_Font_Bold
- **Font Family:** Roboto Condensed
- **Font Style:** Bold

#### **Library:** Interface\fonts_en.swf
Example of the handwritten font in Fallout 4
- **Font Class:** $HandwrittenFont
- **Font Family:** Handwritten_Institute
- **Font Style:** Normal

#### **Library:** Interface\fonts_en.swf
Example of the Brody font in Fallout 4.
- **Font Class:** $BRODY
- **Font Family:** "Brody"
- **Font Style:** Bold

#### **Library:** Interface\fonts_en.swf
Example of the terminal font in Fallout 4.
- **Font Class:** $Terminal_Font
- **Font Family:** Share-TechMono
- **Font Style:** Normal

#### **Library:** Interface\fonts_en.swf
- **Font Class:** $Controller_Buttons
- **Font Family:** Controller  Buttons
- **Font Style:** Normal

#### **Library:** Interface\fonts_en.swf
- **Font Class:** $Controller_Buttons_inverted
- **Font Family:** Controller  Buttons inverted
- **Font Style:** Normal

#### **Library:** Interface\fonts_en.swf
- **Font Class:** $CClub_Font
- **Font Family:** Eurostile LT Std Roman
- **Font Style:** None

#### **Library:** Interface\fonts_en.swf
- **Font Class:** $CClub_Font_Bold
- **Font Family:** Eurostile Cyr Std Bold
- **Font Style:** None

#### **Library:** Interface\fonts_console.swf
Example of the console font in Fallout 4
- **Font Class:** $ConsoleFont
- **Font Family:** Arial
- **Font Style:** Normal

#### **Library:** Interface\fonts_console.swf
Example of the console debug font in Fallout 4
- **Font Class:** $DebugTextFont
- **Font Family:** Consolas
- **Font Style:** Normal


# Sample Book Text
Sample `Book` text with tag replacement.

```html
<font face='$MAIN_Font' size='24'>
    <p align='center'>
        <b>The Treasures of Jamaica Plain</b>
    </p>
</font>

<font face='$MAIN_Font' size='18'>
    <p align='center'>October 17-23nd, 2077 8am-5pm Daily</p>
</font>

<font face='$MAIN_Font' size='18'>
Come and see the fabulous Treasures of Jamaica Plain!
This stunning exhibit will be on display for one week only before these priceless items are sealed away, never to be seen again!
Bring the entire family to this once-in-a-lifetime event!
</font>

<font size='18'>Tash - I've been thinking about going after the Treasure. Jesse's game. You in?</font>

<p align='right'>
    <img src='img://Textures/Interface/Note/JamaicaPlain_Seal_d.DDS' height='100' width='100'>
</p>
```

# Sample Book Text
```html
<font face='$MAIN_Font' size='24'><p align='center'><b>The Treasures of Jamaica Plain</b></p></font>

<font face='$MAIN_Font' size='18'>
<p align='center'>October 17-23nd, 2077 8am-5pm Daily</p>
</font>

<font face='$MAIN_Font' size='18'>
Come see the fabulous Treasures of Jamaica Plain!
This stunning exhibit will be on display for one week only before these priceless items are sealed away, never to be seen again!
Bring the entire family to this once-in-a-lifetime event!
</font>

<p align='right'>
    <img src='img://Textures/Interface/Note/JamaicaPlain_Seal_d.DDS' height='100' width='100'>
</p>
```


## Text: HTML Tags
A `TextField` will normally apply the font, color, size, and other properties to the entire text by default.
HTML text can be used to apply formatting to specific parts of the text by using HTML tags.


### Tag `<font>`
The `<font>` tag specifies a font or list of fonts to display the text.

*The font tag supports the following attributes:*
- `color`: Only hexadecimal color (`#FFFFFF`) values are supported.
- `face`: Specifies the name of the font to use.
- `size`: Specifies the size of the font. You can use absolute pixel sizes, such as 16 or 18, or relative point sizes, such as +2 or -4.


### Tag `<p>`
The `<p>` tag creates a new paragraph.
The text field must be set to be a *multiline* text field to use this tag.
The `<p>` tag supports the `'align'` attribute, that specifies alignment of text within the paragraph.

The valid `'align'` values are `left`, `right`, `justify`, and `center`.


### Tag `<b>`
The `<b>` tag renders text as bold.
A bold typeface must be available for the font used.
In terms of `FT2Fontlib.json` it means that particular font must have `"style"` : `"Bold"` mapping entry.


### Tag `<i>`
The `<i>` tag displays the tagged text in italics.
An italic typeface must be available for the font used.
In terms of `FT2Fontlib.json`, it means that particular font must have `"style"` : `"Italic"` mapping entry.


### Tag `<u>`
The `<u>` tag underlines the tagged text.


### Tag `<li>`
The `<li>` tag places a bullet in front of the text that it encloses.



## Papyrus Strings
In practice, Papyrus strings are *case-insensitive* due to the way the game engine's string pool operates for efficiency reasons.
Most strings in the engine come from this same *case-insensitive* string pool, with a few exceptions.
The pool works by caching a unique occurrence of a string whenever one is encountered by the game engine for the first time.
The pool will reuse the cached version of a string for any following occurrences.
This means the distinction between uppercase and lowercase may not exist.

For example, the strings "MyString" and "mYsTrInG" are technically equivalent.
Which string is used depends on which version of the string is encountered by the game engine first.
The game's load order has an influence on this, among other things.
Following the example, if "mYsTrInG" is cached first then any following occurrence of "mystring" will always be "mYsTrInG".

This is potentially a problem for some game systems which require a **case-sensitive** string.

##### **Workarounds**
In general the workaround to creating a string with any preferred casing would be to use a pseudo uniqueness.
For example the string "raider" is cached but you want "Raider".
You can use a pseudo uniqueness by prefixing or suffixing the string with a space character (" ").

Sticking with the example, the user would be none the wiser if you used "Raider " for UI purposes.
This is not a suitable workaround for all cases.
For other cases you should make your strings more unique if possible.

##### **Notes**
- The game engine internally uses a data structure called `BSFixedString` for handling string data.
- Localized strings, internally `BGSLocalizedString`, are also vulnerable to string pool limitations.
- [UI Script](https://falloutck.uesp.net/wiki/UI_Script) function calls to Scaleform are affected by this string casing limitation.
- [Initialization File](https://falloutck.uesp.net/wiki/Initialization_File) related function calls are affected by this string casing limitation.
