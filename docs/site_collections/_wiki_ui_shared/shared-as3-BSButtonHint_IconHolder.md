---
---
# BSButtonHint_IconHolder
The ActionScript file `BSButtonHint_IconHolder.as` contains a dynamic class extending the `MovieClip` class from the Flash library.
It is designed to manage an icon within a button hint component, providing functionality to control animation frames.

**Note:** _This class is UNUSED as the functionality has been re-implemented using frame scripts according to the developers’ note (Scrivener07)._


## Class Definition

### `BSButtonHint_IconHolder`

| Attribute         | Type       | Description                                           |
|-------------------|------------|-------------------------------------------------------|
| `IconAnimInstance`| `MovieClip`| A `MovieClip` instance variable to hold the icon animation.|

This dynamic class is responsible for controlling the icon animation within button hints.

## Constructor

```actionscript
public function BSButtonHint_IconHolder() {
    super();
    addFrameScript(0, this.frame1, 59, this.frame60);
    trace("[BSButtonHint_IconHolder] CTOR");
}
```

The constructor initializes the class instance, adding frame scripts to control the playback at certain frames and outputs a trace message indicating the creation of the object.

## Frame Scripts

### `frame1()`

This function is triggered when the playhead reaches frame 1 of the timeline.

```actionscript
function frame1():* {
    stop();
    trace("[BSButtonHint_IconHolder] Stop");
}
```

**Purpose:** It stops the timeline and traces a message indicating that playback has been stopped.

### `frame60()`

This function is executed when the playhead reaches frame 60.

```actionscript
function frame60():* {
    gotoAndPlay("Flashing");
    trace("[BSButtonHint_IconHolder] Flashing");
}
```

**Purpose:** It directs the timeline to play from a labeled frame "Flashing" and logs a message to indicate the icon should be flashing.

## Usage

Since this class is marked as UNUSED and is likely replaced by frame scripts, utilization in a project is not recommended without consulting the updated implementation.

---

**📝 Developer Note:**
- The class may still exist in the codebase but should not be used in favor of the new frame script implementation. It is essential to review the most recent version of the project to understand the current method for handling button hint icons.
