---
title: "CursorMenu"
categories: fo4 interface menus cursor
---

# CursorMenu Documentation
`CursorMenu.as` is an ActionScript file which defines a `CursorMenu` class that extends the `MovieClip` class.
This class is designed to create a custom cursor that follows mouse movements on the stage within a Flash application.

Below is the detailed documentation for the `CursorMenu` class.


## Class Definition

### **CursorMenu**

| Modifier      | Type            | Description                                                          |
|---------------|-----------------|----------------------------------------------------------------------|
| `public`      | `class`         | Defines the `CursorMenu` class inheriting from the `MovieClip` class. |


## Constructor

### **CursorMenu**
Initializes a new instance of the `CursorMenu` class, setting its initial position off-screen and adding event listeners for when the cursor is added to or removed from the display stage.
```actionscript
public function CursorMenu() {
    super();
    this.x = -100;
    this.y = -100;
    addEventListener(Event.ADDED_TO_STAGE, this.onStageInit);
    addEventListener(Event.REMOVED_FROM_STAGE, this.onStageDestruct);
}
```


## Properties

### **Cursor_mc**

| Modifier      | Type            | Name        | Description                                     |
|---------------|-----------------|-------------|-------------------------------------------------|
| `public`      | `MovieClip`     | `Cursor_mc` | A `MovieClip` instance representing the cursor. |


## Methods

### **onStageInit**
Callback method that is called when `CursorMenu` is added to the stage. It disables the stage's focus rectangle and adds a listener for `MOUSE_MOVE` events to track mouse movement.
```actionscript
private function onStageInit(param1:Event) : * {
    stage.stageFocusRect = false;
    stage.addEventListener(MouseEvent.MOUSE_MOVE, this.onMouseMovement);
}
```


### **onStageDestruct**
Callback method that is called when `CursorMenu` is removed from the stage. It removes the listener for `MOUSE_MOVE` events.
```actionscript
private function onStageDestruct(param1:Event) : * {
    stage.removeEventListener(MouseEvent.MOUSE_MOVE, this.onMouseMovement);
}
```


### **onMouseMovement**
Callback method that updates the cursor's position to the current mouse coordinates on the stage.
```actionscript
private function onMouseMovement(param1:Event) : * {
    this.x = stage.mouseX;
    this.y = stage.mouseY;
}
```








## Usage
- Instantiate `CursorMenu` within your Flash application to have a custom cursor that follows the user's mouse movement across the stage.
- Make sure to add `CursorMenu` to the display list for it to become visible and active.

## 📁 File Structure

The file `CursorMenu.as` is structured as follows:

- Import statements for required classes (e.g., `flash.display.MovieClip`, `flash.events.Event`, `flash.events.MouseEvent`).
- Definition of the `CursorMenu` class which contains:
  - A public property `Cursor_mc` of type `MovieClip`.
  - A constructor that initializes the class.
  - Private methods (`onStageInit`, `onStageDestruct`, and `onMouseMovement`) to manage the cursor behavior in respect to mouse movement.

## Example Code Block

```actionscript
package {
    import flash.display.MovieClip;
    import flash.events.Event;
    import flash.events.MouseEvent;

    public class CursorMenu extends MovieClip {
        public var Cursor_mc:MovieClip;

        public function CursorMenu() {
            super();
            this.x = -100;
            this.y = -100;
            addEventListener(Event.ADDED_TO_STAGE, this.onStageInit);
            addEventListener(Event.REMOVED_FROM_STAGE, this.onStageDestruct);
        }

        private function onStageInit(param1:Event) : * {
            stage.stageFocusRect = false;
            stage.addEventListener(MouseEvent.MOUSE_MOVE, this.onMouseMovement);
        }

        private function onStageDestruct(param1:Event) : * {
            stage.removeEventListener(MouseEvent.MOUSE_MOVE, this.onMouseMovement);
        }

        private function onMouseMovement(param1:Event) : * {
            this.x = stage.mouseX;
            this.y = stage.mouseY;
        }
    }
}
```
