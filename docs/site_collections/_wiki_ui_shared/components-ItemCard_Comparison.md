---
---
# ItemCard_Comparison
The `ItemCard_Comparison` class is a dynamic extension of the `MovieClip` class from the `flash.display` package.
This class is designed to represent an item card within a Flash application that likely stops its timeline at the first frame to display static content.

## Class Definition

**Package**: `Components`
**Inherits**: `flash.display.MovieClip`
**Modifiers**: dynamic

### Constructor

The class has a single constructor which calls the `super` constructor of its parent `MovieClip` class and then adds a frame script to the first frame using the `addFrameScript` method.

```actionscript
public function ItemCard_Comparison() {
    super();
    addFrameScript(0, this.frame1);
}
```

### Methods

#### frame1

The `frame1` method is a frame script that is meant to be executed when the playhead of the MovieClip timeline reaches the first frame.

```actionscript
function frame1() : * {
    stop();
}
```

This method calls the `stop` function to prevent the MovieClip from playing past the first frame, which is a common practice in Flash when you want to display a static item card or interface element.

## 📄 File Content Summary

| Aspect           | Details                                                            |
| ---------------- | ------------------------------------------------------------------ |
| **Filename**     | `ItemCard_Comparison.as`                                           |
| **Class Name**   | `ItemCard_Comparison`                                              |
| **Package**      | `Components`                                                       |
| **Inheritance**  | Extends `MovieClip`                                                |
| **Functionality**| Designed to display a static item card by stopping at frame one.   |

### Example Usage

To use the `ItemCard_Comparison` class in a Flash application, one would typically create an instance of the class and add it to the display list:

```actionscript
var itemCard:ItemCard_Comparison = new ItemCard_Comparison();
addChild(itemCard);
```

---

**Note**: Since Flash has been deprecated, this code is mostly for legacy applications or for those maintaining existing Flash content.
