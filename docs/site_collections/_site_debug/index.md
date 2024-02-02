---
title: "Site"
---

## Site Information
This is the base Jekyll theme.
You can find out more info about customizing your Jekyll theme, as well as basic Jekyll usage documentation at [jekyllrb.com](https://jekyllrb.com/)

You can find the source code for Minima at GitHub:
[jekyll][jekyll-organization] /
[minima](https://github.com/jekyll/minima)

You can find the source code for Jekyll at GitHub:
[jekyll][jekyll-organization] /
[jekyll](https://github.com/jekyll/jekyll)


[jekyll-organization]: https://github.com/jekyll


## Theme Information
This project uses the [Minima](https://github.com/jekyll/minima) theme.
- **Source:** https://github.com/jekyll/minima
- - **Version:** https://github.com/jekyll/minima/tree/v2.5.1/
- **Preview:** https://jekyll.github.io/minima/
- **Identifier:** `minima`
- **Command:** `bundle info --path minima`


### Michael Currin's Nested Jekyll Menus
This project uses components of Michael Currin's *Nested Jekyll Menus*.
- Source: https://github.com/MichaelCurrin/nested-jekyll-menus/
- Found via: https://talk.jekyllrb.com/t/how-to-list-subpages/5051/4


## Site
<b>Debug Pages ({{ site.site_debug.size }})</b>
<ul>
{%- for value in site.site_debug -%}
  <li><a href="{{ value.url }}">{{ value.title}}</a></li>
{%- endfor -%}
</ul>