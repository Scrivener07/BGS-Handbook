---
title: "Site.Plugins"
---

#### Jekyll Documentation
- <https://jekyllrb.com/docs/plugins/>


<h3>site.plugins</h3>
<li>size: {{ site.plugins.size }}</li>
<ul>
  {%- for plugin in site.plugins -%}
    <li>{{ plugin }}</li>
  {%- endfor -%}
</ul>
