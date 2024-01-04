---
title: "Link Test"
---

The Liquid syntax for internal links is verified at build time.


## External Links
- Text Link: https://github.com/Scrivener07
- Hyper Link: <https://github.com/Scrivener07>
- Masked Link: [Scrivener07 on GitHub.com](https://github.com/Scrivener07)


## Markdown: Internal Link: Rooted
- [Wiki](/wiki/)
- - [Fallout 4](/wiki/fo4/)
- - - [Interface](/wiki/fo4/interface/)
- - - - [Tooling](/wiki/fo4/interface/tooling.md)
- - - - - [Reference](/wiki/fo4/interface/reference/)
- - [Skyrim](/wiki/tes5/)
- - - [Interface](/wiki/tes5/interface/)
- - - - [Topics](/wiki/tes5/interface/topics/)


## Markdown: Internal Link: Relative
- [Wiki](../wiki/)
- - [Fallout 4](../wiki/fo4/)
- - - [Interface](../wiki/fo4/interface/)
- - - - [Tooling](../wiki/fo4/interface/tooling.md)
- - - - - [Reference](../wiki/fo4/interface/reference/)
- - [Skyrim](../wiki/tes5/)
- - - [Interface](../wiki/tes5/interface/)
- - - - [Topics](../wiki/tes5/interface/topics/)


## Liquid: Internal Link
- [Wiki]({{ site.baseurl }}{% link wiki/index.md %})
- - [Fallout 4]({{ site.baseurl }}{% link wiki/fo4/index.md %})
- - - [Interface]({{ site.baseurl }}{% link wiki/fo4/interface/index.md %})
- - - - [Tooling]({{ site.baseurl }}{% link wiki/fo4/interface/tooling.md %})
- - - - - [Reference]({{ site.baseurl }}{% link wiki/fo4/interface/reference/index.md %})
- - [Skyrim]({{ site.baseurl }}{% link wiki/tes5/index.md %})
- - - [Interface]({{ site.baseurl }}{% link wiki/tes5/interface/index.md %})
- - - - [Topics]({{ site.baseurl }}{% link wiki/tes5/interface/topics/index.md %})
