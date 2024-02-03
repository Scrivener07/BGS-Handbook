---
# Feel free to add content and custom Front Matter to this file.
# To modify the layout, see https://jekyllrb.com/docs/themes/#overriding-theme-defaults
layout: home
title: "Home"
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

<h2>Configuration</h2>
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
        <li><b>{{ collection.label }}</b>
          <ul>
            <li><b>label:</b> {{ collection.label }}</li>
            <li><b>docs:</b> {{ collection.docs.size }}</li>
            <li><b>files:</b> {{ collection.files.size }}</li>
            <li><b>relative_directory:</b> {{ collection.relative_directory }}</li>
            <li><b>directory:</b> {{ collection.directory }}</li>
            <li><b>output:</b> {{ collection.output }}</li>
          </ul>
        </li>
      {%- endfor -%}
    </ul>
  </dd>
</dl>

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
