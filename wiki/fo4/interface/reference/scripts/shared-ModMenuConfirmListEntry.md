# ModMenuConfirmListEntry Module

This document provides information about the `ModMenuConfirmListEntry` ActionScript class located in the `Shared` package.
The class is used within the context of a Flash application to represent a confirmation list entry within a mod menu interface.

## Contents

- [File Details](#file-details)
- [Class Overview](#class-overview)
- [Class Properties](#class-properties)
- [Constructor](#constructor)
- [Code Sample](#code-sample)

## File Details

- **Filename**: `ModMenuConfirmListEntry.as`
- **Package**: `Shared`

## Class Overview

`ModMenuConfirmListEntry` is a dynamic class that extends the `MovieClip` class from the flash.display library. It is designed to represent an individual entry in a confirmation list within a mod menu.

## Class Properties

| Property Name | Type          | Description                             |
| ------------- | ------------- | --------------------------------------- |
| **border**    | MovieClip     | Represents the border of the list entry |
| **textField** | TextField     | The text field within the list entry    |

## Constructor

The constructor for `ModMenuConfirmListEntry` initializes the class instance.

```actionscript
public function ModMenuConfirmListEntry() {
    super();
}
```

## Code Sample

Below is the ActionScript code for the `ModMenuConfirmListEntry` class:

```actionscript
package Shared {
    import flash.display.MovieClip;
    import flash.text.TextField;

    public dynamic class ModMenuConfirmListEntry extends MovieClip {
        public var border:MovieClip;
        public var textField:TextField;

        public function ModMenuConfirmListEntry() {
            super();
        }
    }
}
```

This class contains two main properties: `border` and `textField`. The `border` property is a `MovieClip` that visually represents the border of the list entry.
The `textField` property is a `TextField` that holds the text within the list entry. The `ModMenuConfirmListEntry` class can be extended or instantiated to create a visual list entry for mod menu confirmations.
