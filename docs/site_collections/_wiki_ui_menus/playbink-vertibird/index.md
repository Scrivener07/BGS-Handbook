---
title: "VertibirdMenu"
categories: fo4 interface menus playbink-vertibird
---

This documentation provides a detailed look at the `VertibirdMenu.as` ActionScript file.
The `VertibirdMenu` class extends the `MovieClip` class and contains a constructor for initializing instances of the class.


## Class Details
Below is an overview of the `VertibirdMenu` class.

| Item | Description |
| ---- | ----------- |
| **Name** | VertibirdMenu |
| **Type** | Dynamic Class |
| **Extends** | MovieClip |

## Properties

The `VertibirdMenu` class includes the following public properties:

| Property Name | Type | Description |
| ------------- | ---- | ----------- |
| `Menu_mc` | `PlayBinkMenu` | A reference to an instance of the `PlayBinkMenu` class, which is used to manage video playback in the menu. |

## Constructor

The constructor is called when an instance of `VertibirdMenu` is created.
It initializes the object by calling the `super()` method, which is a reference to the constructor of the base class (`MovieClip`).

**Constructor Definition:**

```actionscript
public function VertibirdMenu() {
    super();
}
```

## Example Usage

Instantiate the `VertibirdMenu` class:

```actionscript
var vertibirdMenuInstance:VertibirdMenu = new VertibirdMenu();
addChild(vertibirdMenuInstance);
```

The above example creates a new instance of the `VertibirdMenu` class and adds it to the display list.

## Full Class Code

Here's the complete code block for the `VertibirdMenu` class:

```actionscript
package {
    import flash.display.MovieClip;

    public dynamic class VertibirdMenu extends MovieClip {
        public var Menu_mc:PlayBinkMenu;

        public function VertibirdMenu() {
            super();
        }
    }
}
```

In the context of the provided code, the `VertibirdMenu` class serves as a wrapper or controller for a menu system that likely handles video playback through the `Menu_mc` property of `PlayBinkMenu` type.

The actual functionality and methods available within the `PlayBinkMenu` class are not defined in this particular file and would require further investigation into the associated class definition.
