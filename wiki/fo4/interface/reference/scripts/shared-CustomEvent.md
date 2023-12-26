# CustomEvent.as Documentation

The `CustomEvent` class is a custom event type that extends the Flash `Event` class, allowing users to pass a parameters object along with the event.

## Table of Contents

- [Class Definition](#class-definition)
- [Constructor](#constructor)
- [Methods](#methods)
- [Example Usage](#example-usage)

## Class Definition

```actionscript
package Shared {
    import flash.events.Event;

    public class CustomEvent extends Event {

        public var params:Object;

        public function CustomEvent(astrType:String, aParams:Object, abBubbles:Boolean = false, abCancelable:Boolean = false) {
            super(astrType,abBubbles,abCancelable);
            this.params = aParams;
        }

        override public function clone() : Event {
            return new CustomEvent(type, this.params, bubbles, cancelable);
        }
    }
}
```

## Constructor

| Parameter     | Type    | Default | Description                               |
|---------------|---------|---------|-------------------------------------------|
| `astrType`    | String  | N/A     | The type of the event.                    |
| `aParams`     | Object  | N/A     | The parameters to pass along with the event. |
| `abBubbles`   | Boolean | `false` | Whether the event should bubble up through the event chain. |
| `abCancelable`| Boolean | `false` | Whether the event can be canceled.        |

The constructor initializes the `CustomEvent` with the specified `astrType`, `aParams`, along with optional `abBubbles` and `abCancelable` properties.

## Methods

- **clone()**
  Returns a copy of the `CustomEvent` instance, including its `type`, `params`, `bubbles`, and `cancelable` properties.

## Example Usage

The following example demonstrates how to create and dispatch a `CustomEvent`:

```actionscript
import Shared.CustomEvent;
import flash.events.EventDispatcher;

var dispatcher:EventDispatcher = new EventDispatcher();
var params:Object = {message: "Hello, World!"};

var customEvent:CustomEvent = new CustomEvent("myCustomEvent", params);

dispatcher.addEventListener("myCustomEvent", function(event:CustomEvent):void {
    trace(event.params.message); // Output: Hello, World!
});

dispatcher.dispatchEvent(customEvent);
```

In this example, we're creating a new instance of `CustomEvent` with the event type `"myCustomEvent"` and a `params` object containing a message. We then add an event listener to an `EventDispatcher` instance, and when the event is dispatched, the listener will trace the message passed in the `params`.
