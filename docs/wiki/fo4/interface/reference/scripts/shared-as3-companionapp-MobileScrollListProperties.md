# MobileScrollListProperties.as Documentation

## Overview

The `MobileScrollListProperties` class defines properties for a mobile scroll list component within the `Shared.AS3.COMPANIONAPP` package. It contains several configurable attributes that affect the appearance and behavior of the scroll list.

## Class Definition

```actionscript
package Shared.AS3.COMPANIONAPP {
    public class MobileScrollListProperties {
        public var linkageId:String;
        public var maskDimension:Number;
        public var spaceBetweenButtons:Number;
        public var scrollDirection:uint;
        public var clickable:Boolean;
        public var reversed:Boolean;

        public function MobileScrollListProperties() {
            super();
        }
    }
}
```

## Properties

Below is a detailed description of each property in the `MobileScrollListProperties` class.

| Property Name | Type | Description |
|---------------|------|-------------|
| `linkageId` | `String` | The identifier used to link to the scroll list item symbols in the library of the flash file. |
| `maskDimension` | `Number` | The dimension of the mask that determines the visible area of the scroll list. |
| `spaceBetweenButtons` | `Number` | The space between individual buttons or items within the scroll list. |
| `scrollDirection` | `uint` | The direction of scrolling, usually represented by an enumeration (e.g., vertical or horizontal). |
| `clickable` | `Boolean` | A flag indicating whether the items in the list are clickable or not. |
| `reversed` | `Boolean` | Specifies if the order of items displayed in the list should be reversed. |

## Example Usage

Below is an example of how you might create an instance of `MobileScrollListProperties` and set its properties. The `linkageId` is set to "DefaultScrollListItemRenderer", indicating the default renderer to be used. The `maskDimension` is set to 100, indicating the size of the visible area. `spaceBetweenButtons` is set at 5, denoting the spacing between items. `scrollDirection` is assigned a hypothetical enumeration value (e.g., `SCROLL_VERTICAL`). The `clickable` property is set to `true`, allowing list items to be interactive, and `reversed` is set to `false`, maintaining the standard order.

```actionscript
var scrollListProps:MobileScrollListProperties = new MobileScrollListProperties();
scrollListProps.linkageId = "DefaultScrollListItemRenderer";
scrollListProps.maskDimension = 100;
scrollListProps.spaceBetweenButtons = 5;
scrollListProps.scrollDirection = SCROLL_VERTICAL; // Assuming SCROLL_VERTICAL is a defined constant
scrollListProps.clickable = true;
scrollListProps.reversed = false;
```

This example creates a scroll list with the specified properties, which can then be utilized as part of a mobile app's user interface.

**Note:** The example assumes the existence of a `SCROLL_VERTICAL` constant or equivalent enumeration that would be defined elsewhere in the application.
