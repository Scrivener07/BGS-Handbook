---
layout: wiki_category
title: "Getting Started"
---

I have opinions on how imports should be but that ship sailed long ago for wide spread adoption.
`...\Fallout 4\Data\Scripts\Source\Base\` vanilla base scripts
`...\Fallout 4\Data\Scripts\Source\F4SE\` f4se base scripts
`...\Fallout 4\Data\Scripts\Source\MCM\` you get the idea

Honestly I think all projects should use their own Papyrus import instead of everyone cramming everything into `User\`.
`...\Fallout 4\Data\Scripts\Source\MyProjectName\`

But the CK can get fussy about changing around imports so most people dont bother with it.
You specify `sScriptSourceFolder` as the import your actively working on and `sAdditionalImports` is the list of dependent imports like `Base` and `F4SE`.
I use an external editor and call the compiler directly so Im unaffected by needing to edit CreationKit.ini or dealing with its fussiness.

```ini
[Papyrus]
sCompileMode=Debug
sScriptSourceFolder = ".\Data\Scripts\Source\MyProjectName"
sAdditionalImports ="$(source);.\Data\Scripts\Source\User;.\Data\Scripts\Source\MCM;.\Data\Scripts\Source\F4SE;.\Data\Scripts\Source\Base"
```

The original releases of F4SE actually did package the base scripts to `...\Fallout 4\Data\Scripts\Source\F4SE\` but waaay too many people couldnt wrap their heads around imports so they crammed it into `User\` soon after.
This way people dont have to bother with editing `sAdditionalImports` in the INI.

I think doing that undermined the entire import feature.
The `sAdditionalImports` has a load order to it as well.
Imports on the left will override imports on the right.


# TODO
- Mention how to add CLI executables to the Windows system `PATH` variable. This allows the executables to be called by just their file name, rather than requiring a full path or a current directory change.
- Mention the GUI view of the Creation Kit ini settings related to Papyrus.
- Explain imports and namespaces.
