# FocusHandlerEvent
`FocusHandlerEvent.as` is an ActionScript class within the `scaleform.clik.events` package.
It is designed to handle focus events in a Scaleform CLIK context, extending the native Flash `Event` class with additional functionality specific to focus management.

## Class Definition

```actionscript
package scaleform.clik.events {
    import flash.events.Event;

    public final class FocusHandlerEvent extends Event {
        // Class body
    }
}
```

## Properties

**Public Static Constants:**

| Constant     | Type   | Description              | Value         |
|--------------|--------|--------------------------|---------------|
| `FOCUS_IN`   | String | Event type for focus in. | "CLIK_focusIn"|
| `FOCUS_OUT`  | String | Event type for focus out.| "CLIK_focusOut"|

**Public Variables:**

| Variable       | Type | Description                        |
|----------------|------|------------------------------------|
| `controllerIdx`| uint | The index of the controller. Default is 0. |

## Methods

### Constructor

Creates an instance of the `FocusHandlerEvent` class.

```actionscript
public function FocusHandlerEvent(param1:String, param2:Boolean = true, param3:Boolean = false, param4:uint = 0) {
    super(param1,param2,param3);
    this.controllerIdx = param4;
}
```

**Parameters:**

| Parameter | Type    | Description                                   | Default Value |
|-----------|---------|-----------------------------------------------|---------------|
| `param1`  | String  | The type of the event.                        | -             |
| `param2`  | Boolean | Whether the event can bubble up the display list. | true         |
| `param3`  | Boolean | Whether the event can be canceled.            | false         |
| `param4`  | uint    | The index of the controller.                  | 0             |

### clone()

Creates a new `FocusHandlerEvent` instance that is a clone of the original instance.

```actionscript
override public function clone() : Event {
    return new FocusHandlerEvent(type,bubbles,cancelable,this.controllerIdx);
}
```

### toString()

Returns a string that contains all the properties of the `FocusHandlerEvent` object.

```actionscript
override public function toString() : String {
    return formatToString("FocusHandlerEvent","type","bubbles","cancelable","controllerIdx");
}
```

## Event Types

- **FOCUS_IN 🟢**: Indicates that an object has gained focus.
- **FOCUS_OUT 🔴**: Indicates that an object has lost focus.

---

This documentation provides a comprehensive overview of the `FocusHandlerEvent` class and its usage within the Scaleform CLIK framework. The class is marked as `final`, indicating that it cannot be extended.
