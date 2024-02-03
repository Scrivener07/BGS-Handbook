---
title: "FavoritesEntry"
categories: fo4 interface menus favorites
---

This documentation details the core functionalities of `FavoritesEntry.as`, a class within the ActionScript 3 (AS3) environment for managing interactive elements often referred to as "favorites entries".
The class inherits from `BSUIComponent` and therefore, provides a user interface element within the context of a larger application—likely a game or a multimedia application.

## Class Overview
`FavoritesEntry` extends `BSUIComponent` to create an interactive element that responds to mouse events and displays associated text for a keyboard shortcut or "quick key".
These entries could correspond to a favorite or hotkey action in a game or application.

### Import Statements
The file begins with several import statements which include necessary classes and components from the ActionScript 3 library.

```as3
import Shared.AS3.BSUIComponent;
import Shared.GlobalFunc;
import Shared.PlatformChangeEvent;
import flash.display.MovieClip;
import flash.events.Event;
import flash.events.MouseEvent;
import flash.text.TextField;
```

### Public Constants
`FavoritesEntry` contains three public string constants for event management.
- **MOUSE_OVER**: Dispatched when the mouse is over the component.
- **MOUSE_LEAVE**: Dispatched when the mouse leaves the component.
- **CLICK**: Dispatched when the component is clicked.

### Public Variables
The class contains public variables that reference the visual and text elements of the entry.

| Variable Name | Type        | Description                          |
|---------------|-------------|--------------------------------------|
| Icon_mc       | MovieClip   | Holds the icon/graphic of the entry. |
| Quickkey_tf   | TextField   | Displays the quickkey text.          |

### Protected Variables
- **_EntryIndex**: A `uint` holding the index of the entry.

### Constructor
The constructor initializes the component and sets up the event listeners for mouse interactions.
It also calculates the `_EntryIndex` based on the name of the instance.

```as3
public function FavoritesEntry() {
    super();
    addEventListener(MouseEvent.MOUSE_OVER, this.onMouseOver);
    addEventListener(MouseEvent.MOUSE_OUT, this.onMouseLeave);
    addEventListener(MouseEvent.CLICK, this.onMousePress);
    this._EntryIndex = uint(this.name.substr(this.name.lastIndexOf("_") + 1));
}
```

### Public Methods

#### redrawUIComponent
This method overrides `redrawUIComponent` from `BSUIComponent`. It updates the `Quickkey_tf` text field based on the `_EntryIndex`.

```as3
override public function redrawUIComponent() : void {
    super.redrawUIComponent();
    // Updates Quickkey_tf based on _EntryIndex
}
```

#### entryIndex (Getter)
Returns the `_EntryIndex` of the entry as a `uint`.

```as3
public function get entryIndex() : uint {
    return this._EntryIndex;
}
```

### Event Handlers

#### onMousePress
Handles the `MouseEvent.CLICK` event by dispatching the custom `CLICK` event.

```as3
public function onMousePress(param1:MouseEvent) : void {
    dispatchEvent(new Event(CLICK, true, true));
}
```

#### onMouseOver
Handles the `MouseEvent.MOUSE_OVER` event by dispatching the custom `MOUSE_OVER` event.

```as3
public function onMouseOver(param1:MouseEvent) : void {
    dispatchEvent(new Event(MOUSE_OVER, true, true));
}
```

#### onMouseLeave
Handles the `MouseEvent.MOUSE_OUT` event by dispatching the custom `MOUSE_LEAVE` event.

```as3
public function onMouseLeave(param1:MouseEvent) : void {
    dispatchEvent(new Event(MOUSE_LEAVE, true, true));
}
```

## Final Notes 📝
The `FavoritesEntry` class provides a clear example of how to create interactive UI components in AS3 that respond to user input and can be customized based on the index they represent.
This can be particularly useful in creating a responsive and intuitive user interface for applications where quick actions or "favorites" are frequently accessed by the user.
