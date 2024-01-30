# InvalidationType
This documentation provides an overview of the `InvalidationType` class contained within the `InvalidationType.as` file.
This class is part of the `scaleform.clik.constants` package and includes a series of constant values representing different types of invalidation states that can be used within the Scaleform CLIK framework.

## Class Definition

```actionscript
package scaleform.clik.constants {
    public class InvalidationType {
        // Class constants
    }
}
```

## Constants

The `InvalidationType` class defines several static constant values. Each of these constants represents a specific type of invalidation used to indicate what aspects of a component need to be revalidated and potentially redrawn. Below is a table of all the constants:

| Constant         | Value            | Description                       |
|------------------|------------------|-----------------------------------|
| **ALL**          | `"all"`          | Indicates all properties need to be invalidated. |
| **SIZE**         | `"size"`         | Indicates the size of the component has changed. |
| **STATE**        | `"state"`        | Indicates the state of the component has changed (e.g., enabled, disabled). |
| **DATA**         | `"data"`         | Indicates the data of the component has changed. |
| **SETTINGS**     | `"settings"`     | Indicates the settings of the component have changed. |
| **RENDERERS**    | `"renderers"`    | Indicates the renderers of the component have changed. |
| **SCROLL_BAR**   | `"scrollBar"`    | Indicates the scroll bar properties have changed. |
| **SELECTED_INDEX** | `"selectedIndex"` | Indicates the selected index of a component has changed. |

## Constructor

The `InvalidationType` class constructor is defined as follows:

```actionscript
public function InvalidationType() {
    super();
}
```

The constructor does not perform any specific function other than calling its superclass constructor. This class is not intended to be instantiated but used for its static constants.

## Example Usage

The constants defined in the `InvalidationType` class are typically used within component classes that extend `UIComponent`. Here's a basic example of how these constants might be used in a component's `invalidate` method:

```actionscript
public function updateSize():void {
    invalidate(InvalidationType.SIZE);
    // Additional logic to handle size changes
}
```

In the example above, when the `updateSize` method is called, it indicates that the size-related properties of the component have become invalid. The component's invalidation mechanism will then know to revalidate and update the component's size during the next validation cycle.
