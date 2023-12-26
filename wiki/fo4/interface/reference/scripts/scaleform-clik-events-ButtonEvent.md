# ButtonEvent.as Documentation

The `ButtonEvent` class is a part of the `scaleform.clik.events` package and is an extension of the `flash.events.Event` class tailored for button-related interactions within the Scaleform CLIK framework.

## Table of Contents

- [Class Definition](#class-definition)
- [Public Constants](#public-constants)
- [Public Properties](#public-properties)
- [Constructor](#constructor)
- [Methods](#methods)
- [Event Usage](#event-usage)

## Class Definition

```actionscript
package scaleform.clik.events {
    import flash.events.Event;

    public class ButtonEvent extends Event {
        // ... (constants, properties, constructor, and methods will be detailed below)
    }
}
```

## Public Constants

The `ButtonEvent` class provides a set of constant values used to identify the specific button event type.

| Constant             | Value            | Description           |
|----------------------|------------------|-----------------------|
| `PRESS`              | "buttonPress"    | Dispatched when a button is pressed. |
| `CLICK`              | "buttonClick"    | Dispatched when a button is clicked. |
| `DRAG_OVER`          | "dragOver"       | Dispatched when a drag-over event occurs on the button. |
| `DRAG_OUT`           | "dragOut"        | Dispatched when a drag-out event occurs on the button. |
| `RELEASE_OUTSIDE`    | "releaseOutside" | Dispatched when the button is released outside of its boundaries. |

## Public Properties

`ButtonEvent` includes additional data about the event context:

| Property        | Type    | Description                               |
|-----------------|---------|-------------------------------------------|
| `controllerIdx` | uint    | The index of the controller.              |
| `buttonIdx`     | uint    | The index of the button.                  |
| `isKeyboard`    | Boolean | Indicates if the event is from a keyboard |
| `isRepeat`      | Boolean | Indicates if the event is a repeat event. |

## Constructor

**ButtonEvent**(param1: String, param2: Boolean = true, param3: Boolean = false, param4: uint = 0, param5: uint = 0, param6: Boolean = false, param7: Boolean = false)

Creates a new `ButtonEvent`.

```actionscript
public function ButtonEvent(param1:String, param2:Boolean = true, param3:Boolean = false, param4:uint = 0, param5:uint = 0, param6:Boolean = false, param7:Boolean = false) {
    super(param1,param2,param3);
    this.controllerIdx = param4;
    this.buttonIdx = param5;
    this.isKeyboard = param6;
    this.isRepeat = param7;
}
```

## Methods

The `ButtonEvent` class overrides the following methods from the `Event` class:

- `clone()`: Creates a copy of the `ButtonEvent` instance.
- `toString()`: Returns a string representation of the `ButtonEvent` instance.

### clone()

Creates a new `ButtonEvent` instance that is a copy of the original instance.

```actionscript
override public function clone() : Event {
    return new ButtonEvent(type,bubbles,cancelable,this.controllerIdx,this.buttonIdx,this.isKeyboard,this.isRepeat);
}
```

### toString()

Returns a string representation of the `ButtonEvent` instance.

```actionscript
override public function toString() : String {
    return formatToString("ButtonEvent","type","bubbles","cancelable","controllerIdx","buttonIdx","isKeyboard","isRepeat");
}
```

## Event Usage

To use the `ButtonEvent`, add event listeners to your button objects for the specific events you are interested in `PRESS`, `CLICK`, `DRAG_OVER`, `DRAG_OUT`, or `RELEASE_OUTSIDE`. Within the event listener, you can access the `ButtonEvent` properties to determine the context of the event, such as the controller and button indices, and whether the event originated from a keyboard or is a repeat event.

**Example:**

```actionscript
myButton.addEventListener(ButtonEvent.CLICK, onButtonClick);

function onButtonClick(event:ButtonEvent):void {
    trace("Button clicked by controller index: " + event.controllerIdx);
}
```
