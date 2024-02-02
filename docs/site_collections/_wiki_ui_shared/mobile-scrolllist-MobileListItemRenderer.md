# MobileListItemRenderer
`MobileListItemRenderer` is an ActionScript class designed for handling the rendering and interaction logic for list items in a mobile scroll list.
This class extends `MovieClip` and manages user input events such as mouse presses and releases.

## Filename

📄 **MobileListItemRenderer.as**

## Class Definition

```actionscript
package Mobile.ScrollList {
    import flash.display.MovieClip;
    import flash.events.Event;
    import flash.events.MouseEvent;
    import flash.text.TextField;

    public class MobileListItemRenderer extends MovieClip {
        // Class code here...
    }
}
```

## Properties

| Property       | Type        | Access    | Description |
| -------------- | ----------- | --------- | ----------- |
| `textField`    | TextField   | public    | The text field associated with the list item. |
| `_data`        | Object      | protected | Underlying data representing the list item. |
| `_mouseDownPos`| Number      | private   | Stores the mouse down position. |
| `_mouseUpPos`  | Number      | private   | Stores the mouse up position. |
| `DELTA_MOUSE_POS` | int     | private   | Constant representing the allowable delta for mouse position. |

## Methods

### Constructor

**`MobileListItemRenderer`**
```actionscript
public function MobileListItemRenderer() {
    super();
}
```

### Data Access

**`get data()`**
- **Returns:** `Object` - The current `_data` of the list item.

### Reset

**`reset()`**
- Resets the list item and adds necessary event listeners.

### Set Data

**`setData(data:Object)`**
- **Parameters:** `data` - The data object to be set for the list item.
- Sets the `_data` property and updates the visual state if data is not null.

### Set Visual

**`setVisual()`**
- Placeholder function intended to be overridden to define how the list item should visually respond to data changes.

### Event Handlers

**`itemPressHandler(e:MouseEvent)`**
- Handles the mouse down event on a list item.
- **Parameters:** `e` - The MouseEvent object.

**`itemReleaseHandler(e:MouseEvent)`**
- Handles the mouse up event on a list item.
- **Parameters:** `e` - The MouseEvent object.

**`onEnterFrame(e:Event)`**
- Continuously handles the frame update event to track if interactions are outside the list item's boundaries.
- **Parameters:** `e` - The Event object.

### Selection Management

**`selectItem()`**
- Placeholder function for item selection logic.

**`unselectItem()`**
- Placeholder function for item unselection logic.

**`pressItem()`**
- Placeholder function for item press logic.

### Destruction

**`destroy(e:Event)`**
- Cleans up event listeners when the list item is removed from the stage.
- **Parameters:** `e` - The Event object.

## Example Usage

```actionscript
var listItem:MobileListItemRenderer = new MobileListItemRenderer();
listItem.setData({label: "Option 1", value: 1, clickable: true});
listItem.reset();
addChild(listItem);
```

**Note:** The `setVisual()`, `selectItem()`, `unselectItem()`, and `pressItem()` methods are left as placeholders in this class and should be overridden in a subclass to provide the specific visual updates and behaviors required.

---

🌟 **Best Practices:** Always ensure to remove event listeners properly in the `destroy` method to prevent memory leaks. The use of placeholders for visual updates encourages a flexible design that can be adapted to specific use cases.
