---
title: "ButtonBarMenu"
---

`ButtonBarMenu.as` is an ActionScript class that extends the `IMenu` class.
It is part of a user interface framework where elements such as a button bar and prompt menu panel are used in a menu system.
This class is responsible for managing the button bar menu's behavior and layout.

## Class Definition

The `ButtonBarMenu` class is defined as a dynamic class which allows properties to be added dynamically at runtime.

**Class Hierarchy:** `Object` -> `DisplayObject` -> `InteractiveObject` -> `DisplayObjectContainer` -> `Sprite` -> `MovieClip` -> `IMenu` -> `ButtonBarMenu`

**Filename:** `ButtonBarMenu.as`

## Properties

The class contains two public properties that refer to `MovieClip` objects:

| Property              | Type        | Description                      |
|-----------------------|-------------|----------------------------------|
| `PromptMenuPanel_mc`  | `MovieClip` | References the prompt menu panel |
| `ButtonBarHolder_mc`  | `MovieClip` | References the button bar holder |

## Constructor

The constructor for `ButtonBarMenu` initializes the class instance.

```as3
public function ButtonBarMenu() {
    super();
    trace("[ButtonBarMenu](ctor) Begin");
    this.ButtonBarHolder_mc.ButtonHintBar_mc.bRedirectToButtonBarMenu = false;
    trace("[ButtonBarMenu](ctor) End");
}
```

### Constructor Steps:
1. Calls the constructor of the superclass (`IMenu`).
2. Outputs a trace statement indicating the start of the constructor.
3. Sets the `bRedirectToButtonBarMenu` property of `ButtonHintBar_mc`, which is presumably a child of `ButtonBarHolder_mc`, to `false`.
4. Outputs a trace statement indicating the end of the constructor.

## Overridden Methods

### `onSetSafeRect`

The method `onSetSafeRect` is an override of `IMenu`'s protected method.

```as3
override protected function onSetSafeRect():void {
    trace("[ButtonBarMenu](onSetSafeRect) Begin");
    GlobalFunc.LockToSafeRect(this.ButtonBarHolder_mc, "BC", SafeX, SafeY);
    GlobalFunc.LockToSafeRect(this.PromptMenuPanel_mc, "TL", SafeX, SafeY);
    trace("[ButtonBarMenu](onSetSafeRect) End");
}
```

#### Method Purpose:
This method places the `ButtonBarHolder_mc` and `PromptMenuPanel_mc` components within a safe area on the screen, ensuring they are not obscured or positioned off-screen. It appears to align the components according to predefined screen boundaries.

#### Parameters:
- The method does not accept any parameters directly, but it makes use of presumably inherited `SafeX` and `SafeY` values to determine positioning.

## Usage

The `ButtonBarMenu` class is designed to be used as part of a menu system within a Flash application. Its specific role is to manage a button bar and prompt panel, ensuring that these elements are correctly positioned and behave as expected.

## Notes

- The actual behavior and functionality of the button bar and prompt panel are not fully detailed within this snippet. Additional context from the rest of the application's codebase is needed to fully understand their usage.
- The `trace` statements in the code are useful for debugging but would typically be removed or disabled in a production environment.
- The use of "TL" and "BC" as arguments in `LockToSafeRect` likely refer to alignment constants, such as "Top Left" and "Bottom Center," but this is not explicitly defined in the provided code.

## Dependencies

- `Shared.GlobalFunc` class: Contains utility functions, including `LockToSafeRect`, which is used in this class.
- `Shared.IMenu` class: The base class that `ButtonBarMenu` extends, likely providing common functionality and properties for menu-related classes.

Remember that the actual functionality and utility of the provided code depend heavily on the broader context of the application in which it is used. This documentation provides insight based on the available snippet.
