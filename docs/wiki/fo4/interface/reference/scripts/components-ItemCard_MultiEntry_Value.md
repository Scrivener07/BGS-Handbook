# ItemCard_MultiEntry_Value
The `ItemCard_MultiEntry_Value` class is an ActionScript file that is part of a package named `Components`.
This class extends the `ItemCard_Entry` class and includes an additional member, `Icon_mc`, which is a `MovieClip` object.

## Table of Contents
- [Class Overview](#class-overview)
- [Members](#members)
- [Constructor](#constructor)
- [Usage](#usage)

## Class Overview
The **`ItemCard_MultiEntry_Value`** class is designed to represent a specific type of item card entry that includes an icon along with the base features provided by its superclass `ItemCard_Entry`.

```actionscript
package Components {
    import flash.display.MovieClip;

    public class ItemCard_MultiEntry_Value extends ItemCard_Entry {
        public var Icon_mc:MovieClip;

        public function ItemCard_MultiEntry_Value() {
            super();
        }
    }
}
```

## Members

This class includes the following public member:

| Member | Type | Description |
| --- | --- | --- |
| **Icon_mc** | `MovieClip` | A MovieClip object that represents the icon associated with the item card entry. |

## Constructor

The `ItemCard_MultiEntry_Value` class has a constructor that calls the superclass (`ItemCard_Entry`) constructor.

```actionscript
public function ItemCard_MultiEntry_Value() {
    super();
}
```

This constructor does not accept any parameters and is used to initialize the `ItemCard_MultiEntry_Value` object.

## Usage

To use the `ItemCard_MultiEntry_Value` class, you need to create an instance of this class in your ActionScript code. This can be done as follows:

```actionscript
var itemCardValue:ItemCard_MultiEntry_Value = new ItemCard_MultiEntry_Value();
```

Once instantiated, you can access and manipulate the `Icon_mc` MovieClip as needed to represent the desired icon in your item card entry.

### Example:
```actionscript
itemCardValue.Icon_mc = someMovieClipInstance;  // Assign a MovieClip to the Icon_mc property
```

📝 **Note:** To effectively use this class, you will need to have a firm understanding of ActionScript, MovieClip manipulation, and the inheritance principles used in object-oriented programming.
