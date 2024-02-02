---
---
# FlashUtil
`FlashUtil.as` is an ActionScript class stored within the package `Mobile.ScrollList`.
This class provides utility functions to work with library items in Flash.

It allows the retrieval of library items as `DisplayObject`s and provides a way to obtain class references from a given `MovieClip`'s library.

## Table of Contents

- [Class Definition](#class-definition)
- [Constants](#constants)
- [Constructor](#constructor)
- [Methods](#methods)

## Class Definition

```actionscript
package Mobile.ScrollList {
    import flash.display.Bitmap;
    import flash.display.BitmapData;
    import flash.display.DisplayObject;
    import flash.display.MovieClip;
    import flash.utils.getQualifiedClassName;
    import flash.utils.getQualifiedSuperclassName;

    public class FlashUtil {
        // ...
    }
}
```

## Constants

| Constant                     | Type     | Description                                    |
|------------------------------|----------|------------------------------------------------|
| `BITMAP_DATA_CLASS_NAME` | `String` | Holds the class name of the `BitmapData` class. |

**Code:**

```actionscript
private static const BITMAP_DATA_CLASS_NAME:String = getQualifiedClassName(BitmapData);
```

## Constructor

**FlashUtil**

The constructor is not intended to perform any action.

```actionscript
public function FlashUtil() {
    super();
}
```

## Methods

### getLibraryItem

Retrieves a library item from a `MovieClip` as a `DisplayObject`. If the item is a `BitmapData`, it creates a `Bitmap` instance.

**Syntax:**

```actionscript
public static function getLibraryItem(mc:MovieClip, className:String) : DisplayObject
```

**Parameters:**

- `mc`: `MovieClip` - The `MovieClip` containing the library item.
- `className`: `String` - The class name of the library item to retrieve.

**Returns:**

- `DisplayObject`: The library item as a `DisplayObject`.

**Code:**

```actionscript
public static function getLibraryItem(mc:MovieClip, className:String) : DisplayObject {
    var classRef:Class = getLibraryClass(mc, className);
    if (getQualifiedSuperclassName(classRef) == BITMAP_DATA_CLASS_NAME) {
        return new Bitmap(new classRef(), "auto", true);
    }
    return new classRef();
}
```

### getLibraryClass

Obtains a class reference for a library item from a `MovieClip`.

**Syntax:**

```actionscript
public static function getLibraryClass(mc:MovieClip, className:String) : Class
```

**Parameters:**

- `mc`: `MovieClip` - The `MovieClip` containing the library item.
- `className`: `String` - The class name of the library item to get the class reference for.

**Returns:**

- `Class`: The class reference of the library item.

**Code:**

```actionscript
public static function getLibraryClass(mc:MovieClip, className:String) : Class {
    var classRef:Class = mc.loaderInfo.applicationDomain.getDefinition(className) as Class;
    return classRef;
}
```

## Usage Example

```actionscript
var movieClip:MovieClip = ...; // A MovieClip instance with library items
var displayObject:DisplayObject;

// To retrieve a library item as DisplayObject
displayObject = FlashUtil.getLibraryItem(movieClip, "MyLibraryClassName");
```

This documentation provides a general overview and the methods available in the `FlashUtil` class for working with library items in Flash. Utilize these methods to dynamically access and create instances of library symbols within your ActionScript projects.
