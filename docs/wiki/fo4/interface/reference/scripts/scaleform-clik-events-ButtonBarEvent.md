# ButtonBarEvent
ButtonBarEvent.as is a custom ActionScript event class defined within the `scaleform.clik.events` package.
This class extends the native Flash `Event` class and is specifically designed for events related to button selections in a button bar control.

## Table of Contents

- [Event Name](#event-name)
- [Properties](#properties)
- [Constructor](#constructor)
- [Methods](#methods)
- [Usage Example](#usage-example)

## Event Name

| Event Constant     | Value         | Description                             |
|--------------------|---------------|-----------------------------------------|
| `BUTTON_SELECT`    | "buttonSelect"| Dispatched when a button is selected.   |

## Properties

| Property  | Type    | Description                                           |
|-----------|---------|-------------------------------------------------------|
| `index`   | `int`   | The index of the selected button (default -1).        |
| `renderer`| `Button`| The Button instance that has been selected (default null). |

## Constructor

The constructor initializes a new instance of the `ButtonBarEvent` class with optional parameters for customization.

```actionscript
public function ButtonBarEvent(
    param1:String,
    param2:Boolean = false,
    param3:Boolean = true,
    param4:int = -1,
    param5:Button = null
)
{
    super(param1, param2, param3);
    this.index = param4;
    this.renderer = param5;
}
```

**Parameters:**

- **param1** (`String`): The type of event.
- **param2** (`Boolean`): Determines whether the event can bubble up the display list hierarchy (default `false`).
- **param3** (`Boolean`): Determines whether the event can be canceled (default `true`).
- **param4** (`int`): The index of the button (default `-1`).
- **param5** (`Button`): The Button instance that has been selected (default `null`).

## Methods

### clone
Creates a copy of the `ButtonBarEvent` instance.

```actionscript
override public function clone(): Event
{
    return new ButtonBarEvent(type, bubbles, cancelable, this.index, this.renderer);
}
```

### toString
Returns a string representation of the `ButtonBarEvent`.

```actionscript
override public function toString(): String
{
    return formatToString("ButtonBarEvent", "type", "bubbles", "cancelable", "index", "renderer");
}
```

## Usage Example

Here is an example of how the `ButtonBarEvent` might be dispatched within an ActionScript application:

```actionscript
// Create a new instance of ButtonBarEvent indicating a button selection.
var event:ButtonBarEvent = new ButtonBarEvent(ButtonBarEvent.BUTTON_SELECT, false, true, selectedIndex, selectedButton);

// Dispatch the event.
dispatchEvent(event);
```

In this example, `selectedIndex` and `selectedButton` should be replaced with the actual index and `Button` instance that are relevant to the event occurrence.
