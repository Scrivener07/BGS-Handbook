---
# Feel free to add content and custom Front Matter to this file.
# To modify the layout, see https://jekyllrb.com/docs/themes/#overriding-theme-defaults
title: "Site.Theme"
---

## Theme Information
This project uses the [Minima](https://github.com/jekyll/minima) theme.
- **Source:** https://github.com/jekyll/minima
- - **Version:** https://github.com/jekyll/minima/tree/v2.5.1/
- **Preview:** https://jekyll.github.io/minima/
- **Identifier:** `minima`
- **Command:** `bundle info --path minima`

# Theme Demonstration
This is a preview for this site's current theme.

## Text Formatting

Text can be **bold**, _italic_, ~~strike-through~~, <u>underline</u>, and ==highlighted==.

**Note**: Some of these formats (like "highlighted" and "underline") depend on specific CSS rules which may or may not be present in all themes.

## Links
- [Link to home page](/index.md).
- [Link to Microsoft .NET Documentation](https://docs.microsoft.com/en-us/dotnet/).

### External Links
- Text Link: https://github.com/Scrivener07
- Hyper Link: <https://github.com/Scrivener07>
- Masked Link: [Scrivener07 on GitHub.com](https://github.com/Scrivener07)

### Markdown: Internal Link: Rooted
- [Wiki](/wiki/)
- - [Fallout 4](/wiki/fo4/)
- - - [Interface](/wiki/fo4/interface/)
- - - - [Tooling](/wiki/fo4/interface/tooling.md)
- - - - - [Reference](/wiki/fo4/interface/reference/)
- - [Skyrim](/wiki/tes5/)
- - - [Interface](/wiki/tes5/interface/)
- - - - [Topics](/wiki/tes5/interface/topics/)

### Markdown: Internal Link: Relative
- [Wiki](../wiki/)
- - [Fallout 4](../wiki/fo4/)
- - - [Interface](../wiki/fo4/interface/)
- - - - [Tooling](../wiki/fo4/interface/tooling.md)
- - - - - [Reference](../wiki/fo4/interface/reference/)
- - [Skyrim](../wiki/tes5/)
- - - [Interface](../wiki/tes5/interface/)
- - - - [Topics](../wiki/tes5/interface/topics/)

### Liquid: Internal Link
The Liquid syntax for internal links is verified at build time.

- [Wiki]({{ site.baseurl }}{% link _wiki/index.md %})
- - [Fallout 4]({{ site.baseurl }}{% link _wiki/fo4/index.md %})
- - - [Interface]({{ site.baseurl }}{% link _wiki/fo4/interface/index.md %})
- - - - [Tooling]({{ site.baseurl }}{% link _wiki/fo4/interface/tooling.md %})
- - - - - [Reference]({{ site.baseurl }}{% link _wiki/fo4/interface/reference/index.md %})
- - [Skyrim]({{ site.baseurl }}{% link _wiki/tes5/index.md %})
- - - [Interface]({{ site.baseurl }}{% link _wiki/tes5/interface/index.md %})
- - - - [Topics]({{ site.baseurl }}{% link _wiki/tes5/interface/topics/index.md %})

## Paragraphs

There should be whitespace between paragraphs for clarity.

Consider adding a `README` or a file with information about your project for new visitors.

## Headers

# Header 1
## Header 2
### Header 3
#### Header 4
##### Header 5
###### Header 6

## Blockquotes

> "Premature optimization is the root of all evil." - Donald E. Knuth

## Code Highlighting

C#:
```csharp
using System;

namespace ThemeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string name = args.Length > 0 ? args[0] : "World";
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
```


## Lists

### Unordered
* Item A
* Item B
  * Sub-item 1
  * Sub-item 2

### Ordered
1. First
2. Second
3. Third

### Task List
- [x] Completed task
- [ ] Pending task

## Tables

| Title 1       | Title 2       | Title 3 |
|:-------------:|:-------------:|:-------:|
| Cell A1       | Cell A2       | Cell A3 |
| Cell B1       | Cell B2       | Cell B3 |

## Images

Small:
![Octocat](https://github.githubassets.com/images/icons/emoji/octocat.png)

Large:
![Minimal Logo](https://pages-themes.github.io/minimal/assets/img/logo.png)

## Special Tags

<details>
  <summary>Click to expand!</summary>

  This content is hidden by default. It's useful for FAQs or to hide spoilers!
</details>

## Other Elements

### Horizontal Lines
---

### Definition List

<dl>
<dt>Name</dt>
<dd>Godzilla</dd>
<dt>Born</dt>
<dd>1952</dd>
<dt>Birthplace</dt>
<dd>Japan</dd>
</dl>

### Preformatted Text

```
This is preformatted text. It respects both spaces and line breaks.
```


# Image Alignment

You can control the alignment of an image by using HTML within your Markdown:

### Centered Image:
<p align="center">
  <img src="https://pages-themes.github.io/minimal/assets/img/logo.png" alt="Centered image">
</p>

### Left Aligned Image (default):

![Left Aligned Image](https://github.githubassets.com/images/icons/emoji/octocat.png)

### Right Aligned Image:
<p align="right">
  <img src="https://pages-themes.github.io/minimal/assets/img/logo.png" alt="Right aligned image">
</p>

# Inline Code

You can use backticks for `inline code`.

# Embedded Content

Embed a YouTube video by using an iframe:

<iframe width="560" height="315" src="https://www.youtube.com/embed/dQw4w9WgXcQ" frameborder="0" allow="accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>


(Yes, that's the famous Rickroll link!)

# Footnotes

You can create a footnote by using `[^1]` inline and then defining the footnote at the end of your document:

Here's a statement that requires clarification.[^1]

[^1]: This is the clarification for the statement.

# Emoji

GitHub Pages supports emojis! Here are some examples:

- :rocket:
- :octocat:
- :heart:

To use emojis, wrap the emoji code in colons.
You can find a list of available emojis on the [GitHub Emoji page](https://github.com/ikatyang/emoji-cheat-sheet/blob/master/README.md).


# Conclusion
Please note that not all of these features are standard Markdown.
GitHub's variant of Markdown (and some plugins for Jekyll) supports these additions.
Ensure that your Jekyll setup on GitHub Pages can interpret them correctly.
If you're using a local Jekyll setup, ensure the necessary plugins are installed and configured.

Remember, the visual outcome depends on the specific theme's CSS.
Not all Markdown features may display as expected in every theme.
