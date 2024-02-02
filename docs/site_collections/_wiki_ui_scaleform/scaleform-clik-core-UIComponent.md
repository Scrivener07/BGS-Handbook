---
---
# UIComponent
This documentation details the `UIComponent` class, which extends the `MovieClip` class from the Flash display list.
The `UIComponent` class is part of the Scaleform CLIK (Common Lightweight Interface Kit) library used for creating user interfaces in games.

## Class Structure

```as3
package scaleform.clik.core {
    // Imports
    import flash.display.MovieClip;
    ...
    import scaleform.gfx.FocusManager;

    public class UIComponent extends MovieClip {
        // Public properties
        public var initialized:Boolean = false;
        public var constraints:Constraints;

        // Protected properties
        protected var _invalidHash:Object;
        protected var _invalid:Boolean = false;
        ...
        protected var _enableInitCallback:Boolean = false;

        // Constructor
        public function UIComponent() {
            ...
        }

        // Public static methods
        public static function generateLabelHash(param1:MovieClip):Object {
            ...
        }

        // Protected methods
        protected function preInitialize():void {
            ...
        }
        ...
        protected function validateNow(param1:Event = null):void {
            ...
        }

        // Public methods
        public function get componentInspectorSetting() : Boolean {
            ...
        }
        ...
        public function dispatchEventAndSound(param1:Event) : Boolean {
            ...
        }

        // Override methods
        override public function get width() : Number {
            ...
        }
        ...
        override public function toString() : String {
            ...
        }

        // More protected methods
        protected function initSize() : void {
            ...
        }
        ...
        protected function handleEnterFrameValidation(param1:Event) : void {
            ...
        }
    }
}
```

## Properties

| Access | Type         | Property                | Description                                                 |
|--------|--------------|-------------------------|-------------------------------------------------------------|
| public | Boolean      | initialized             | Indicates whether the component has been initialized.       |
| public | Constraints  | constraints             | References the constraints object for layout management.    |
| ...    | ...          | ...                     | ...                                                         |
| protected | Boolean   | _invalid               | Flag for tracking if the component needs to be redrawn.     |
| protected | Number    | _width                 | The width of the component.                                 |
| protected | Number    | _height                | The height of the component.                                |
| protected | Boolean   | _enableInitCallback    | Enables callback when the component is added to the stage.  |
| ...    | ...          | ...                     | ...                                                         |

## Methods

### Constructor

- `UIComponent()`: Initializes the component by setting up default values and event listeners.

### Public Static Methods

- `generateLabelHash(param1:MovieClip):Object`: Generates a hash of the frame labels.

### Public Methods

- `get componentInspectorSetting():Boolean`: Retrieves the inspector setting.
- `set componentInspectorSetting(param1:Boolean):void`: Sets the inspector setting.
- `setSize(param1:Number, param2:Number):void`: Sets the size of the component.
- `validateNow(param1:Event = null):void`: Validates and updates the component immediately, if invalid.
- `dispatchEventAndSound(param1:Event):Boolean`: Dispatches an event and plays a sound associated with it.

### Override Methods

- `get width():Number`: Retrieves the width of the component.
- `set width(param1:Number):void`: Sets the width of the component.
- `toString():String`: Returns a string representation of the `UIComponent`.

### Protected Methods

- `preInitialize():void`: Method for code that should run before the component is initialized.
- `initialize():void`: Initializes the component, setting up necessary state.

## Code Highlights

- The class relies on invalidation flags (`_invalidHash`) to manage state and optimize rendering.
- The `initialize` method sets up the component's initial size and layout details.
- Focus management features are incorporated with `FocusManager`.
- The `Invalidate` pattern is used to defer updates until necessary, improving performance.

## Example Usage

```as3
var myComponent:UIComponent = new UIComponent();
addChild(myComponent);
myComponent.setSize(150, 50);
```
