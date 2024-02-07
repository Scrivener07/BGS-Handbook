---
title: "Site.Static_Files"
---

#### Jekyll Documentation
- <https://jekyllrb.com/docs/static-files/>


<h3>site.static_files ({{ site.static_files.size }})</h3>
<ul>
{%- for file in site.static_files -%}
  <li>
    <b>{{ file.name }}</b>
    <ul>
      <li>path : <code>{{ file.path }}</code></li>
      <li>modified_time : <code>{{ file.modified_time }}</code></li>
      <li>name : <code>{{ file.name }}</code></li>
      <li>basename : <code>{{ file.basename }}</code></li>
      <li>extname : <code>{{ file.extname }}</code></li>
    </ul>
  </li>
{%- endfor -%}
</ul>
