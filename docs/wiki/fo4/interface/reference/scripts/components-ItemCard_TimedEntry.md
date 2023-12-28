# ItemCard_TimedEntry.as Documentation

The file `ItemCard_TimedEntry.as` contains an ActionScript class that extends the functionality of an `ItemCard_Entry` by adding a timer icon to the visual representation of an item card. This class is part of the Components package.

## Overview

The `ItemCard_TimedEntry` class is a display component that specifically deals with items that have a timed aspect to them. It inherits from `ItemCard_Entry` and adds a timer icon to indicate the timed nature of the item.

### Class Details

- **File Name:** ItemCard_TimedEntry.as
- **Package:** Components
- **Inheritance:** Extends `ItemCard_Entry`

## Properties

| Property         | Type          | Access   | Description                        |
|------------------|---------------|----------|------------------------------------|
| `TimerIcon_mc`   | MovieClip     | public   | The movie clip for the timer icon. |
| `TIMER_ORIG_X`   | Number        | private  | The original x position of the timer icon. |

## Constructor

The constructor of `ItemCard_TimedEntry` initializes the class by calling the constructor of its superclass and setting the original x position of the timer icon based on its initial position.

### Code Block

```actionscript
public function ItemCard_TimedEntry() {
    super();
    this.TIMER_ORIG_X = this.TimerIcon_mc.x;
}
```

## Methods

### `PopulateEntry`

This overridden method populates the item entry with data. It positions the timer icon relative to the value text field, ensuring that the icon does not overlap with the text.

#### Parameters

- `aInfoObj:Object` - An object containing the information necessary to populate the entry.

#### Returns

- The method returns the value from the superclass's `PopulateEntry` method.

#### Code Block

```actionscript
override public function PopulateEntry(aInfoObj:Object) : * {
    super.PopulateEntry(aInfoObj);

    var newX:Number = Value_tf.x + Value_tf.getLineMetrics(0).x - this.TimerIcon_mc.width / 2 - 10;
    if(newX < this.TIMER_ORIG_X) {
        this.TimerIcon_mc.x = newX;
    }
}
```

## Class Diagram

```markdown
Components
│
└───ItemCard_Entry (Superclass)
    │
    └───ItemCard_TimedEntry
        ├───TimerIcon_mc (MovieClip)
        └───TIMER_ORIG_X (Number, original x position of TimerIcon_mc)
```

**Note:**
- The `Value_tf` property is assumed to be inherited from the superclass and thus not explicitly declared in this class.
- The `PopulateEntry` method assumes the existence of a text field (`Value_tf`) which is used to display value-related information on the item card.

---

This documentation provides a clear understanding of the `ItemCard_TimedEntry` class and its purpose within the `Components` package. 📘
