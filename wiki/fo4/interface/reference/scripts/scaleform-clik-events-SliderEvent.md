# SliderEvent.as Documentation

## Overview
`SliderEvent` is a custom event class that extends the Flash `Event` class.
It represents events that are specifically related to slider components within the Scaleform CLIK (Common Lightweight Interface Kit) framework.
This event class is typically used to notify about changes in the value of a slider.

Below is an explanation of the `SliderEvent` class, including its constants, properties, and methods.

## Constants

| Constant          | Type    | Description                                       |
| ----------------- | ------- | ------------------------------------------------- |
| **VALUE_CHANGE**  | String  | Identifies the event type for a value change.     |

## Properties

| Property  | Type   | Description                                                                 |
| --------- | ------ | --------------------------------------------------------------------------- |
| **value** | Number | The numeric value associated with the event. Defaults to `-1` when not set. |

## Constructor

```as3
public function SliderEvent(param1:String, param2:Boolean = false, param3:Boolean = true, param4:Number = -1)
```

| Parameter | Type    | Default | Description                                                |
| --------- | ------- | ------- | ---------------------------------------------------------- |
| param1    | String  | -       | The type of event.                                         |
| param2    | Boolean | false   | Specifies whether the event can bubble up the display list. |
| param3    | Boolean | true    | Specifies whether the event can be canceled.               |
| param4    | Number  | -1      | The numeric value of the slider.                           |

Constructs a `SliderEvent` instance with the specified event type, bubble flag, cancelability, and slider value.

### Example Usage:

```as3
var sliderEvent:SliderEvent = new SliderEvent(SliderEvent.VALUE_CHANGE, true, false, 50);
```

## Methods

### clone

```as3
override public function clone() : Event
```

Creates and returns a copy of the `SliderEvent` instance.

### Example Usage:

```as3
var clonedEvent:Event = sliderEvent.clone();
```

### toString

```as3
override public function toString() : String
```

Returns a string representation of the `SliderEvent` instance.

### Example Usage:

```as3
var sliderEventString:String = sliderEvent.toString();
```

## Full Code Block

```as3
package scaleform.clik.events {
    import flash.events.Event;

    public class SliderEvent extends Event {
        public static const VALUE_CHANGE:String = "valueChange";
        public var value:Number = -1;

        public function SliderEvent(param1:String, param2:Boolean = false, param3:Boolean = true, param4:Number = -1) {
            super(param1, param2, param3);
            this.value = param4;
        }

        override public function clone() : Event {
            return new SliderEvent(type, bubbles, cancelable, this.value);
        }

        override public function toString() : String {
            return formatToString("SliderEvent", "type", "bubbles", "cancelable", "value");
        }
    }
}
```

This documentation provides an overview of the `SliderEvent` class, including its functionality and how to use it within the context of Scaleform CLIK.
