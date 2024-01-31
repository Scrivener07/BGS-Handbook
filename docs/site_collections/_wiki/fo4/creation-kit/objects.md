---
title: "Data Objects"
---

<style type="text/css">
  dl {
    border-style: groove;
    border-width: 1px;
    padding: 0.5em;
  }

  dt {
    float: left;
    clear: left;
    width: 200px;
    text-align: right;
    font-weight: bold;
    margin-right: 8px;
  }

  dt::after {
    content: ":";
  }

  dd {
    margin: 0 0 0 110px;
    padding: 0 0 0.5em 0;
  }
</style>

<https://falloutck.uesp.net/wiki/Category:Object_Classes>

See also the [Papyrus Objects]({{ site.baseurl }}{%- link _wiki/fo4/papyrus/objects.md -%}) page.

<section>
{%- for value in site.data.ck_objects -%}
<dl>
  <dt>Name</dt>
  <dd><code>{{ value.name }}</code></dd>

  <dt>Type</dt>
  <dd><code>{{ value.type }}</code></dd>

  <dt>Category</dt>
  {%- if value.category -%}
    <dd>{{ value.category }}</dd>
  {%- else -%}
    <dd>no data object category</dd>
  {%- endif -%}

  <dt>Icon</dt>
  <dd><img src="{{ site.baseurl }}{{ value.icon | default: '/assets/object_icon/default.png' }}" alt="Icon"></dd>

  <dt>Script</dt>
  {%- if value.script -%}
      <dd><a href="{{ site.baseurl }}/wiki_objects_papyrus/{{ value.script }}.html">{{ value.script }}</a></dd>
  {%- else -%}
      <dd>no script type</dd>
  {%- endif -%}

  <dt>Script Reference</dt>
  {%- if value.script_reference -%}
    <dd><a href="{{ site.baseurl }}/wiki_objects_papyrus/{{ value.script_reference }}.html">{{ value.script_reference }}</a></dd>
  {%- else -%}
      <dd>no reference script type</dd>
  {%- endif -%}

  <dt>Wiki</dt>
  {%- if value.wiki -%}
    <dd><a href="{{ value.wiki }}" target="_blank">{{ value.wiki }}</a></dd>
  {%- else -%}
      <dd>no wiki link</dd>
  {%- endif -%}
</dl>
{%- endfor -%}
</section>
