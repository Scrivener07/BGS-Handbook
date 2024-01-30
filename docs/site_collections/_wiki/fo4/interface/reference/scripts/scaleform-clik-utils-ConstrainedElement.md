# ConstrainedElement

This documentation provides detailed information about the `ConstrainedElement` class found within the `scaleform.clik.utils` package.

The purpose of this class is to facilitate the constraints of `DisplayObject` instances in the context of a user interface, such as a game HUD or menu system.

## Class Definition

```actionscript
package scaleform.clik.utils {
    import flash.display.DisplayObject;

    public class ConstrainedElement {

        public var clip:DisplayObject;
        public var edges:uint;
        public var left:Number;
        public var top:Number;
        public var right:Number;
        public var bottom:Number;
        public var scaleX:Number;
        public var scaleY:Number;

        public function ConstrainedElement(
            param1:DisplayObject,
            param2:uint,
            param3:Number,
            param4:Number,
            param5:Number,
            param6:Number,
            param7:Number,
            param8:Number
        ) {
            super();
            this.clip = param1;
            this.edges = param2;
            this.left = param3;
            this.top = param4;
            this.right = param5;
            this.bottom = param6;
            this.scaleX = param7;
            this.scaleY = param8;
        }

        public function toString() : String {
            return "[ConstrainedElement " +
                this.clip + ", edges=" + this.edges +
                ", left=" + this.left +
                ", right=" + this.right +
                ", top=" + this.top +
                ", bottom=" + this.bottom +
                ", scaleX=" + this.scaleX +
                ", scaleY=" + this.scaleY + "]";
        }

    }
}
```

## Constructor Parameters

| Parameter | Type            | Description                                                                |
|-----------|-----------------|----------------------------------------------------------------------------|
| param1    | DisplayObject   | The display object that is subject to constraints.                         |
| param2    | uint            | An unsigned integer indicating the edges that are constrained.             |
| param3    | Number          | The left constraint value.                                                 |
| param4    | Number          | The top constraint value.                                                  |
| param5    | Number          | The right constraint value.                                                |
| param6    | Number          | The bottom constraint value.                                               |
| param7    | Number          | The horizontal scale factor for the constrained object.                    |
| param8    | Number          | The vertical scale factor for the constrained object.                      |

## Public Properties

- **clip** (`DisplayObject`): References the `DisplayObject` that is being constrained.
- **edges** (`uint`): Stores the bit flag that represents the constrained edges.
- **left** (`Number`): Represents the constraint value for the left edge.
- **top** (`Number`): Represents the constraint value for the top edge.
- **right** (`Number`): Represents the constraint value for the right edge.
- **bottom** (`Number`): Represents the constraint value for the bottom edge.
- **scaleX** (`Number`): The horizontal scaling factor of the `DisplayObject`.
- **scaleY** (`Number`): The vertical scaling factor of the `DisplayObject`.

## Methods

- **ConstrainedElement** Constructor: Initializes a new instance of the `ConstrainedElement` class with specified constraints and scale factors.

- **toString()** (`String`): Overrides the default `toString` method to provide a string representation of the `ConstrainedElement` instance.

## Example Usage

```actionscript
import scaleform.clik.utils.ConstrainedElement;
import flash.display.MovieClip;

var myClip:MovieClip = new MovieClip();
var myConstrainedElement:ConstrainedElement = new ConstrainedElement(
    myClip,
    0x0F,
    10,
    20,
    30,
    40,
    1.0,
    1.0
);
trace(myConstrainedElement.toString());
```

In this example, `myClip` is a `MovieClip` instance that is being constrained on all edges with specified distances from the parent container's corresponding edges. The scale factors for both horizontal and vertical scaling are set to `1.0`, meaning no scaling is applied.

**🚀 Tips**

- The `edges` parameter can be used to set multiple constraints using bitwise OR operations.
- Properly setting the `left`, `top`, `right`, and `bottom` values can ensure responsive layouts that adjust with the parent container's size.
- Always consider maintaining the aspect ratio when scaling by setting proportional `scaleX` and `scaleY` values.

🔗 **Further Resources**
- For more information on bitwise operations: [ActionScript 3.0 Bitwise Operators](http://help.adobe.com/en_US/FlashPlatform/reference/actionscript/3/operators.html#bitwise_operators)
- For advanced layout management, consider learning about the [CLIK Layout Manager](https://www.scaleform.com/clik/docs/Manual/CLIK_LayoutManager.html).
