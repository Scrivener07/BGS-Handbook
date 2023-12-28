# ConditionBoy.as Documentation

This is the vault-boy which visually displays your limb conditions.
The `ConditionClips` are used by the `ConditionBoy` component.

The `ConditionBoy.as` file is part of the `Shared.AS3` package and dynamically extends the `BSUIComponent` class.
It is responsible for managing the visual representation of body and head condition states in a user interface.

Below is the documentation for `ConditionBoy` class with details on its properties, constructors, and methods.

---

## Table of Contents

- [Class Overview](#class-overview)
- [Properties](#properties)
- [Constructor](#constructor)
- [Public Methods](#public-methods)
- [Private Methods](#private-methods)

---

## Class Overview

**Package:** `Shared.AS3`
**Imports:**
- `Shared.AS3.COMPANIONAPP.PipboyLoader`
- `flash.display.MovieClip`
- `flash.events.Event`
- `flash.net.URLRequest`
- `flash.system.ApplicationDomain`
- `flash.system.LoaderContext`

**Description:**
The `ConditionBoy` class handles loading and updating the visual representation of body and head conditions.
It uses loaders to load SWF content dynamically and updates the UI components accordingly.

---

## Properties

| Property | Type | Description |
| -------- | ---- | ----------- |
| `BodyClip_mc` | `MovieClip` | Clip representing the body condition. |
| `HeadClip_mc` | `MovieClip` | Clip representing the head condition. |
| `_BodyFlags` | `uint` | Flags representing the current body conditions. |
| `_HeadFlags` | `uint` | Flags representing the current head conditions. |
| `_UpdateHead` | `Boolean` | Indicates whether the head needs an update. |
| `_UpdateBody` | `Boolean` | Indicates whether the body needs an update. |
| `Condition_Head_Loader` | `PipboyLoader` | Loader for the head condition SWF. |
| `Condition_Body_Loader` | `PipboyLoader` | Loader for the body condition SWF. |

---

## Constructor

**ConditionBoy()**

Initializes a new instance of the `ConditionBoy` class. It sets up the loader for the head condition SWF and starts loading it.

```actionscript
public function ConditionBoy() {
    super();
    // ... (initialization code) ...
}
```

---

## Public Methods

**set BodyFlags(param1:uint): void**

Sets the condition flags for the body and, if different from the current flags, loads the corresponding body condition SWF.

```actionscript
public function set BodyFlags(param1:uint): void {
    // ... (method code) ...
}
```

**set HeadFlags(param1:uint): void**

Sets the condition flags for the head and marks the component as dirty if the flags have changed, triggering an update.

```actionscript
public function set HeadFlags(param1:uint): void {
    // ... (method code) ...
}
```

**redrawUIComponent(): void**

Redraws the UI components if the head or body has been updated. This method is an override from the parent class `BSUIComponent`.

```actionscript
override public function redrawUIComponent(): void {
    // ... (method code) ...
}
```

---

## Private Methods

**onConditionBodyLoadComplete(param1:Event): \***

Handles the event when the body condition SWF has finished loading.

```actionscript
private function onConditionBodyLoadComplete(param1:Event): * {
    // ... (method code) ...
}
```

**onConditionHeadLoadComplete(param1:Event): \***

Handles the event when the head condition SWF has finished loading.

```actionscript
private function onConditionHeadLoadComplete(param1:Event): * {
    // ... (method code) ...
}
```

---

## Usage Example

👉 **To use the `ConditionBoy` class:**

1. Create an instance of the class.
2. Set the `BodyFlags` and `HeadFlags` properties to update the body and head conditions.
3. The component will automatically handle the loading of SWF files and update the UI elements.

---

**Important:** The `ConditionBoy` class is a crucial part of the user interface, handling dynamic content updates based on the character's condition states. It's essential for developers working with this class to understand the asynchronous nature of SWF loading and the corresponding event handling to prevent memory leaks and ensure smooth UI updates.

**💡 Tip:** Always remove event listeners after their use to avoid potential memory leaks and ensure a clean update cycle.
