---
title: "MessageHolder"
categories: fo4 interface menus buttonbar
---

**MessageHolder.as** is an ActionScript file that defines a dynamic class named `MessageHolder` which extends the `BSUIComponent` class from the `Shared.AS3` package.

## Class Definition
The `MessageHolder` class is a dynamic class that is likely used for holding and displaying messages in a user interface component within a broader system, possibly a game or application that uses Scaleform GFx for its UI.

Below is the structure of the `MessageHolder` class:

```actionscript
package {
    import Shared.AS3.BSUIComponent;

    public dynamic class MessageHolder extends BSUIComponent {

        public function MessageHolder() {
            super();
            trace("[MessageHolder](ctor)");
        }

    }
}
```

## Constructor Details
The constructor of the `MessageHolder` class performs initialization tasks.

### 📝 Table: Constructor Details

| Constructor | Description |
| ----------- | ----------- |
| `MessageHolder()` | Initializes a new instance of the `MessageHolder` class, calls the constructor of the base class `BSUIComponent`, and traces a message indicating the creation of the `MessageHolder` object. |

### Constructor Code

```actionscript
public function MessageHolder() {
    super();
    trace("[MessageHolder](ctor)");
}
```

## Usage
To use the `MessageHolder` class, you would need to create an instance of it within your ActionScript code.
It is likely that this class is part of a user interface system, where messages are managed and displayed to the user.

## Additional Information

- The `MessageHolder` class is marked as `dynamic`, which means instances of this class can have variables added to them at runtime.
- The `trace` statement within the constructor is used for debugging purposes to log output to the console, signaling the creation of a `MessageHolder` instance.

## 📌 Important Notes

- **Filename:** The filename for this class is `MessageHolder.as`.
- **BSUIComponent:** The `MessageHolder` class extends `BSUIComponent`, which suggests it inherits properties and methods for user interface components.
- **Package structure:** The class is defined in the root package, as there is no explicit package name provided.

If more information about the base class `BSUIComponent` and the wider system in which `MessageHolder` operates is needed, it would be helpful to look at the full application or game codebase.
