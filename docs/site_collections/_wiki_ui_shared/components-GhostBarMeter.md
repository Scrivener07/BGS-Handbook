---
---
# GhostBarMeter
The `GhostBarMeter` class is a component used to display a meter with dual fill levels—one showing the current value and another indicating a secondary 'ghost' value.
This class is part of the `Components` package and extends the `BSUIComponent` class.

## File Details

- **Filename**: `GhostBarMeter.as`
- **Package**: `Components`

## Class Definition

```actionscript
package Components {
    import Shared.AS3.BSUIComponent;
    import flash.display.MovieClip;

    public class GhostBarMeter extends BSUIComponent {
        // Class properties
        public var Fill_mc:MovieClip;
        public var GhostFill_mc:MovieClip;

        private var _Value:Number;
        private var _GhostValue:Number;
        private var _MaxValue:Number;

        // Constructor
        public function GhostBarMeter() {
            super();
            this._Value = 0;
            this._GhostValue = 0;
            this._MaxValue = 0;
        }

        // Public Methods
        public function SetMeter(param1:Number, param2:Number, param3:Number) : * {
            this._Value = param1;
            this._GhostValue = param2;
            this._MaxValue = param3;
            SetIsDirty();
        }

        // Override methods
        override public function redrawUIComponent() : void {
            super.redrawUIComponent();
            if(this.Fill_mc != null) {
                this.Fill_mc.visible = this._Value > 0 && this._MaxValue > 0;
                if(this.Fill_mc.visible) {
                    this.Fill_mc.width = this._Value / this._MaxValue * (this.width / this.scaleX);
                }
            }

            if(this.GhostFill_mc != null) {
                this.GhostFill_mc.visible = this._GhostValue > 0 && this._MaxValue > 0;
                if(this.GhostFill_mc.visible) {
                    this.GhostFill_mc.width = this._GhostValue / this._MaxValue * (this.width / this.scaleX);
                }
            }
        }
    }
}
```

## Properties

| Property        | Type         | Description                              |
|-----------------|--------------|------------------------------------------|
| `Fill_mc`       | MovieClip    | The MovieClip representing the primary fill of the meter. |
| `GhostFill_mc`  | MovieClip    | The MovieClip representing the secondary 'ghost' fill of the meter. |
| `_Value`        | Number       | The current value of the meter.          |
| `_GhostValue`   | Number       | The current 'ghost' value of the meter.  |
| `_MaxValue`     | Number       | The maximum value of the meter.          |

## Constructor

**GhostBarMeter()**

Initializes the `GhostBarMeter` component with default values of `0` for `_Value`, `_GhostValue`, and `_MaxValue`.

## Public Methods

### SetMeter(param1:Number, param2:Number, param3:Number): *

Sets the values for the meter.

- `param1`: The new value to set for the primary fill.
- `param2`: The new value to set for the ghost fill.
- `param3`: The maximum value of the meter.

The method marks the UI component as dirty, which means it should redraw in the next frame.

## Override Methods

### redrawUIComponent(): void

Redraws the meter UI component. It updates the visibility and width of `Fill_mc` and `GhostFill_mc` based on `_Value`, `_GhostValue`, and `_MaxValue`. This method is called whenever the component needs to be visually updated.

## Usage

To use the `GhostBarMeter` component, create an instance of the class, and then call `SetMeter` to update the values. The component will automatically update its visual representation on the screen.

---

👻 This documentation provides a detailed look at the `GhostBarMeter` ActionScript component. It outlines the purpose, properties, constructor, and public methods clearly, using a combination of tables, code blocks, lists, and bold text for emphasis.
