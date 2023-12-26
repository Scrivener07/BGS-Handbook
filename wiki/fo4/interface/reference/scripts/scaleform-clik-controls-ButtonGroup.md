# ButtonGroup.as Documentation

## Overview
`ButtonGroup` is a class used within the Scaleform CLIK (Common Lightweight Interface Kit) framework.
This class manages a group of buttons, allowing for the tracking and control of states such as which button is selected.
It extends the `EventDispatcher` to provide event-driven functionality to the button group.

## Class Definition
```actionscript
package scaleform.clik.controls {
    import flash.display.DisplayObjectContainer;
    import flash.events.Event;
    import flash.events.EventDispatcher;
    import flash.utils.Dictionary;
    import scaleform.clik.events.ButtonEvent;

    public class ButtonGroup extends EventDispatcher {
        ...
    }
}
```

## Properties and Methods

| **Property/Method** | **Type** | **Description** |
|---------------------|----------|-----------------|
| `groups` | `Dictionary` (static) | A dictionary to hold instances of ButtonGroup objects. |
| `name` | `String` | The name of the ButtonGroup instance. |
| `selectedButton` | `Button` | The currently selected button in the group. |
| `length` | `uint`, getter | Returns the number of buttons in the group. |
| `data` | `Object`, getter | Returns the data of the selected button. |
| `selectedIndex` | `int`, getter | Returns the index of the selected button. |
| `scope` | `DisplayObjectContainer`, getter | Returns scope of the ButtonGroup instance. |
| `ButtonGroup()` | Constructor | Initializes a new ButtonGroup instance. |
| `getGroup()` | `ButtonGroup`, static | Returns a ButtonGroup instance for the specified name and scope. |
| `addButton()` | `void` | Adds a button to the group. |
| `removeButton()` | `void` | Removes a button from the group. |
| `getButtonAt()` | `Button` | Returns the button at the specified index. |
| `setSelectedButtonByIndex()` | `Boolean` | Selects a button by its index. |
| `clearSelectedButton()` | `void` | Clears the currently selected button. |
| `hasButton()` | `Boolean` | Checks if a button is in the group. |
| `toString()` | `String`, override | Returns a string representation of the ButtonGroup. |

### Event Handling Methods (Protected)

| **Method** | **Description** |
|------------|-----------------|
| `handleSelect()` | Handles the selection of a button within the group. |
| `updateSelectedButton()` | Updates the currently selected button. |
| `handleClick()` | Dispatches a click event from a button. |
| `handleRemoved()` | Removes a button from the group when it is removed from the display list. |

## Code Example Usage

### Creating a ButtonGroup Instance

```actionscript
var myButtonGroup:ButtonGroup = new ButtonGroup("group1", myDisplayObjectContainer);
```

### Adding a Button to the Group

```actionscript
var myButton:Button = new Button();
myButtonGroup.addButton(myButton);
```

### Selecting a Button by Index

```actionscript
myButtonGroup.setSelectedButtonByIndex(0); // Selects the first button in the group
```

### Handling Button Selection Changes

```actionscript
myButtonGroup.addEventListener(Event.CHANGE, function(e:Event):void {
    trace("Selected button changed!");
});
```

## Events
The `ButtonGroup` class dispatches the following events:

- `Event.CHANGE`: Dispatched when the selected button in the group changes.
- `ButtonEvent.CLICK`: Re-dispatches the click event from any button in the group.

## Remarks
- A `ButtonGroup` is identified by its `name` property and its scope within a `DisplayObjectContainer`.
- The `groups` dictionary uses weak references to allow for proper garbage collection.

## Emojis Legend
- 🔧 - Method or Action
- 📦 - Property or Member
- 🎉 - Constructor
- 📚 - Event

## Conclusion
The `ButtonGroup` class is a utility for managing button states within a group, providing a streamlined approach to handling user interactions with a collection of buttons in the Scaleform CLIK environment.
