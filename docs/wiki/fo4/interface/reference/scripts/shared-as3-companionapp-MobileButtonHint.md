# MobileButtonHint.as Documentation

The `MobileButtonHint.as` file is an ActionScript class part of the `Shared.AS3.COMPANIONAPP` package, which extends the functionality of the `BSButtonHint` class to handle mobile button hints with visual feedback on different button states.

## Class Overview

The `MobileButtonHint` class provides visual enhancements for button hints specifically tailored for a mobile interface. It includes state management for normal, pressed, and disabled button appearances.

### Properties and Constants

| **Property/Constant** | **Type**       | **Description**                                    |
|-----------------------|----------------|----------------------------------------------------|
| `background`          | MovieClip      | The MovieClip representing the button's background. |
| `BUTTON_MARGIN`       | Number (const) | Margin added to the MovieClip's dimension.         |

### Public Methods

- **MobileButtonHint()**: Constructor that initializes the button and adds event listeners.
- **redrawUIComponent()**: Overrides the parent method to adjust the background dimensions and positions.
- **onTextClick(event:MouseEvent)**: Overrides the parent method to potentially reset to the normal state upon text click.

### Protected Methods

- **setNormalState()**: Sets the button's visual state to "normal".
- **setDisableState()**: Sets the button's visual state to "disabled".
- **setPressState()**: Sets the button's visual state to "pressed".

### Event Handlers

- **onButtonPress(e:MouseEvent)**: Handles the `MOUSE_DOWN` event, changing the button's state to "pressed" if not disabled or invisible.
- **onMouseOut(event:MouseEvent)**: Overrides the parent method to reset the button's state when the mouse exits the button area.

## Detailed Code Structure
```actionscript
package Shared.AS3.COMPANIONAPP {
    import Shared.AS3.BSButtonHint;
    import flash.display.MovieClip;
    import flash.events.Event;
    import flash.events.MouseEvent;
    import flash.geom.ColorTransform;

    public dynamic class MobileButtonHint extends BSButtonHint {
        public var background:MovieClip;
        private const BUTTON_MARGIN:Number = 4;

        public function MobileButtonHint() {
            super();
            addEventListener(MouseEvent.MOUSE_DOWN, this.onButtonPress);
        }

        private function onButtonPress(e:MouseEvent) : void {
            if (!ButtonDisabled && ButtonVisible) {
                this.setPressState();
            }
        }

        override protected function onMouseOut(event:MouseEvent) : * {
            super.onMouseOut(event);
            if (!ButtonDisabled && ButtonVisible) {
                this.setNormalState();
            }
        }

        override public function onTextClick(event:MouseEvent) : void {
            super.onTextClick(event);
            if (!ButtonDisabled && ButtonVisible) {
                this.setNormalState();
            }
        }

        override public function redrawUIComponent() : void {
            this.background.width = 1;
            this.background.height = 1;
            super.redrawUIComponent();
            this.background.width = textField_tf.width + this.BUTTON_MARGIN;
            this.background.height = textField_tf.height + this.BUTTON_MARGIN;
            if (Justification == JUSTIFY_RIGHT) {
                this.background.x = 0;
                this.textField_tf.x = 0;
                if (hitArea) {
                    hitArea.x = 0;
                }
            }
            if (hitArea) {
                hitArea.width = this.background.width;
                hitArea.height = this.background.height;
            }
            if (ButtonVisible) {
                if (ButtonDisabled) {
                    this.setDisableState();
                } else {
                    this.setNormalState();
                }
            }
        }

        protected function setNormalState() : void {
            this.background.gotoAndPlay("normal");
            var colorTrans:ColorTransform = textField_tf.transform.colorTransform;
            colorTrans.redOffset = 0;
            colorTrans.greenOffset = 0;
            colorTrans.blueOffset = 0;
            textField_tf.transform.colorTransform = colorTrans;
        }

        protected function setDisableState() : void {
            this.setNormalState();
            this.background.gotoAndPlay("disabled");
        }

        protected function setPressState() : void {
            this.background.gotoAndPlay("press");
            var colorTrans:ColorTransform = textField_tf.transform.colorTransform;
            colorTrans.redOffset = 255;
            colorTrans.greenOffset = 255;
            colorTrans.blueOffset = 255;
            textField_tf.transform.colorTransform = colorTrans;
        }
    }
}
```

## Usage Example

To create and utilize a `MobileButtonHint` object, you might perform the following steps within an ActionScript environment:

1. Instantiate the `MobileButtonHint` object.
2. Add the instance to the display list.
3. Set the necessary properties, such as the button label text.
4. Respond to button state changes as per the visual requirements of your mobile interface.

```actionscript
var mobileButtonHint:MobileButtonHint = new MobileButtonHint();
mobileButtonHint.SetText("Click Me!");
addChild(mobileButtonHint);
```

Remember to handle any additional logic tied to button interaction, including state changes and user input response, within your application's framework.
