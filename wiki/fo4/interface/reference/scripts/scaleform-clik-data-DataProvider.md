# DataProvider Documentation

## Overview

`DataProvider` is a dynamic class that extends the `Array` class and implements the `IDataProvider` and `IEventDispatcher` interfaces.
It serves as a data storage system capable of dispatching events when data changes.
This class is part of the `scaleform.clik.data` package and is typically used within the Scaleform CLIK (Common Lightweight Interface Kit) UI framework for Adobe Flash.

Below is a comprehensive documentation for the `DataProvider` class, contained in the `DataProvider.as` file.

## Class Definition

```actionscript
package scaleform.clik.data {
    import flash.events.Event;
    import flash.events.EventDispatcher;
    import flash.events.IEventDispatcher;

    import scaleform.clik.interfaces.IDataProvider;

    public dynamic class DataProvider extends Array implements IDataProvider, IEventDispatcher {
        // ...
    }
}
```

## Constructors

### `DataProvider(param1:Array = null)`

Initializes a new instance of the `DataProvider` class. Optionally accepts an array of items to parse as the data source.

| Parameter | Type  | Description                          | Default |
|-----------|-------|--------------------------------------|---------|
| `param1`  | Array | The initial array of data. | `null`  |

## Methods

### `indexOf(param1:Object, param2:Function = null) : int`

Returns the index of the specified item within the data provider. An optional callback can be supplied.

| Parameter | Type     | Description                                          | Default |
|-----------|----------|------------------------------------------------------|---------|
| `param1`  | Object   | The item to search for in the data provider.         |         |
| `param2`  | Function | An optional callback function to execute with index. | `null`  |

### `requestItemAt(param1:uint, param2:Function = null) : Object`

Requests the item at the specified index with an optional callback.

| Parameter | Type     | Description                                        | Default |
|-----------|----------|----------------------------------------------------|---------|
| `param1`  | uint     | The index of the item to retrieve.                 |         |
| `param2`  | Function | An optional callback function to execute with item.| `null`  |

### `requestItemRange(param1:int, param2:int, param3:Function = null) : Array`

Requests a range of items from the data provider with an optional callback.

| Parameter | Type     | Description                                          | Default |
|-----------|----------|------------------------------------------------------|---------|
| `param1`  | int      | The start index of the range.                        |         |
| `param2`  | int      | The end index of the range.                          |         |
| `param3`  | Function | An optional callback function to execute with range. | `null`  |

### `cleanUp() : void`

Clears all items from the data provider.

### `invalidate(param1:uint = 0) : void`

Dispatches a change event to notify listeners that the data provider has been updated.

| Parameter | Type  | Description                               | Default |
|-----------|-------|-------------------------------------------|---------|
| `param1`  | uint  | Unused parameter, reserved for future use. | `0`     |

### `setSource(param1:Array) : void`

Sets the source of the data provider to the supplied array.

| Parameter | Type  | Description                       | Default |
|-----------|-------|-----------------------------------|---------|
| `param1`  | Array | The new source array for the data.|         |

### `toString() : String`

Returns a string representation of the `DataProvider`.

### `addEventListener(param1:String, param2:Function, param3:Boolean = false, param4:int = 0, param5:Boolean = false) : void`

Adds an event listener to the internal event dispatcher.

### `removeEventListener(param1:String, param2:Function, param3:Boolean = false) : void`

Removes an event listener from the internal event dispatcher.

### `dispatchEvent(param1:Event) : Boolean`

Dispatches an event through the internal event dispatcher.

### `hasEventListener(param1:String) : Boolean`

Checks if the internal event dispatcher has a listener for the specified event.

### `willTrigger(param1:String) : Boolean`

Checks if an event of the specified type will trigger.

## Protected Methods

### `parseSource(param1:Array) : void`

Parses the source array and copies its contents to the data provider.

| Parameter | Type  | Description                        | Default |
|-----------|-------|------------------------------------|---------|
| `param1`  | Array | The source array to parse. |         |

## Event Constants

The `DataProvider` class dispatches the following event:

| Event         | Description                                 |
|---------------|---------------------------------------------|
| `Event.CHANGE` | Dispatched when the data provider changes. |

## Example Usage

```actionscript
var myDataProvider:DataProvider = new DataProvider([1, 2, 3]);
myDataProvider.addEventListener(Event.CHANGE, onDataChange);
myDataProvider.setItemAt(0, "New item");
myDataProvider.removeItemAt(1);

function onDataChange(event:Event):void {
    trace("The data provider has changed.");
}
```

Remember that `DataProvider` can be used dynamically, meaning you can add properties to instances of this class at runtime.
Moreover, due to its design, you might consider using event listeners to handle updates in data, especially for data-binding scenarios in user interfaces.

📄 **File**: DataProvider.as
📦 **Package**: scaleform.clik.data
🔧 **Implements**: `IDataProvider`, `IEventDispatcher`
