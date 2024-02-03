---
---
# EventWithParams
The `EventWithParams` class, located in the `Mobile.ScrollList` package, is an extension of the Flash `Event` class.
This class allows users to create events with additional parameters that can be passed along with the event itself.

## Class Details

- **Filename:** EventWithParams.as
- **Package:** Mobile.ScrollList
- **Extends:** flash.events.Event

## Constructor

```actionscript
public function EventWithParams(_type:String, _params:Object = null, _bubbles:Boolean = false, _cancelable:Boolean = false)
```

The constructor initializes a new `EventWithParams` instance.

| Parameter     | Type    | Default | Description                            |
|---------------|---------|---------|----------------------------------------|
| `_type`       | String  | -       | The event type.                        |
| `_params`     | Object  | null    | The optional parameters to pass along. |
| `_bubbles`    | Boolean | false   | Indicates if the event bubbles up.     |
| `_cancelable` | Boolean | false   | Indicates if the event can be canceled.|

## Properties

- **params:** `Object`

  An object containing the parameters that are passed along with the event.

## Methods

### clone

```actionscript
override public function clone() : Event
```

Creates a clone of the `EventWithParams` instance.

**Returns:** A new `EventWithParams` object with the same properties as the original.

### toString

```actionscript
override public function toString() : String
```

Returns a string representation of the `EventWithParams` instance.

**Returns:** A string containing the class name and properties of the instance.

## Example Usage

Here's a brief example of how you might use the `EventWithParams` class:

```actionscript
var event:EventWithParams = new EventWithParams("myCustomEvent", {message: "Hello World"}, true, false);
dispatchEvent(event);
```

In this example, an instance of `EventWithParams` is created with a type of `"myCustomEvent"` and a parameters object containing a single key-value pair. The event is set to bubble and not to be cancelable. Then, the event is dispatched.

🔍 **Note:** The `EventWithParams` class allows for more flexible event handling by attaching additional data to events, thus making it easier to pass extra information to event listeners without modifying the event class itself.
