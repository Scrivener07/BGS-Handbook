---
---
# PlatformRequestEvent
The `PlatformRequestEvent` class is part of the `Shared` package and is responsible for handling platform request events within a Flash application.
Below is the detailed documentation for the `PlatformRequestEvent.as` file.

## Table of Contents

- [Class Overview](#class-overview)
- [Constructor](#constructor)
- [Methods](#methods)
- [Event Type Constant](#event-type-constant)
- [Usage](#usage)
- [Example](#example)

## Class Overview

`PlatformRequestEvent` extends the functionality of the `flash.events.Event` class to provide a custom event for requesting platform-specific actions.

**Class Signature:**

```as3
package Shared {
    import flash.display.MovieClip;
    import flash.events.Event;

    public class PlatformRequestEvent extends Event {
        ...
    }
}
```

## Constructor

The constructor initializes a new instance of the `PlatformRequestEvent` class with a target movie clip.

**Constructor Signature:**

```as3
public function PlatformRequestEvent(aTarget:MovieClip)
```

### Parameters

- `aTarget:MovieClip` - The movie clip that is the target for the platform request.

## Methods

The `PlatformRequestEvent` class defines the following method to respond to the platform request:

### RespondToRequest

The `RespondToRequest` method is called to respond to the platform request and perform specific actions based on the platform.

**Method Signature:**

```as3
public function RespondToRequest(auiPlatform:uint, abPS3Switch:Boolean) : *
```

### Parameters

- `auiPlatform:uint` - An unsigned integer representing the platform.
- `abPS3Switch:Boolean` - A boolean indicating the PS3 switch state.

## Event Type Constant

The `PlatformRequestEvent` class defines the following constant for the event type:

**Constant:**

```as3
public static const PLATFORM_REQUEST:String = "GetPlatform";
```

## Usage

To use the `PlatformRequestEvent`, you need to create an instance of the event and dispatch it using the event dispatching system of the Flash Player.

```as3
var requestEvent:PlatformRequestEvent = new PlatformRequestEvent(someMovieClip);
dispatchEvent(requestEvent);
```

**Handling the Event:**

```as3
someMovieClip.addEventListener(PlatformRequestEvent.PLATFORM_REQUEST, handlePlatformRequest);

function handlePlatformRequest(event:PlatformRequestEvent):void {
    // Handle the platform request
}
```

## Example

Below is an example of how `PlatformRequestEvent` might be used in a Flash application:

**Creating and Dispatching the Event:**

```as3
var targetClip:MovieClip = new MovieClip();
var requestEvent:PlatformRequestEvent = new PlatformRequestEvent(targetClip);
dispatchEvent(requestEvent);
```

**Handling the Event:**

```as3
targetClip.addEventListener(PlatformRequestEvent.PLATFORM_REQUEST, onPlatformRequest);

function onPlatformRequest(event:PlatformRequestEvent):void {
    // Respond to the request
    event.RespondToRequest(1, true);
}
```

**Note:** Make sure to replace `1` and `true` in the `onPlatformRequest` function with actual platform-specific values suitable for your application.
