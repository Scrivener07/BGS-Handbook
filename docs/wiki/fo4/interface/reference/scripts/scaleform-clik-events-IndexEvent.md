# IndexEvent Documentation

The `IndexEvent` class extends the `flash.events.Event` class and is part of the `scaleform.clik.events` package.
`IndexEvent` is designed to handle index-based events within the Scaleform CLIK (Common Lightweight Interface Kit) framework, which is often used for UI components in games.

## Class Definition

```actionscript
package scaleform.clik.events {
    import flash.events.Event;

    public class IndexEvent extends Event {
        // ...class definition...
    }
}
```

## Constants

| Constant        | Type   | Description                     |
|-----------------|--------|---------------------------------|
| `INDEX_CHANGE`  | String | Represents the index change event type. |

```actionscript
public static const INDEX_CHANGE:String = "clikIndexChange";
```

## Properties

| Property     | Type   | Default | Description                                 |
|--------------|--------|---------|---------------------------------------------|
| `index`      | int    | -1      | The current index related to the event.     |
| `lastIndex`  | int    | -1      | The previous index before the change.       |
| `data`       | Object | null    | Additional data associated with the event.  |

## Constructor

```actionscript
public function IndexEvent(param1:String, param2:Boolean = false, param3:Boolean = true, param4:int = -1, param5:int = -1, param6:Object = null) {
    super(param1, param2, param3);
    this.index = param4;
    this.lastIndex = param5;
    this.data = param6;
}
```

**Parameters**

- `param1` (**String**): The type of the event.
- `param2` (**Boolean**, optional): Whether the event can bubble up the display list or not. Default is `false`.
- `param3` (**Boolean**, optional): Whether the event can be canceled. Default is `true`.

The additional parameters are for the properties of the `IndexEvent`:

- `param4` (**int**, optional): Represents the current index. Default is `-1`.
- `param5` (**int**, optional): Represents the previous index. Default is `-1`.
- `param6` (**Object**, optional): Additional data that may accompany the event. Default is `null`.

## Methods

### clone()

```actionscript
override public function clone() : Event {
    return new IndexEvent(type, bubbles, cancelable, this.index, this.lastIndex, this.data);
}
```

Returns a copy of the `IndexEvent` instance.

### toString()

```actionscript
override public function toString() : String {
    return formatToString("IndexEvent", "type", "bubbles", "cancelable", "index", "lastIndex", "data");
}
```

Returns a string representation of the `IndexEvent` instance.

## Usage Example

```actionscript
var indexChange:Event = new IndexEvent(IndexEvent.INDEX_CHANGE, true, false, 2, 1, { info: "Sample Data" });
dispatchEvent(indexChange);
```

In the example above, an `IndexEvent` is created with the following parameters:

- Event type as `IndexEvent.INDEX_CHANGE`
- Bubbling set to `true`
- Cancelable set to `false`
- Current index set to `2`
- Last index set to `1`
- Additional data provided as an `Object`

The event is then dispatched to notify listeners about an index change, potentially within a list component or similar interface element.

👉 **Note:** The `IndexEvent` class is specific to the Scaleform CLIK framework and is not a standard part of ActionScript 3 or Flash.

## Conclusion

The `IndexEvent` class is an essential part of any Scaleform CLIK application that requires handling index changes. It extends the core `Event` class and adds specific properties and functionality to work seamlessly within the CLIK framework, providing an interface for event-driven index management.
