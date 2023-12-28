# VaultBoyImageLoader Documentation

The `VaultBoyImageLoader` is a dynamic class extending `BSUIComponent` responsible for loading, displaying, and managing a Vault Boy image within a Flash/ActionScript 3.0 environment.

The default vault-boy is `Components/Quest Vault Boys/Miscellaneous Quests/DefaultBoy.swf`.

## Overview

This class allows for the dynamic loading of SWF files that depict Vault Boy animations from the Fallout video game series.
It provides properties to configure the playback and appearance of the loaded SWF animations.

## Public Properties

| Property | Type | Description |
|----------|------|-------------|
| `VaultBoyImageInternal_mc` | `BSUIComponent` | MovieClip container for the Vault Boy image. |
| `onLastFrame` | `Function` | Callback function triggered on the last frame of the SWF animation. |

## Private Properties

**🔒 The following properties are private:**

| Property | Type | Description |
|----------|------|-------------|
| `SWF` | `MovieClip` | Reference to the currently loaded SWF animation MovieClip. |
| `menuLoader` | `Loader` | Loader object for loading SWF files. |
| `_bUseFixedQuestStageSize` | `Boolean` | Whether to use fixed quest stage dimensions. |
| `_bPlayClipOnce` | `Boolean` | Whether to play the SWF animation only once. |
| `_clipAlignment` | `String` | Alignment of the SWF clip ("TopLeft" or "Center"). |
| `_defaultBoySwfName` | `String` | Default SWF file path if no URL is provided. |
| `_questAnimStageWidth` | `Number` | Width of the area to display the quest animation. |
| `_questAnimStageHeight` | `Number` | Height of the area to display the quest animation. |
| `_maxClipHeight` | `Number` | Maximum height of the SWF clip. |

## Public Methods

### `VaultBoyImageLoader()`
Constructor initializing the `VaultBoyImageLoader`. Sets up the default properties and event listeners.

### `SWFLoad(param1:String) : void`
Loads a SWF file with a given URL, hiding the current image and setting up a callback for completion.

### `onMenuLoadComplete(param1:Event, param2:String) : void`
Handles the completion of the SWF loading, sets the loaded SWF as the current MovieClip, and makes it visible.

### `SetQuestMovieClip(param1:MovieClip) : void`
Configures the loaded MovieClip with the appropriate scaling and positioning according to the class properties.

### `SWFUnload() : void`
Unloads and cleans up the currently loaded SWF MovieClip.

## Private Methods

**🔒 The following methods are private:**

### `onLastFrame_Impl(param1:String) : *`
A placeholder implementation for the `onLastFrame` callback.

### `onSWFEnterFrame(param1:Event) : *`
Handles the ENTER_FRAME event for the loaded SWF, checking if it should play once and then stopping the animation.

## Usage Example

```actionscript
var imageLoader:VaultBoyImageLoader = new VaultBoyImageLoader();
imageLoader.bPlayClipOnce = true;
imageLoader.DefaultBoySwfName = "path/to/animation.swf";
imageLoader.SWFLoad("path/to/animation.swf");
```

---

**📂 File: VaultBoyImageLoader.as**

**🔧 Package: Shared.AS3**

**💡 Note:** This code is designed to be used within the context of a larger ActionScript 3.0 application, particularly one related to the Fallout game series user-interface.
The actual behavior and visual output will depend on the context where this code is implemented and the SWF files it loads.
