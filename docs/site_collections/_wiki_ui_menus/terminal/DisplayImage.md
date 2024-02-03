---
title: "DisplayImage"
categories: fo4 interface menus terminal
---

`DisplayImage.as` is an ActionScript file that defines a `DisplayImage` class which extends the `MovieClip` class from the Flash display library.
This class serves as a dynamic class that can be used to instantiate movie clips with additional properties and methods at runtime.

### Class Definition

| Modifier        | Type         | Name          | Description                                           |
|-----------------|--------------|---------------|-------------------------------------------------------|
| `public`        | `dynamic`    | `DisplayImage`| The class that extends `MovieClip` to display images. |

### Constructor

The `DisplayImage` class has a constructor method that calls the constructor of its superclass `MovieClip`.

- **DisplayImage()**: Initializes a new instance of the `DisplayImage` class.

## Code Example

```actionscript
package {
    import flash.display.MovieClip;

    public dynamic class DisplayImage extends MovieClip {

        public function DisplayImage() {
            super();
        }

    }
}
```

## Usage

To use the `DisplayImage` class, you should follow these steps:

1. **Import the `DisplayImage` class:** First, make sure to import the class into your ActionScript code where you plan to use it.

2. **Create an instance of `DisplayImage`:** Instantiate the class by calling the constructor.

3. **Optional - Extend functionality:** Being a dynamic class, you can add properties and methods to the `DisplayImage` instances dynamically at runtime.

## Example Usage

```actionscript
import DisplayImage;

var imageDisplay:DisplayImage = new DisplayImage();
addChild(imageDisplay); // Add the instance to the display list to make it visible.

// Dynamically add a new property to the imageDisplay instance.
imageDisplay.customProperty = "someValue";

// You can also add functions dynamically, if needed.
imageDisplay.customFunction = function() {
    trace("Custom function called!");
};

imageDisplay.customFunction(); // Outputs: Custom function called!
```

## 📌 Note
The `DisplayImage` class itself does not contain image display functionality beyond that provided by the `MovieClip` class.
Additional functionality may be added through subclassing or by dynamically adding properties and methods to instances of this class.
