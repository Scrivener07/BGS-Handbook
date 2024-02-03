---
title: "ContainerList"
categories: fo4 interface menus container
---

`ContainerList.as` is an ActionScript file that defines a dynamic class named `ContainerList`.
This class extends from a base class called `ItemList`.

The `ContainerList` class is meant to represent a list of container-like objects, potentially used in a graphical user interface or a game inventory system.

Below is the detailed documentation for the `ContainerList` class.

## Class Definition

The `ContainerList` class is a dynamic class, meaning that properties can be added to instances of this class at runtime.

### `ContainerList` Class

| Property/Method | Type     | Description                          | Access   |
|-----------------|----------|--------------------------------------|----------|
| Constructor     | Function | Initializes a new instance of the class. | Public   |

### Constructor

**Syntax:**

```actionscript
public function ContainerList()
```

**Description:**

The constructor for the `ContainerList` class. It calls the superclass (`ItemList`) constructor during its initialization process.

**Example Usage:**

```actionscript
var containerList:ContainerList = new ContainerList();
```

## Code Block

Here is the complete code for `ContainerList.as`:

```actionscript
package {
    public dynamic class ContainerList extends ItemList {
        public function ContainerList() {
            super();
        }
    }
}
```

## Usage

To use the `ContainerList` class, you must first import it (if it's not in the same package as the class you're using it from), then create an instance of `ContainerList`.

**Example:**

```actionscript
import ContainerList;

var myList:ContainerList = new ContainerList();
// myList can now hold container items
```

### Inheritance Chain

`ContainerList` inherits from `ItemList`, which means it has access to all the properties, methods, and events of the `ItemList` unless overridden.

**Bold Key Elements:**

- **dynamic**
- **ContainerList**
- **ItemList**
- **constructor**

📝 Note: Since `ContainerList` is a dynamic class, it can be customized further at runtime, which makes it versatile for various applications.
