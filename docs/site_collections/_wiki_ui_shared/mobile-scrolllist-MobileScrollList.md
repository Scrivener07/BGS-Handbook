# MobileScrollList
The **MobileScrollList** is a custom list component designed for mobile applications, extending `MovieClip`.
It provides a scrollable list functionality, with support for touch input and rendering list items dynamically.

This component is built for use within a wider framework for building user interfaces in Adobe Flash ActionScript 3.0.

## Class Definition

```actionscript
package Mobile.ScrollList {
    import Shared.AS3.BSScrollingList;
    import Shared.BGSExternalInterface;
    import flash.display.MovieClip;
    import flash.display.Sprite;
    import flash.events.Event;
    import flash.events.MouseEvent;
    import flash.geom.Point;
    import flash.geom.Rectangle;

    public class MobileScrollList extends MovieClip {
        ...
    }
}
```

## Properties

| Property | Type | Description |
|----------|------|-------------|
| `ITEM_SELECT` | `String` | Event string for item selection. |
| `ITEM_RELEASE` | `String` | Event string for item release. |
| `ITEM_RELEASE_OUTSIDE` | `String` | Event string for release outside of an item. |
| `HORIZONTAL` | `uint` | Constant indicating horizontal scroll direction. |
| `VERTICAL` | `uint` | Constant indicating vertical scroll direction. |
| `_availableRenderers` | `Vector.<MobileListItemRenderer>` | A vector of available item renderers. |
| `_data` | `Vector.<Object>` | A vector containing data objects for the list. |
| `_rendererRect` | `Rectangle` | A rectangle defining the size of the renderer. |
| `_bounds` | `Rectangle` | A rectangle defining the scrollable bounds of the list. |
| `_scrollDim` | `Number` | The dimension of the scrollable area. |
| `_deltaBetweenButtons` | `Number` | The space between the list items. |
| `_renderers` | `Vector.<MobileListItemRenderer>` | A vector of item renderers currently in use. |
| `_tempSelectedIndex` | `int` | Temporary selected index during interactions. |
| `_selectedIndex` | `int` | The currently selected index. |
| `_position` | `Number` | The current scroll position. |
| `_direction` | `uint` | The direction of the scroll (horizontal or vertical). |
| `_itemRendererLinkageId` | `String` | The linkage ID for the item renderer MovieClip. |
| `_background` | `Sprite` | A sprite for the background of the list. |
| `_scrollList` | `Sprite` | The sprite container for the list items. |
| `_scrollMask` | `Sprite` | A sprite used as a mask to clip the visible area of the list. |
| `_touchZone` | `Sprite` | A sprite defining the touchable area for scrolling. |
| `_prevIndicator` | `MovieClip` | A movie clip acting as the previous page/scroll indicator. |
| `_nextIndicator` | `MovieClip` | A movie clip acting as the next page/scroll indicator. |
| `_mouseDown` | `Boolean` | Flag indicating if the mouse is currently down. |
| `_velocity` | `Number` | The current velocity of the scrolling list. |
| `_mouseDownPos` | `Number` | The position of the mouse when pressed down. |
| `_mousePressPos` | `Number` | The position of the mouse when an item is pressed. |
| `_hasBackground` | `Boolean` | Flag indicating whether the list has a background. |
| `_backgroundColor` | `int` | The color of the background. |
| `_noScrollShortList` | `Boolean` | Flag indicating if short lists should not be scrollable. |
| `_clickable` | `Boolean` | Flag indicating if list items are clickable. |
| `_endListAlign` | `Boolean` | Flag indicating if the list should align at the end. |
| `_textOption` | `String` | Text option for rendering the list items. |
| `_elasticity` | `Boolean` | Flag indicating if the list has elasticity/bounce effect. |

## Constants

| Constant | Value | Description |
|----------|-------|-------------|
| `EPSILON` | `0.01` | A small number used to determine if the list should stop moving. |
| `VELOCITY_MOVE_FACTOR` | `0.4` | Factor used to calculate the velocity during a move. |
| `VELOCITY_MOUSE_DOWN_FACTOR` | `0.5` | Factor used when the mouse is down. |
| `VELOCITY_MOUSE_UP_FACTOR` | `0.8` | Factor used when the mouse is up. |
| `RESISTANCE_OUT_BOUNDS` | `0.15` | Resistance factor when scrolling out of bounds. |
| `BOUNCE_FACTOR` | `0.6` | Bounce factor used for the elasticity of the list. |
| `DELTA_MOUSE_POS` | `15` | The delta position of the mouse to determine a drag. |

## Methods

### Public Methods

- `MobileScrollList(scrollDimension: Number, deltaBetweenButtons: Number = 0, direction: uint = 1)`
  - Constructor to initialize the scroll list.

- `setData(data: Vector.<Object>): void`
  - Sets the data for the list and initializes it.

- `setScrollIndicators(prevIndicator: MovieClip, nextIndicator: MovieClip): void`
  - Sets the indicators for scrolling.

- `invalidateData(): void`
  - Clears the data and resets the list to an empty state.

- `destroy(): void`
  - Cleans up the list and prepares it for garbage collection.

### Protected Methods

- `setPosition(): void`
  - Updates the position of the scroll list.

- `addRenderer(position: int, data: Object): MobileListItemRenderer`
  - Adds a renderer to a specific position in the list.

- `removeRenderer(position: int): void`
  - Removes a renderer from a specific position in the list.

- `createMask(): void`
  - Creates a mask to clip the scrolling list's visible area.

- `createBackground(): void`
  - Creates the background of the list based on the provided color.

## Event Handlers

- `enterFrameHandler(e: Event): void`
  - Handles the physics of the list's motion on every frame.

- `mouseDownHandler(e: MouseEvent): void`
  - Handles the user's initial touch on the list.

- `mouseMoveHandler(e: MouseEvent): void`
  - Handles the user's dragging motion on the list.

- `mouseUpHandler(e: MouseEvent): void`
  - Handles the end of the user's touch interaction with the list.

## Usage Example

```actionscript
// Creating an instance of MobileScrollList
var scrollList: MobileScrollList = new MobileScrollList(300, 5, MobileScrollList.VERTICAL);

// Setting up data for the list
var listData: Vector.<Object> = new Vector.<Object>();
for (var i: int = 0; i < 10; i++) {
    listData.push({label: "Item " + i});
}

// Assigning data to the list
scrollList.setData(listData);

// Adding the list to the display
addChild(scrollList);
```

## Notes

- This component relies on external interfaces (`Shared.BGSExternalInterface`) and other shared resources (`Shared.AS3.BSScrollingList`), which suggests it is part of a larger framework or application.
- The list supports both vertical and horizontal scrolling, indicated by the direction constants.
- The list has features for handling click and drag events, making it suitable for touch interactions.
- The list implements an elasticity feature to provide a natural feel to the scroll behavior on mobile devices.
