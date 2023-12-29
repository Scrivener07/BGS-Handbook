# ComponentEvent.as
The `ComponentEvent` class is part of the `scaleform.clik.events` package and is an extension of the `Event` class from the ActionScript 3 (AS3) Flash API.
It is designed to handle state changes and visibility changes of components within the Scaleform CLIK (Common Lightweight Interface Kit) framework.

Below is a detailed breakdown of the `ComponentEvent` class.

## Class Definition

```actionscript
package scaleform.clik.events {
    import flash.events.Event;

    public class ComponentEvent extends Event {
        // Class contents
    }
}
```

## Constants

The `ComponentEvent` class defines the following constants used to represent the types of events it can dispatch:

| Constant        | Value         | Description                            |
|-----------------|---------------|----------------------------------------|
| STATE_CHANGE    | "stateChange" | Dispatched when a component changes state.   |
| SHOW            | "show"        | Dispatched when a component becomes visible. |
| HIDE            | "hide"        | Dispatched when a component becomes invisible.|

These constants are used to identify the specific type of `ComponentEvent` being dispatched.

## Constructor

The constructor for `ComponentEvent` is used to create an instance of the class with the specified parameters.

```actionscript
public function ComponentEvent(param1:String, param2:Boolean = false, param3:Boolean = true) {
    super(param1, param2, param3);
}
```

### Parameters

| Parameter | Type    | Default | Description                                                                                    |
|-----------|---------|---------|------------------------------------------------------------------------------------------------|
| param1    | String  | N/A     | The type of event, which corresponds to one of the defined constants (`STATE_CHANGE`, `SHOW`, `HIDE`). |
| param2    | Boolean | false   | Indicates whether the event can bubble up the display list hierarchy.                          |
| param3    | Boolean | true    | Indicates whether the event can be canceled, preventing the default behavior associated with the event. |

**Example Usage:**

```actionscript
var event:ComponentEvent = new ComponentEvent(ComponentEvent.STATE_CHANGE);
dispatchEvent(event);
```

This example creates a new `ComponentEvent` with the `STATE_CHANGE` event type and dispatches it.

📝 **Note:** This documentation assumes familiarity with the Flash/ActionScript 3.0 event system and the Scaleform CLIK framework.
