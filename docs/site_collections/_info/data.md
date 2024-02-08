---
title: "Site.Data"
layout: wiki/page
---

#### Jekyll Documentation
- <https://jekyllrb.com/docs/datafiles/>


<h3>site.data.ck_objects</h3>
<li>size: {{ site.data.ck_objects.size }}</li>
<ul>
{%- for value in site.data.ck_objects -%}
  <li>Name: <code>{{ value.type }}</code></li>
{%- endfor -%}
</ul>

<h3>site.data.papyrus_objects</h3>
<li>size: {{ site.data.papyrus_objects.size }}</li>
<ul>
{%- for value in site.data.papyrus_objects -%}
  <li>name: <code>{{ value.name }}</code></li>
{%- endfor -%}
</ul>
