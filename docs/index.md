---
# Feel free to add content and custom Front Matter to this file.
# To modify the layout, see https://jekyllrb.com/docs/themes/#overriding-theme-defaults
layout: home
title: "Home"
---

<h2>Data: ck_objects ({{ site.data.ck_objects.size }})</h2>
<ul>
{%- for value in site.data.ck_objects -%}
  <li>Name: <code>{{ value.type }}</code></li>
{%- endfor -%}
</ul>

<h2>Data: papyrus_objects ({{ site.data.papyrus_objects.size }})</h2>
<ul>
{%- for value in site.data.papyrus_objects -%}
  <li>Name: <code>{{ value.name }}</code></li>
{%- endfor -%}
</ul>

<h2>Collection: wiki_objects_ck ({{ site.wiki_objects_ck.size }})</h2>
<ul>
{%- for value in site.wiki_objects_ck -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h2>Collection: site_debug ({{ site.site_debug.size }})</h2>
<ul>
{%- for value in site.site_debug -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h2>Collection: wiki_objects_papyrus ({{ site.wiki_objects_papyrus.size }})</h2>
<ul>
{%- for value in site.wiki_objects_papyrus -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h2>Collection: wiki ({{ site.wiki.size }})</h2>
<ul>
{%- for value in site.wiki -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>


<h2>Static Files ({{ site.static_files.size }})</h2>
<ul>
{%- for file in site.static_files -%}
  <li>{{ file.basename }} : <code>{{ file.path }}</code></li>
{%- endfor -%}
</ul>
