---
title: "Site"
site_nav: true
---

<style type="text/css">
  dt {
    font-weight: bold;
  }
  dt:after {
    content: ":";
  }
  dd {
    margin: 0;
    padding: 0 0 0.5em 0;
  }
</style>

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


<h1>Configuration</h1>
<dl>
  <dt>site.title</dt>
  <dd>{{ site.title }}</dd>
  <dt>site.email</dt>
  <dd>{{ site.email }}</dd>
  <dt>site.github_username</dt>
  <dd>{{ site.github_username }}</dd>
  <dt>site.description</dt>
  <dd>{{ site.description }}</dd>
  <dt>site.url</dt>
  <dd>{{ site.url }}</dd>
  <dt>site.baseurl</dt>
  <dd>{{ site.baseurl }}</dd>
  <dt>site.theme</dt>
  <dd>{{ site.theme }}</dd>
  <dt>site.header_pages</dt>
  <dd>{{ site.header_pages }}</dd>
  <dt>site.plugins ({{ site.plugins.size }})</dt>
  <dd>
    <ul>
      {%- for plugin in site.plugins -%}
        <li>{{ plugin }}</li>
      {%- endfor -%}
    </ul>
  </dd>
  <dt>site.collections_dir</dt>
  <dd>{{ site.collections_dir }}</dd>
  <dt>site.collections ({{ site.collections.size }})</dt>
  <dd>
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
  </dd>
</dl>

<hr>

<h3>site.pages ({{ site.pages.size }})</h3>
<ul>
{%- for value in site.pages -%}
  {%- if value.title -%}
    <li>{{ value.url }} : {{ value.title }}</li>
  {%- else -%}
    <li>{{ value.url }}</li>
  {%- endif -%}
{%- endfor -%}
</ul>

<h3>site.posts ({{ site.posts.size }})</h3>
<ul>
{%- for value in site.posts -%}
  <li>{{ value.title }}</li>
{%- endfor -%}
</ul>

<h3>site.categories ({{ site.categories.size }})</h3>
Only posts with categories are stored in this array.
<ul>
  {%- for category in site.categories -%}
    <li>{{ category[0] }} (used by {{ category[1].size }})</li>
  {%- endfor -%}
</ul>

<h3>site.tags ({{ site.tags.size }})</h3>
Only posts with tags are stored in this array.
<ul>
  {%- for tag in site.tags -%}
    <li>{{ tag[0] }} (used by {{ tag[1].size }})</li>
  {%- endfor -%}
</ul>

<hr>

<h3>site.data.ck_objects ({{ site.data.ck_objects.size }})</h3>
<ul>
{%- for value in site.data.ck_objects -%}
  <li>Name: <code>{{ value.type }}</code></li>
{%- endfor -%}
</ul>

<h3>site.data.papyrus_objects ({{ site.data.papyrus_objects.size }})</h3>
<ul>
{%- for value in site.data.papyrus_objects -%}
  <li>Name: <code>{{ value.name }}</code></li>
{%- endfor -%}
</ul>

<hr>

<h3>site.site_debug ({{ site.site_debug.size }})</h3>
<ul>
{%- for value in site.site_debug -%}
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

<hr>

<h3>site.static_files ({{ site.static_files.size }})</h3>
<ul>
{%- for file in site.static_files -%}
  <li>{{ file.basename }} : <code>{{ file.path }}</code></li>
{%- endfor -%}
</ul>
