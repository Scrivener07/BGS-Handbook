---
title: "Link Test"
---

### Internal Link Test (Liquid link)
These all work locally.

None of these work on the remote as they are missing the `site.baseurl`.

Ex: https://scrivener07.github.io/wiki/fo4/interface/tooling.html is 404

- [Wiki]({% link wiki/index.md %})
- [Wiki: Fallout 4]({% link wiki/fo4/index.md %})
- [Wiki: Fallout 4: Interface]({% link wiki/fo4/interface/index.md %})
- [Wiki: Fallout 4: Interface: Tooling]({% link wiki/fo4/interface/tooling.md %})
- [Wiki: Fallout 4: Interface: Reference]({% link wiki/fo4/interface/reference/index.md %})


### Internal Link Test (Liquid link with prefix site.baseurl)
These all work locally.

These all work remotely.

- [Wiki]({{ site.baseurl }}{% link wiki/index.md %})
- [Wiki: Fallout 4]({{ site.baseurl }}{% link wiki/fo4/index.md %})
- [Wiki: Fallout 4: Interface]({{ site.baseurl }}{% link wiki/fo4/interface/index.md %})
- [Wiki: Fallout 4: Interface: Tooling]({{ site.baseurl }}{% link wiki/fo4/interface/tooling.md %})
- [Wiki: Fallout 4: Interface: Reference]({{ site.baseurl }}{% link wiki/fo4/interface/reference/index.md %})


### Internal Link Test (rooted markdown)
These all work locally except for the 'fo4' category page.

These all work remotely except for the 'fo4' category page.

- [Wiki](/wiki/index.md)
- [Wiki: Fallout 4](/wiki/fo4/index.md})  (This locally links to http://localhost:4000/wiki/fo4/index.md%7D which is 404)
- [Wiki: Fallout 4: Interface](/wiki/fo4/interface/index.md)
- [Wiki: Fallout 4: Interface: Tooling](/wiki/fo4/interface/tooling.md)
- [Wiki: Fallout 4: Interface: Reference](/wiki/fo4/interface/reference/index.md)


### Internal Link Test (relative markdown)
These all work locally except for the 'fo4' category page.

These all work remotely except for the 'fo4' category page.

- [Wiki](wiki/index.md)
- [Wiki: Fallout 4](wiki/fo4/index.md})  (This locally links to http://localhost:4000/wiki/fo4/index.md%7D which is 404)
- [Wiki: Fallout 4: Interface](wiki/fo4/interface/index.md)
- [Wiki: Fallout 4: Interface: Tooling](wiki/fo4/interface/tooling.md)
- [Wiki: Fallout 4: Interface: Reference](wiki/fo4/interface/reference/index.md)
