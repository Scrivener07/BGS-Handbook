# MobileScrollMovieClip.as Documentation

The `MobileScrollMovieClip` class is part of the `Shared.AS3.COMPANIONAPP` package and provides functionality to add scroll behavior to MovieClip objects on mobile platforms. Below is the detailed documentation of the class along with its methods and properties.

## Class Definition

```as3
package Shared.AS3.COMPANIONAPP {
    import flash.display.MovieClip;
    import flash.events.Event;
    import flash.events.MouseEvent;
    import flash.geom.Point;
    import flash.geom.Rectangle;

    public class MobileScrollMovieClip {
        // ... class members and methods ...
    }
}
```

## Properties

The following table summarizes the private properties of the `MobileScrollMovieClip` class:

| Property | Type | Description |
|----------|------|-------------|
| `_scrollMovieClip` | `MovieClip` | MovieClip instance that will be scrolled. |
| `_scrollMovieClipOrigPosY` | `Number` | Original Y position of the MovieClip before scrolling starts. |
| `_scrollZone` | `Rectangle` | The scrolling zone boundaries. |
| `_activated` | `Boolean` | Indicates if scrolling has been activated. |
| `_mouseDown` | `Boolean` | Indicates if the mouse button is currently pressed down. |
| `_velocity` | `Number` | The speed at which the MovieClip is scrolling. |
| `_prevMouseDownPoint` | `Point` | The previous mouse down location. |
| `EPSILON` | `Number` | Used to determine when the velocity is close enough to zero to stop the animation. |
| `VELOCITY_MOVE_FACTOR` | `Number` | Factor applied to the velocity during mouse move. |
| `VELOCITY_MOUSE_DOWN_FACTOR` | `Number` | Factor applied to velocity when mouse is pressed down. |
| `VELOCITY_MOUSE_UP_FACTOR` | `Number` | Factor applied to velocity when mouse is released. |
| `RESISTANCE_OUT_BOUNDS` | `Number` | Resistance factor applied when scrolling beyond the scroll zone boundaries. |
| `BOUNCE_FACTOR` | `Number` | Factor that determines how much the MovieClip will bounce back when it goes out of bounds. |

## Constructor

**MobileScrollMovieClip**

Initializes the class with the specified MovieClip and scrolling zone.

```as3
public function MobileScrollMovieClip(param1:MovieClip, param2:Rectangle)
```

Parameters:

- `param1:MovieClip`: The MovieClip to be scrolled.
- `param2:Rectangle`: The rectangular zone within which the MovieClip can be scrolled.

## Methods

- **activate**: Enables scrolling functionality.
  ```as3
  public function activate() : void
  ```

- **deactivate**: Disables scrolling functionality.
  ```as3
  public function deactivate() : void
  ```

- **mouseDownHandler**: Handles mouse down events.
  ```as3
  private function mouseDownHandler(param1:MouseEvent) : void
  ```

- **mouseUpHandler**: Handles mouse up events.
  ```as3
  private function mouseUpHandler(param1:MouseEvent) : void
  ```

- **mouseMoveHandler**: Handles mouse move events.
  ```as3
  private function mouseMoveHandler(param1:MouseEvent) : void
  ```

- **enterFrameHandler**: Handles the enter frame events for the MovieClip's animation.
  ```as3
  private function enterFrameHandler(param1:Event) : void
  ```

## Usage Example

📁 Filename: `MobileScrollMovieClip.as`

```as3
// Create a MovieClip instance and define a scrolling zone
var myScrollingMovieClip:MovieClip = new MovieClip();
var myScrollZone:Rectangle = new Rectangle(0, 0, 480, 800);

// Initialize the MobileScrollMovieClip with the movie clip and zone
var mobileScroll:MobileScrollMovieClip = new MobileScrollMovieClip(myScrollingMovieClip, myScrollZone);

// Activate the scrolling behavior
mobileScroll.activate();

// Deactivate when needed
// mobileScroll.deactivate();
```

Note: This class manages events and touch interaction to provide a scrolling experience for MovieClip instances on mobile devices. It includes resistance and bounce back effects when the scrollable content moves beyond the defined boundaries.
