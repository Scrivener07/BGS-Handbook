---
title: "Site.Collections"
---

#### Jekyll Documentation
- <https://jekyllrb.com/docs/collections/>


<h3>site.collections</h3>
<li>size: {{ site.collections.size }}</li>
<ul>
  {%- for collection in site.collections -%}
  <li>{{ collection.label }}
    <ul>
      <li>label: {{ collection.label }}</li>
      <li>docs: {{ collection.docs.size }}</li>
      <li>files: {{ collection.files.size }}</li>
      <li>relative_directory: {{ collection.relative_directory }}</li>
      <li>directory: {{ collection.directory }}</li>
      <li>output: {{ collection.output }}</li>
    </ul>
  </li>
  {%- endfor -%}
</ul>


<h3>site.info ({{ site.info.size }})</h3>
<ul>
{%- for value in site.info -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h3>site.wiki ({{ site.wiki.size }})</h3>
<ul>
{%- for value in site.wiki -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h3>site.wiki_objects_ck ({{ site.wiki_objects_ck.size }})</h3>
<ul>
{%- for value in site.wiki_objects_ck -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h3>site.wiki_objects_papyrus ({{ site.wiki_objects_papyrus.size }})</h3>
<ul>
{%- for value in site.wiki_objects_papyrus -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h3>site.wiki_ui_scaleform ({{ site.wiki_ui_scaleform.size }})</h3>
<ul>
{%- for value in site.wiki_ui_scaleform -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h3>site.wiki_ui_shared ({{ site.wiki_ui_shared.size }})</h3>
<ul>
{%- for value in site.wiki_ui_shared -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h3>site.wiki_ui_menus ({{ site.wiki_ui_menus.size }})</h3>
<ul>
{%- for value in site.wiki_ui_menus -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>
