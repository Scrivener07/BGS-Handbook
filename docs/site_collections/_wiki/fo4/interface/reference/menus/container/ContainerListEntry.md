---
title: "ContainerListEntry"
---

The `ContainerListEntry` class is a dynamic ActionScript class defined in the file `ContainerListEntry.as`.
This class extends the `ItemListEntry` class, providing the functionalities of an item list with the additional capabilities of a container.

Below is the detailed documentation for `ContainerListEntry.as`:

---

## Class Declaration

**ContainerListEntry**

```actionscript
package {
    public dynamic class ContainerListEntry extends ItemListEntry {
        public function ContainerListEntry() {
            super();
        }
    }
}
```

---

## Constructor

The `ContainerListEntry` class has a single constructor.

### ContainerListEntry()

The constructor for the `ContainerListEntry` class. It calls the constructor of the superclass `ItemListEntry`.

**Example Usage:**

```actionscript
var containerListEntry:ContainerListEntry = new ContainerListEntry();
```

---

## Inheritance

The `ContainerListEntry` class is a subclass of `ItemListEntry`. This implies that an instance of `ContainerListEntry` class inherits all the properties, methods, and events from `ItemListEntry`.

| Subclass                 | Superclass    |
|--------------------------|---------------|
| `ContainerListEntry`     | `ItemListEntry` |

---

## Properties and Methods

As a dynamic class, `ContainerListEntry` can have properties and methods added to it at runtime.
However, by default, this class does not define any additional properties or methods other than those inherited from the `ItemListEntry`.

---

## 📌 Notes

- Since `ContainerListEntry` extends `ItemListEntry`, make sure to familiarize yourself with the `ItemListEntry` class for a better understanding of its capabilities.
- Being a dynamic class allows `ContainerListEntry` to be flexible, which means you can add properties and methods to instances of this class at runtime.
- The class is defined inside the root package, meaning it does not belong to a specific package. This is indicated by the use of the `package { ... }` without a name following `package`.

---

For further details on how to use the `ContainerListEntry` class effectively, refer to the documentation of its superclass `ItemListEntry`, and consider the specific requirements of your project.
