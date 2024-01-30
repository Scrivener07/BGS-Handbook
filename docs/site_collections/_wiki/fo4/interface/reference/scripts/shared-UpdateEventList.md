# UpdateEventList

## Filename

```plaintext
UpdateEventList.as
```

## Package

```plaintext
Shared
```

## Imports

- `flash.events.Event`
- `Shared.AS3.BSScrollingList`

## Class Definition

The `UpdateEventList` is a custom class that extends `BSScrollingList`.
It provides functionality to dispatch an event when the list is updated.

```actionscript
package Shared {
    import flash.events.Event;
    import Shared.AS3.BSScrollingList;

    public class UpdateEventList extends BSScrollingList {
        // ...
    }
}
```

## Constructors

### `UpdateEventList`

Initializes the `UpdateEventList` object by calling the constructor of the superclass `BSScrollingList`.

```actionscript
public function UpdateEventList() {
    super();
}
```

## Functions

### `RequestUpdate`

Requests an update to the `UpdateEventList`. If the requested index is the currently selected index, it dispatches a `"ListUpdated"` event.

**Parameters:**

| Parameter | Type  | Description                     |
|-----------|-------|---------------------------------|
| `index`   | `uint` | The index requested to be updated. |

**Returns:** `*` - Unspecified return type

#### Code

```actionscript
public function RequestUpdate(index:uint):* {
    if(stage.focus == this) {
        if(selectedIndex == index) {
            dispatchEvent(new Event("ListUpdated", true, true));
        } else {
            selectedIndex = index;
        }
        InvalidateData();
    }
}
```

### `doSetSelectedIndex`

Overrides the `doSetSelectedIndex` method from `BSScrollingList`. If the new index is different from the current selected index, it dispatches a `"ListUpdated"` event.

**Parameters:**

| Parameter | Type  | Description                 |
|-----------|-------|-----------------------------|
| `index`   | `int`  | The index to be set as selected. |

**Returns:** `*` - Unspecified return type

#### Code

```actionscript
override protected function doSetSelectedIndex(index:int):* {
    var condition:* = index != selectedIndex;
    super.doSetSelectedIndex(index);
    if(condition) {
        dispatchEvent(new Event("ListUpdated", true, true));
    }
}
```

## Events

- **ListUpdated**: Dispatched when the list is updated either through `RequestUpdate` or `doSetSelectedIndex`.

## Usage

To utilize the `UpdateEventList`:

1. **Instantiate** the `UpdateEventList`.
2. **Call** `RequestUpdate` with the index that needs to be updated.
3. **Listen** for the "ListUpdated" event to perform actions after the list is updated.

## Example

Below is an example of how to use the `UpdateEventList` class:

```actionscript
// Create an instance of UpdateEventList
var myUpdateEventList:UpdateEventList = new UpdateEventList();

// Add an event listener for the "ListUpdated" event
myUpdateEventList.addEventListener("ListUpdated", function(event:Event):void {
    trace("The list has been updated!");
});

// Request to update the list at index 2
myUpdateEventList.RequestUpdate(2);
```

When the `RequestUpdate` function is called, if the index matches the currently selected index, the "ListUpdated" event is dispatched and subsequently listened to by the event listener, triggering the anonymous function to trace a message.
