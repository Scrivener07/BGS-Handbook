# RefText.as Documentation
This documentation provides an overview of the `RefText.as` ActionScript file.

The `RefText.as` file defines a dynamic ActionScript class named `RefText` that extends the `MovieClip` class from the Flash display library.
This class includes a public variable `PageTextField` of type `TextField`, which can be used to display text on the stage.

## Class Definition

### RefText

The `RefText` class is a dynamic subclass of `MovieClip` that contains a text field.

| **Property**    | **Type**    | **Description**             |
|-----------------|-------------|-----------------------------|
| PageTextField   | TextField   | A TextField object to display text. |

### Constructor

**RefText()**

The constructor initializes the `RefText` object by calling `super()` to inherit properties and methods from the `MovieClip` superclass.

## Code Block

```actionscript
package {
    import flash.display.MovieClip;
    import flash.text.TextField;

    public dynamic class RefText extends MovieClip {

        public var PageTextField:TextField;

        public function RefText() {
            super();
        }
    }
}
```

## Usage Example
To use the `RefText` class within your Flash project, you can create an instance of `RefText` and add it to the stage, then manipulate the `PageTextField` to display text as needed.

```actionscript
var myRefText:RefText = new RefText();
myRefText.PageTextField.text = "Hello, World!";
addChild(myRefText);
```

## Conclusion
The `RefText` class is a simple yet useful extension of the `MovieClip` class, providing a dynamic text field to display content within Flash applications or games.
With its straightforward implementation, it serves as a template for creating more complex text-based movie clips in the future. 📄✨
