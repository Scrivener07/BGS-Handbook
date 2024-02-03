---
title: "Getting Started"
categories: fo4 papyrus getting-started
---

### Game Directory
Fallout 4 and the *Creation Kit* will load file assets from the *Data* directory, located `...\Steam\SteamApps\common\Fallout 4\Data\`.

The game will load *Data File*s, *Archive File*s, and *Initialization File*s from this folder.

The PC release of Fallout 4 with no DLC has a fairly empty `Fallout 4\Data\` directory.
Only the `Video\` folder exists along with the base game data file and archives.

The compiled script executables (`*.pex`) are contained in the `Fallout 4\Data\Fallout4 - Misc.ba2` archive.
These `*.pex` are used by the game at runtime to execute script code.


### Archive
To write new scripts we need the corresponding source code for each compiled script executable.
These script source files are not distributed with the game.

These source files are distributed with the Creation Kit download.
the Creation Kit itself is installed to the existing Fallout 4 game directory.

Among the installed Creation Kit files will be ZIP files containing all the base game and DLC script source.

- `Fallout 4\Data\Scripts\Source\Base\Base.zip`
- `Fallout 4\Data\Scripts\Source\CreationClub\CreationClub.zip`
- `Fallout 4\Data\Scripts\Source\DLC00\DLC00.zip`
- `Fallout 4\Data\Scripts\Source\DLC01\DLC01.zip`
- `Fallout 4\Data\Scripts\Source\DLC02\DLC02.zip`
- `Fallout 4\Data\Scripts\Source\DLC03\DLC03.zip`
- `Fallout 4\Data\Scripts\Source\DLC04\DLC04.zip`
- `Fallout 4\Data\Scripts\Source\DLC05\DLC05.zip`
- `Fallout 4\Data\Scripts\Source\DLC06\DLC06.zip`

Upon first launch the Creation Kit should extract the contents of the ZIP files.

If for whatever reason it does not, you can extract the files to their current directories yourself.

- `Fallout 4\Data\Scripts\Source\Base\Institute_Papyrus_Flags.flg`
- `Fallout 4\Data\Scripts\Source\Base\Action.psc`
- `Fallout 4\Data\Scripts\Source\Base\Activator.psc`
- `Fallout 4\Data\Scripts\Source\Base\ActiveMagicEffect.psc`
- `Fallout 4\Data\Scripts\Source\Base\Actor.psc`
- etc ...


### Flags Files
The `Institute_Papyrus_Flags.flg` flag file is used for processing flags in the scripts.


### ScriptObject
One script I want to draw attention to is the `\Base\ScriptObject.psc`

This is the base script that all other scripts inherit from.

This effectively means that the `\Base\` import is required for all scripted projects, and therefore require `Fallout4.esm` in your data plugin.

#### See Also
- [https://falloutck.uesp.net/wiki/ScriptObject_Script]()


### Loose Files

With the *Enable Loose Files* configuration, Fallout 4 will also consider several sub-directories that load specific assets based on their file type.

A loose file is a file that exist within the Fallout 4 directory that is not listed by any manifests.
By default, Fallout 4 will ignore loose files.

This includes the compiled `.pex` files the Papyrus Compiler creates.
If you find that none of your scripts appear to be working in the game, then most likely it is because you have not enabled loose files.

1. Open\Create the file : `<Documents>\My Games\Fallout 4\Fallout4Custom.ini`
2. Populate the `Fallout4Custom.ini` file with the following:

```ini
[Archive]
bInvalidateOlderFiles=1
sResourceDataDirsFinal=
```

#### See Also
- [https://falloutck.uesp.net/wiki/Enable_Loose_Files]()


### Creation Kit Configuration
I have opinions on how imports should be but that ship sailed long ago for wide spread adoption.
`...\Fallout 4\Data\Scripts\Source\Base\` vanilla base scripts
`...\Fallout 4\Data\Scripts\Source\F4SE\` f4se base scripts
`...\Fallout 4\Data\Scripts\Source\MCM\` you get the idea

Honestly I think all projects should use their own Papyrus import instead of everyone cramming everything into `User\`.
`...\Fallout 4\Data\Scripts\Source\MyProjectName\`

But the CK can get fussy about changing around imports so most people don't bother with it.

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

##### Compiling from inside the CK
Show how to setup compiling from inside the CK.

##### Compiling from the command line interface
Show how to setup compiling from the command line interface.

##### Windows system `PATH` environment variable.
Mention how to add CLI executables to the Windows system `PATH` variable.
This allows the executables to be called by just their file name, rather than requiring a full path or a current directory change.

##### CK Papyrus settings
Mention the GUI view of the Creation Kit ini settings related to Papyrus.

##### Workspace
Explain imports and namespaces.
