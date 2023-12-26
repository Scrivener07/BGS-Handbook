# InputDetails.as Documentation

This documentation provides a detailed overview of the `InputDetails` class found within the `scaleform.clik.ui` package. The `InputDetails` class represents the details of a user's input and provides a structure for storing and retrieving information about specific interactions.

## Class Definition

The `InputDetails` class is defined as follows:

```as3
package scaleform.clik.ui {
    public class InputDetails {
        public var type:String;
        public var code:Number;
        public var value;
        public var navEquivalent:String;
        public var controllerIndex:uint;
        public var ctrlKey:Boolean;
        public var altKey:Boolean;
        public var shiftKey:Boolean;

        public function InputDetails(param1:String, param2:Number, param3:*, param4:String = null, param5:uint = 0, param6:Boolean = false, param7:Boolean = false, param8:Boolean = false) {
            super();
            this.type = param1;
            this.code = param2;
            this.value = param3;
            this.navEquivalent = param4;
            this.controllerIndex = param5;
            this.ctrlKey = param6;
            this.altKey = param7;
            this.shiftKey = param8;
        }

        public function toString() : String {
            return "[InputDetails code=" + this.code + ", type=" + this.type + " value=" + this.value + ", navEquivalent=" + this.navEquivalent + ", controllerIndex=" + this.controllerIndex + ", ctrlKey=" + this.ctrlKey + ", altKey=" + this.altKey + ", shiftKey=" + this.shiftKey + "]";
        }
    }
}
```

## Properties

The `InputDetails` class contains the following properties:

| Property          | Type    | Description                                              |
|-------------------|---------|----------------------------------------------------------|
| **type**          | String  | The type of input, such as "keyDown" or "keyUp".         |
| **code**          | Number  | The numerical code representing the specific key or button.  |
| **value**         | *       | The value associated with the input.                     |
| **navEquivalent** | String  | A string corresponding to the navigation action.         |
| **controllerIndex**  | uint   | The index of the controller from which the input originated. |
| **ctrlKey**       | Boolean | Indicates whether the Ctrl key was pressed.              |
| **altKey**        | Boolean | Indicates whether the Alt key was pressed.               |
| **shiftKey**      | Boolean | Indicates whether the Shift key was pressed.             |

## Constructor

The constructor of the `InputDetails` class:

```as3
public function InputDetails(param1:String,
                             param2:Number,
                             param3:*,
                             param4:String = null,
                             param5:uint = 0,
                             param6:Boolean = false,
                             param7:Boolean = false,
                             param8:Boolean = false)
```

### Parameters

- **param1**: The type of input (e.g., "keyDown", "keyUp").
- **param2**: The code of the key or button pressed.
- **param3**: The value associated with the input.
- **param4** (optional): The navigation equivalent, which defaults to `null`.
- **param5** (optional): The controller index, which defaults to `0`.
- **param6** (optional): The ctrl key indicator, which defaults to `false`.
- **param7** (optional): The alt key indicator, which defaults to `false`.
- **param8** (optional): The shift key indicator, which defaults to `false`.

## Methods

### toString

This method overrides the default `toString` method to provide a string representation of the `InputDetails` instance.

```as3
public function toString() : String
```

## Usage Example

```as3
var inputDetail:InputDetails = new InputDetails("keyDown", 13, null, "ENTER", 0, true, false, false);
trace(inputDetail.toString()); // Outputs: [InputDetails code=13, type=keyDown value=null, navEquivalent=ENTER, controllerIndex=0, ctrlKey=true, altKey=false, shiftKey=false]
```

## 📝 Notes

- The `toString` method can be particularly useful for debugging purposes to quickly inspect the state of an `InputDetails` object.
- The `value` property type is unspecified (`*`), allowing it to hold any type of data relevant to the input event.
