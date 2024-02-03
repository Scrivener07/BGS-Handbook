---
---
# IDataProvider
The `IDataProvider` interface is an essential component within the Scaleform CLIK (Common Lightweight Interface Kit) framework, used for managing data in a structured and consistent way across various user interface elements like lists, dropdown menus, etc.

Below is the detailed documentation for the `IDataProvider` interface.

## Filename

`IDataProvider.as`

## Definition

```actionscript
package scaleform.clik.interfaces {
    import flash.events.Event;

    public interface IDataProvider {
        function get length() : uint;
        function requestItemAt(param1:uint, param2:Function = null) : Object;
        function requestItemRange(param1:int, param2:int, param3:Function = null) : Array;
        function indexOf(param1:Object, param2:Function = null) : int;
        function cleanUp() : void;
        function invalidate(param1:uint = 0) : void;
        function addEventListener(param1:String, param2:Function, param3:Boolean = false, param4:int = 0, param5:Boolean = false) : void;
        function removeEventListener(param1:String, param2:Function, param3:Boolean = false) : void;
        function dispatchEvent(param1:Event) : Boolean;
        function hasEventListener(param1:String) : Boolean;
        function willTrigger(param1:String) : Boolean;
    }
}
```

## Methods Overview

The `IDataProvider` interface consists of the following methods:

| Method | Return Type | Description |
| ------ | ----------- | ----------- |
| **`length`** | `uint` | Read-only. Retrieves the number of items in the data provider. |
| **`requestItemAt`** | `Object` | Requests the item at the specified index, optionally providing a callback function. |
| **`requestItemRange`** | `Array` | Retrieves an array of items within the specified range, optionally providing a callback function. |
| **`indexOf`** | `int` | Returns the index of the specified item, optionally providing a callback function. |
| **`cleanUp`** | `void` | Cleans up internal references to allow for garbage collection. |
| **`invalidate`** | `void` | Invalidates the data provider, optionally at a specific index, causing it to refresh its data. |
| **`addEventListener`** | `void` | Registers an event listener on the data provider. |
| **`removeEventListener`** | `void` | Removes an event listener from the data provider. |
| **`dispatchEvent`** | `Boolean` | Dispatches an event to all registered listeners. |
| **`hasEventListener`** | `Boolean` | Checks if the data provider has a listener for a specific event type. |
| **`willTrigger`** | `Boolean` | Checks if an event of a specific type will trigger. |

## Detailed Method Descriptions

### `length`
- **Description**: Retrieves the number of items that the data provider contains.
- **Return Type**: `uint`

### `requestItemAt(param1:uint, param2:Function = null)`
- **Description**: Requests the data object at the specified index of the data provider. An optional callback function can be provided.
- **Parameters**:
  - `param1`: `uint` - The index of the item to retrieve.
  - `param2`: `Function` _(Optional)_ - A callback function for additional processing.
- **Return Type**: `Object`

### `requestItemRange(param1:int, param2:int, param3:Function = null)`
- **Description**: Retrieves an array of data objects that fall within the specified index range of the data provider. An optional callback function can be provided.
- **Parameters**:
  - `param1`: `int` - The start index of the range.
  - `param2`: `int` - The end index of the range.
  - `param3`: `Function` _(Optional)_ - A callback function for additional processing.
- **Return Type**: `Array`

### `indexOf(param1:Object, param2:Function = null)`
- **Description**: Finds the index of the given item in the data provider. An optional callback function can be provided.
- **Parameters**:
  - `param1`: `Object` - The item to search for.
  - `param2`: `Function` _(Optional)_ - A callback function for additional processing.
- **Return Type**: `int`

### `cleanUp()`
- **Description**: Cleans up the data provider by releasing references to allow for garbage collection.
- **Return Type**: `void`

### `invalidate(param1:uint = 0)`
- **Description**: Invalidates the data provider's data, causing a refresh. Optionally targets a specific index to invalidate.
- **Parameters**:
  - `param1`: `uint` _(Optional)_ - The index to invalidate.
- **Return Type**: `void`

### `addEventListener(param1:String, param2:Function, param3:Boolean = false, param4:int = 0, param5:Boolean = false)`
- **Description**: Adds an event listener to the data provider for a specific event type.
- **Parameters**:
  - `param1`: `String` - The type of event to listen for.
  - `param2`: `Function` - The listener function that processes the event.
  - `param3`: `Boolean` _(Optional)_ - Determines whether the listener works in capture phase.
  - `param4`: `int` _(Optional)_ - The priority level of the event listener.
  - `param5`: `Boolean` _(Optional)_ - Determines whether the listener is weakly referenced.
- **Return Type**: `void`

### `removeEventListener(param1:String, param2:Function, param3:Boolean = false)`
- **Description**: Removes an event listener from the data provider.
- **Parameters**:
  - `param1`: `String` - The type of event to remove.
  - `param2`: `Function` - The listener function to remove.
  - `param3`: `Boolean` _(Optional)_ - Determines whether the listener works in capture phase.
- **Return Type**: `void`

### `dispatchEvent(param1:Event)`
- **Description**: Dispatches an event to all the registered listeners.
- **Parameters**:
  - `param1`: `Event` - The event object to dispatch.
- **Return Type**: `Boolean`

### `hasEventListener(param1:String)`
- **Description**: Checks whether the data provider has any listeners registered for a specific event type.
- **Parameters**:
  - `param1`: `String` - The type of event to query.
- **Return Type**: `Boolean`

### `willTrigger(param1:String)`
- **Description**: Checks whether an event listener exists on the data provider or any of its ancestors for the specified event type.
- **Parameters**:
  - `param1`: `String` - The type of event to query.
- **Return Type**: `Boolean`

📌 **Note**: The `IDataProvider` interface is designed to be implemented by classes that provide data to user interface components, allowing for a flexible and decoupled architecture in the Scaleform CLIK framework.
