# AnimHolder.as Documentation

The `AnimHolder.as` file contains an ActionScript class that extends the `MovieClip` class from Adobe Flash/Animate.
This dynamic class is used to control animations with specific actions tied to frame labels within the timeline of a Flash animation.

## Class Definition

Below is the class definition for `AnimHolder`, found within the `AnimHolder.as` file.

```actionscript
package {
    import flash.display.MovieClip;

    public dynamic class AnimHolder extends MovieClip {
        public var Menu_mc:Console;

        public function AnimHolder() {
            super();
            addFrameScript(0, this.frame1, 6, this.frame7, 11, this.frame12);
        }

        function frame1() : * {
            stop();
        }

        function frame7() : * {
            this.Menu_mc.ShowComplete();
            stop();
        }

        function frame12() : * {
            this.Menu_mc.HideComplete();
            stop();
        }
    }
}
```

## Constructor

The constructor for `AnimHolder` does the following:

- Calls the constructor of the base `MovieClip` class with `super()`.
- Registers frame scripts with the `addFrameScript` method.

| Frame | Method    | Description                                           |
|-------|-----------|-------------------------------------------------------|
| 0     | frame1    | At frame 1, the animation will stop playing.          |
| 6     | frame7    | At frame 7, calls `ShowComplete` and then stops.      |
| 11    | frame12   | At frame 12, calls `HideComplete` and then stops.     |

## Methods

### frame1()

The `frame1` method is registered to frame 0 of the animation timeline.

```actionscript
function frame1() : * {
    stop();
}
```

- **Purpose**: Stops the animation at the frame it is associated with.

### frame7()

The `frame7` method is linked to frame 6 of the timeline.

```actionscript
function frame7() : * {
    this.Menu_mc.ShowComplete();
    stop();
}
```

- **Purpose**: Calls the `ShowComplete` method on the `Menu_mc` object and then stops the animation.

### frame12()

The `frame12` method is associated with frame 11 on the timeline.

```actionscript
function frame12() : * {
    this.Menu_mc.HideComplete();
    stop();
}
```

- **Purpose**: Executes the `HideComplete` method on the `Menu_mc` object and halts the animation.

## Property

- **Menu_mc**: An instance of the `Console` class which presumably controls UI elements.

**Note**: The asterisk (`*`) as the return type for the frame methods indicates that the return type is untyped, allowing these methods to return any type of value.

---

**💡 Tips**:
This documentation provides an overview of the `AnimHolder` class.
To fully leverage this class, you would need access to the `Console` class definition and understand the context in which `AnimHolder` is used within a Flash application.
