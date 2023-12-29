# ListFilterer
The `ListFilterer` class is part of the **Shared.AS3** package and is used to manage and apply filters to lists.
It extends the `EventDispatcher` class from the Flash API, allowing it to dispatch events when the filter changes.

## Class Definition

```actionscript
package Shared.AS3 {
    import flash.events.Event;
    import flash.events.EventDispatcher;

    public class ListFilterer extends EventDispatcher {
        // ...
    }
}
```

## Constants

| Name            | Value                                       | Description                          |
| --------------- | ------------------------------------------- | ------------------------------------ |
| `FILTER_CHANGE` | `"ListFilterer::filter_change"` | The event type dispatched when the filter changes |

## Properties

- **itemFilter (int)**: The current item filter value.
- **filterArray (Array)**: The array of items to be filtered.

## Methods

- **Constructor**: Initializes the `ListFilterer` with a default item filter value of `4294967295`.

```actionscript
public function ListFilterer() {
    super();
    this.iItemFilter = 4294967295;
}
```

- **get itemFilter**: Returns the current item filter value.

```actionscript
public function get itemFilter() : int {
    return this.iItemFilter;
}
```

- **set itemFilter**: Sets a new item filter value and dispatches a `FILTER_CHANGE` event if it is different from the previous one.

```actionscript
public function set itemFilter(aiNewFilter:int) : * {
    var bdifferent:* = this.iItemFilter != aiNewFilter;
    this.iItemFilter = aiNewFilter;
    if(bdifferent == true) {
        dispatchEvent(new Event(FILTER_CHANGE,true,true));
    }
}
```

- **get filterArray**: Gets the current filter array.

```actionscript
public function get filterArray() : Array {
    return this._filterArray;
}
```

- **set filterArray**: Sets a new filter array.

```actionscript
public function set filterArray(aNewArray:Array) : * {
    this._filterArray = aNewArray;
}
```

- **EntryMatchesFilter**: Checks if a given entry matches the current filter.

```actionscript
public function EntryMatchesFilter(aEntry:Object) : Boolean {
    return aEntry != null && (!aEntry.hasOwnProperty("filterFlag") || (aEntry.filterFlag & this.iItemFilter) != 0);
}
```

- **GetPrevFilterMatch**: Finds the previous index in the filter array that matches the filter starting from a given index.

```actionscript
public function GetPrevFilterMatch(aiStartIndex:int) : int {
    // Implementation
}
```

- **GetNextFilterMatch**: Finds the next index in the filter array that matches the filter starting from a given index.

```actionscript
public function GetNextFilterMatch(aiStartIndex:int) : int {
    // Implementation
}
```

- **ClampIndex**: Adjusts the given index to ensure it matches the filter.

```actionscript
public function ClampIndex(aiStartIndex:int) : int {
    // Implementation
}
```

- **IsFilterEmpty**: Checks if the filter would return any matches.

```actionscript
public function IsFilterEmpty(aiFilter:int) : Boolean {
    // Implementation
}
```

## Events

- **`FILTER_CHANGE`**: Dispatched when the filter is updated to a new value.

## Usage Examples

To use the `ListFilterer`, you would typically instantiate an instance of the class and then use its methods to manage item filters for a list, dispatching events upon changes to allow for reactive UI updates or other functionality.

```actionscript
var listFilterer:ListFilterer = new ListFilterer();
listFilterer.itemFilter = someFilterValue; // Set a filter
listFilterer.addEventListener(ListFilterer.FILTER_CHANGE, onFilterChange);

function onFilterChange(event:Event):void {
    // Handle the filter change
}
```

This class is especially helpful in applications where you need to dynamically filter lists according to user input or other criteria.
