---
title: "Site.Layouts: Data Object"
categories: layouts
---

<h2>Collection: wiki_objects_ck ({{ site.wiki_objects_ck.size }})</h2>
<ul>
{%- for value in site.wiki_objects_ck -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h2>Collection: wiki_objects_papyrus ({{ site.wiki_objects_papyrus.size }})</h2>
<ul>
{%- for value in site.wiki_objects_papyrus -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a> : <code>{{ value.url }}</code></li>
{%- endfor -%}
</ul>

{%- assign icons = site.static_files | where: "category", "ck:object:icon" -%}
<h2>Static Files: Creation Kit Object Icons ({{ icons.size }})</h2>
<ul>
{%- for file in icons -%}
  <li>{{ file.basename }} : <img src="{{ site.baseurl }}{{ file.path | default: '/assets/object_icon/default.png' }}" alt="File"> : <code>{{ file.path }}</code></li>
{%- endfor -%}
</ul>
