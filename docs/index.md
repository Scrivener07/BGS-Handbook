---
# Feel free to add content and custom Front Matter to this file.
# To modify the layout, see https://jekyllrb.com/docs/themes/#overriding-theme-defaults
layout: home
title: "Home"
---


<h2>site.posts ({{ site.posts.size }})</h2>
<ul>
{%- for value in site.posts -%}
  <li>{{ value.title }}</li>
{%- endfor -%}
</ul>

<h2>site.categories ({{ site.categories.size }})</h2>
<ul>
  {%- for category in site.categories -%}
    <li>{{ category[0] }} (used by {{ category[1].size }})</li>
  {%- endfor -%}
</ul>

<h2>site.tags ({{ site.tags.size }})</h2>
<ul>
  {%- for tag in site.tags -%}
    <li>{{ tag[0] }} (used by {{ tag[1].size }})</li>
  {%- endfor -%}
</ul>

<hr>

<h2>site.data.ck_objects ({{ site.data.ck_objects.size }})</h2>
<ul>
{%- for value in site.data.ck_objects -%}
  <li>Name: <code>{{ value.type }}</code></li>
{%- endfor -%}
</ul>

<h2>site.data.papyrus_objects ({{ site.data.papyrus_objects.size }})</h2>
<ul>
{%- for value in site.data.papyrus_objects -%}
  <li>Name: <code>{{ value.name }}</code></li>
{%- endfor -%}
</ul>

<hr>

<h2>site.site_debug ({{ site.site_debug.size }})</h2>
<ul>
{%- for value in site.site_debug -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h2>site.wiki_objects_ck ({{ site.wiki_objects_ck.size }})</h2>
<ul>
{%- for value in site.wiki_objects_ck -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h2>site.wiki_objects_papyrus ({{ site.wiki_objects_papyrus.size }})</h2>
<ul>
{%- for value in site.wiki_objects_papyrus -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<h2>site.wiki ({{ site.wiki.size }})</h2>
<ul>
{%- for value in site.wiki -%}
  <li><a href="{{ site.baseurl }}{{ value.url }}">{{ value.title }}</a></li>
{%- endfor -%}
</ul>

<hr>

<h2>site.static_files ({{ site.static_files.size }})</h2>
<ul>
{%- for file in site.static_files -%}
  <li>{{ file.basename }} : <code>{{ file.path }}</code></li>
{%- endfor -%}
</ul>
