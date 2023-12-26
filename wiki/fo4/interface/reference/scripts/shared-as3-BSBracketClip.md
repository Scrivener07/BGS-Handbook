# BSBracketClip Documentation

**Filename**: `BSBracketClip.as`

---

## Overview

`BSBracketClip` is an ActionScript 3.0 class extending `MovieClip` to provide functionality for drawing bracket shapes around UI components in different styles.

---

## Class Structure

| Access Type | Member Type | Member Name       | Data Type        | Description                                              |
|-------------|-------------|-------------------|------------------|----------------------------------------------------------|
| `public`    | `static`    | `BR_HORIZONTAL`   | `String`         | Defines a horizontal bracket style.                      |
| `public`    | `static`    | `BR_VERTICAL`     | `String`         | Defines a vertical bracket style.                        |
| `public`    | `static`    | `BR_CORNERS`      | `String`         | Defines a corner bracket style.                          |
| `public`    | `static`    | `BR_FULL`         | `String`         | Defines a full bracket style, enclosing all four sides.  |
| `private`   | `variable`  | `_drawPos`        | `Point`          | Stores the current position for drawing operations.      |
| `private`   | `variable`  | `_clipRect`       | `Rectangle`      | The bounds of the UI component to draw brackets around.  |
| `private`   | `variable`  | `_lineThickness`  | `Number`         | The thickness of the brackets' lines.                    |
| `private`   | `variable`  | `_cornerLength`   | `Number`         | The length of the brackets' corners.                     |
| `private`   | `variable`  | `_padding`        | `Point`          | Padding around the UI component for the brackets.        |
| `private`   | `variable`  | `_style`          | `String`         | The style of bracket to draw.                            |
| `public`    | `method`    | `BSBracketClip`   | Constructor      | Constructor for the class. Initializes the `MovieClip`.  |
| `public`    | `method`    | `BracketPair`     | `*`              | Placeholder method to create bracket pairs.              |
| `public`    | `method`    | `ClearBrackets`   | `*`              | Clears the current brackets drawn on the graphics canvas.|
| `public`    | `method`    | `redrawUIComponent` | `*`            | Main method to redraw brackets around a UI component.    |

---

## Methods Detail

**Constructor**:
```actionscript
public function BSBracketClip() {
    super();
}
```

**ClearBrackets**:
```actionscript
public function ClearBrackets() : * {
    graphics.clear();
}
```

**redrawUIComponent**:
```actionscript
public function redrawUIComponent(aDrawClip:BSUIComponent, aLineThickness:Number, aCornerLength:Number, aPadding:Point, aStyle:String) : * {
    // Implementation details...
}
```

---

## Usage Example

Below is an example of how to use the `BSBracketClip` class to draw brackets:

```actionscript
import Shared.AS3.BSBracketClip;
import flash.geom.Point;

// Initialize the BSBracketClip
var bracketClip:BSBracketClip = new BSBracketClip();

// Define UI component for bracket, line thickness, corner length, padding, and style
var uiComponent:BSUIComponent = new BSUIComponent(); // Your UI component
var lineThickness:Number = 2;
var cornerLength:Number = 15;
var padding:Point = new Point(5, 5);
var style:String = BSBracketClip.BR_HORIZONTAL;

// Redraw brackets around the UI component
bracketClip.redrawUIComponent(uiComponent, lineThickness, cornerLength, padding, style);
```

---

🔵 **Note:**
- The `BSBracketClip` class is part of the `Shared.AS3` package.
- It requires an instance of a `BSUIComponent` for bracket drawing.
- The `redrawUIComponent` method allows specifying the bracket style and dimensions.
- The `BracketPair` method appears to be a placeholder and is undefined in the provided code.

This documentation covers the main features and usage of the `BSBracketClip` class.
For detailed implementation and further methods, please refer to the source code.
