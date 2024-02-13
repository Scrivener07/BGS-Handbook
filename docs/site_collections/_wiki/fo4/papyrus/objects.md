---
title: "Script Objects"
categories: fo4 papyrus
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

<https://falloutck.uesp.net/wiki/Category:Script_Objects>

See also the [Creation Kit Objects]({{ site.baseurl }}{% link _wiki/fo4/creation-kit/objects.md %}) page.

<section>
{%- for value in site.data.papyrus_objects -%}
<dl>
  <dt>Name</dt>
  <dd><code>{{ value.name }}</code></dd>

  <dt>Icon</dt>
  <dd><img src="{{ site.baseurl }}{{ value.icon | default: '/assets/object_icon/default.png' }}" alt="Icon"></dd>

  <dt>Object</dt>
  {%- if value.object -%}
    <dd><a href="{{ site.baseurl }}/_wiki_objects_ck/{{ value.object }}.html">{{ value.object }}</a></dd>
  {%- else -%}
      <dd>no data object</dd>
  {%- endif -%}

  <dt>Extends</dt>
  <dd><code>{{ value.extends }}</code></dd>

  <dt>Wiki</dt>
  {%- if value.wiki -%}
    <dd><a href="{{ value.wiki }}" target="_blank">{{ value.wiki }}</a></dd>
  {%- else -%}
      <dd>no wiki link</dd>
  {%- endif -%}
</dl>
{%- endfor -%}
</section>

<section>
<b>Size: </b><span>{{ site.data.papyrus.size }}</span>
<ul>
  {%- for script in site.data.papyrus -%}
  <li>{{ script.ObjectTable[0].Name | inspect }} extends {{ script.ObjectTable[0].Extends | inspect }}</li>
  {%- endfor -%}
</ul>
</section>
