---
title: "PlayerListEntry"
---

The `PlayerListEntry` class is a dynamic class that extends the functionality of `ItemListEntry`.
It is designed to represent an entry in a player list, providing the foundational structure needed for player list items while allowing for additional properties and methods to be added dynamically.


## Code Structure

```actionscript
package {
    public dynamic class PlayerListEntry extends ItemListEntry {
        public function PlayerListEntry() {
            super();
        }
    }
}
```


## Class Definition

### **PlayerListEntry**

This dynamic class extends the `ItemListEntry` class.
As it is dynamic, properties and methods can be added to instances of the class at runtime.

| Constructor          | Description                                           |
|----------------------|-------------------------------------------------------|
| `PlayerListEntry()`  | Initializes a new instance of the **PlayerListEntry** class by calling the constructor of the superclass **ItemListEntry**. |

---

## Usage

To use the `PlayerListEntry` class, you can create an instance of it as part of a player list management system.
This instance can then be customized on the fly due to its dynamic nature.

Here's an example of how to instantiate a `PlayerListEntry` object:

```actionscript
var playerEntry:PlayerListEntry = new PlayerListEntry();
```

As a dynamic class, you could then add properties to this instance like so:

```actionscript
playerEntry.name = "PlayerName";
playerEntry.score = 1000;
playerEntry.rank = 1;
```

---

📄 **Filename**: `PlayerListEntry.as`

🚀 **Language**: ActionScript

🛠️ **Superclass**: `ItemListEntry`

🔨 **Subclass**: It is not a subclass but can be used to create more specialized player list entries.

✨ **Dynamic**: Yes

**Bolded Keywords**: `dynamic`, `extends`, `public`, `function`, `super`, `class`, `package`
