---
---
# InteractiveObjectEx
`InteractiveObjectEx.as` is an ActionScript file that is part of the Scaleform GFX package.
It extends the capabilities of `InteractiveObject` class by incorporating additional functionality related to hit testing and display list ordering.

The file defines a class `InteractiveObjectEx` which in turn extends `DisplayObjectEx`.


## Class: InteractiveObjectEx

`InteractiveObjectEx` inherits from `DisplayObjectEx` and does not introduce additional properties or methods other than its constructor and two pairs of static methods for managing hit-test behavior and topmost level status.

### Constructor

**InteractiveObjectEx()**

Constructs a new `InteractiveObjectEx` instance.

```actionscript
public function InteractiveObjectEx() {
    super();
}
```

### Static Methods

| **Method** | **Description** | **Parameters** | **Return Type** |
|------------|-----------------|----------------|-----------------|
| `setHitTestDisable` | Disables or enables hit testing for the specified interactive object. | `o:InteractiveObject`: The object to modify.<br>`f:Boolean`: The flag to enable or disable hit testing. | `void` |
| `getHitTestDisable` | Retrieves the hit test disabled status for the specified interactive object. | `o:InteractiveObject`: The object to query. | `Boolean` |
| `setTopmostLevel` | Sets the specified interactive object to be at the topmost level. | `o:InteractiveObject`: The object to modify.<br>`f:Boolean`: The flag to set the object to topmost level. | `void` |
| `getTopmostLevel` | Retrieves whether the specified interactive object is at the topmost level. | `o:InteractiveObject`: The object to query. | `Boolean` |

---

### Code Example

The following code snippet shows how to use the `InteractiveObjectEx` class:

```actionscript
import scaleform.gfx.InteractiveObjectEx;
import flash.display.InteractiveObject;

var interactiveObj:InteractiveObject = new InteractiveObject();

// Disable hit testing on the interactive object.
InteractiveObjectEx.setHitTestDisable(interactiveObj, true);

// Check if hit testing is disabled.
var isHitTestDisabled:Boolean = InteractiveObjectEx.getHitTestDisable(interactiveObj);

// Set the interactive object to the topmost level.
InteractiveObjectEx.setTopmostLevel(interactiveObj, true);

// Check if the interactive object is at the topmost level.
var isTopmostLevel:Boolean = InteractiveObjectEx.getTopmostLevel(interactiveObj);
```

Remember that methods `getHitTestDisable` and `getTopmostLevel` are set to always return `false` in the provided code, you might need to implement the actual functionality in your project.

🔔 **Note**: This documentation is based on the provided code and may not reflect the full functionality of the `InteractiveObjectEx` class if additional features are implemented outside of this file or within the Scaleform GFX framework.

---

**Bold** elements like **method names**, **parameters**, and **return types** have been used to enhance the readability of this documentation.
