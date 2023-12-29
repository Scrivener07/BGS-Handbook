---
title: "FilterHolder"
---

The `FilterHolder` class is a dynamic extension of the `MovieClip` class designed to hold a menu filter within a Flash-based user interface.
This class is responsible for initiating a frame script and handling the completion of an introductory animation for the menu.

Below is a detailed documentation of the `FilterHolder.as` file.

## Class Definition

```actionscript
package {
    import flash.display.MovieClip;

    public dynamic class FilterHolder extends MovieClip {

        // Public variable declaration
        public var Menu_mc:ContainerMenu;

        // Constructor
        public function FilterHolder() {
            super();
            addFrameScript(9, this.frame10);
        }

        // Frame script function
        function frame10() : * {
            this.Menu_mc.onIntroAnimComplete();
            stop();
        }
    }
}
```

## Constructor

The constructor for the `FilterHolder` class executes the base `MovieClip` constructor and adds a frame script on the 10th frame of the timeline.

**Constructor:**

| Method | Description |
| ------ | ----------- |
| `FilterHolder()` | Calls the `super()` method to execute the parent class constructor and adds a frame script at the 9th frame index (which corresponds to the 10th frame due to zero-based indexing). |

## Properties

**Public Variables:**

| Variable | Type | Description |
| -------- | ---- | ----------- |
| `Menu_mc` | `ContainerMenu` | References the `ContainerMenu` object associated with the `FilterHolder`. This menu is expected to have an `onIntroAnimComplete` method which is called once the animation completes. |

## Methods

**Frame Script Function:**

| Function | Return Type | Description |
| -------- | ----------- | ----------- |
| `frame10()` | `*` (Wildcard) | This method is called as a frame script when the playhead reaches the 10th frame of the `FilterHolder` MovieClip timeline. It invokes the `onIntroAnimComplete()` method of `Menu_mc` to signal that the intro animation has completed. It also stops the playhead to prevent further playback of the timeline. |

## Usage

When an instance of `FilterHolder` is created (usually by Flash runtime when a corresponding MovieClip symbol is instantiated), it automatically runs the constructor which adds the frame script.
When the timeline reaches the 10th frame, it executes the `frame10` function, causing the `Menu_mc` to be notified that its introductory animation is complete and then halting the timeline.

**Important Notes**:

- This class must be associated with a MovieClip symbol that has at least 10 frames in its timeline for the frame script to work properly.
- The `Menu_mc` instance should be properly defined and have an `onIntroAnimComplete` method to avoid runtime errors.

## 📝 Final Remarks

The `FilterHolder` class is a simple yet specific class designed for a particular use case within a Flash application.
Proper initialization and usage are crucial for its functionality.

**Remember to:**

- Ensure that all necessary assets and scripts are linked correctly.
- Use a naming convention that matches the expected `Menu_mc` for consistency within the codebase.
- Test the animation and the triggering of the `onIntroAnimComplete` method to confirm proper timeline control.

👉 **Bold elements** indicate key aspects and components within the code and the documentation.
