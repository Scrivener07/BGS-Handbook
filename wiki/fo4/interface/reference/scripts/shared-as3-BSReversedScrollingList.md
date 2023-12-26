# BSReversedScrollingList Documentation

`BSReversedScrollingList.as` is an ActionScript 3.0 class file which defines a custom list element with reversed scrolling functionality.
This class extends the `BSScrollingList` class, providing additional features specific for reversed list behavior.

## Table of Contents

- [Class Overview](#class-overview)
- [Properties](#properties)
- [Methods](#methods)
- [Usage Example](#usage-example)

## Class Overview

**BSReversedScrollingList** is a subclass of **BSScrollingList** that modifies the positioning of list entries so that they are aligned to the bottom of the list container and scroll upwards, as opposed to the typical top-down scrolling.

## Properties

| Property | Type   | Description                                      |
| -------- | ------ | ------------------------------------------------ |
| fTopY    | Number | Represents the Y-coordinate of the topmost entry |

## Methods

### Constructor

- **BSReversedScrollingList**: Initializes a new instance of the class, setting up the default top Y-coordinate to 0.

  ```as
  public function BSReversedScrollingList() {
      super();
      this.fTopY = 0;
  }
  ```

### Accessors

- **topmostY** (getter): Returns the Y-coordinate of the topmost entry in the list.

  ```as
  public function get topmostY() : Number {
      return this.fTopY;
  }
  ```

### Overrides

- **PositionEntries**: Overrides the BSScrollingList's PositionEntries method to arrange the list items starting from the bottom of the list container upwards.

  ```as
  override protected function PositionEntries() : * {
      var _loc4_:BSScrollingListEntry = null;
      var _loc1_:Number = 0;
      var _loc2_:Number = border.y + border.height;
      this.fTopY = _loc2_;

      var _loc3_:int = iListItemsShown - 1;
      while(_loc3_ >= 0) {
          _loc4_ = GetClipByIndex(_loc3_);
          _loc4_.y = _loc2_ - _loc1_ - _loc4_.height;
          _loc1_ = _loc1_ + (_loc4_.height + fVerticalSpacing);
          if(_loc4_.itemIndex != int.MAX_VALUE) {
              this.fTopY = _loc4_.y;
          }
          _loc3_--;
      }
  }
  ```

## Usage Example

The `BSReversedScrollingList` class is designed to be used within a user interface to display list items in a reversed scroll order. Here is a simple example of how you might create an instance of this class:

```as
var reversedScrollingList:BSReversedScrollingList = new BSReversedScrollingList();
addChild(reversedScrollingList);
```

Once instantiated, you can populate the `reversedScrollingList` with data and display it in your UI. The list will show items aligned to the bottom and scroll in the reverse order when the user interacts with it.
