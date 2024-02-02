---
---
# CLIK
Filename: `CLIK.as`

The `CLIK` class is part of the `scaleform.clik.core` package and is responsible for integrating Scaleform CLIK (Common Lightweight Interface Kit) components into a Flash environment.
It provides static methods to initialize components, manage focus, pop-ups, and also allows for callback queuing to ensure components are initialized at the appropriate time.

## Class Details
This dynamic class contains static members and functions to handle the initialization and management of UI components within the Scaleform framework.

#### Properties

| **Property**                               | **Type**    | **Description**                                                                                      |
| ------------------------------------------ | ----------- | ---------------------------------------------------------------------------------------------------- |
| **stage**                                  | `Stage`     | A reference to the Stage object.                                                                    |
| **initialized**                            | `Boolean`   | Indicates whether the CLIK system has been initialized.                                              |
| **disableNullFocusMoves**                  | `Boolean`   | If true, disallows focus moves to null.                                                              |
| **disableDynamicTextFieldFocus**           | `Boolean`   | If true, disables focus on dynamic text fields.                                                      |
| **disableTextFieldToNullFocusMoves**       | `Boolean`   | If true, disallows focus moves from text fields to null.                                             |
| **useImmediateCallbacks**                  | `Boolean`   | If true, callbacks are fired immediately rather than queued.                                         |
| **isInitListenerActive** (protected)       | `Boolean`   | Indicates if the initialization listener is active.                                                  |
| **firingInitCallbacks** (protected)        | `Boolean`   | A flag to determine if initialization callbacks are currently being fired.                           |
| **initQueue** (protected)                  | `Dictionary`| A Dictionary queue holding initialization callbacks, indexed by depth in the display list hierarchy. |
| **validDictIndices** (protected)           | `Vector.<uint>` | A Vector of indices that are used to keep track of valid Dictionary entries in the queue.      |

#### Methods

| **Method**                                    | **Return Type** | **Description**                                                                                                                    |
| --------------------------------------------- | --------------- | ---------------------------------------------------------------------------------------------------------------------------------- |
| **initialize(param1:Stage, param2:UIComponent)** | `void`          | Initializes the CLIK system with a reference to the Stage and a UIComponent as a root for focus management.                        |
| **getTargetPathFor(param1:DisplayObjectContainer)** | `String`        | Returns a string representation of the target path for the given DisplayObjectContainer.                                           |
| **queueInitCallback(param1:UIComponent)**           | `void`          | Queues a UIComponent for initialization callback.                                                                                  |
| **fireInitCallback(param1:Event)** (protected)       | `void`          | Fires initialization callbacks for all queued UIComponents. Fires when a frame exits if `useImmediateCallbacks` is `false`.        |
| **clearQueue()** (protected)                         | `void`          | Clears the initialization queue.                                                                                                   |
| **sortFunc(param1:uint, param2:uint)** (protected)   | `Number`        | A sort function used internally to sort valid dictionary indices.                                                                  |
| **getTargetPathImpl(param1:DisplayObjectContainer, param2:String)** (protected) | `String` | A helper function that constructs the target path by recursively traversing up the display list starting from the specified container. |

## Example Usage

To initialize the CLIK system, you would call the `initialize` method typically at the start of your application:

```actionscript
import scaleform.clik.core.CLIK;
import flash.display.Stage;

var myStage:Stage = /* your stage reference */;
CLIK.initialize(myStage, /* your root UIComponent */);
```

If you're working with UI components that need to perform actions once they've been added to the stage, you might queue an initialization callback:

```actionscript
import scaleform.clik.core.UIComponent;

var myUIComponent:UIComponent = /* your UIComponent instance */;
CLIK.queueInitCallback(myUIComponent);
```

## Notes

- The CLIK class is dynamic, which allows additional properties to be added to it at runtime.
- It is important to ensure that the system is only initialized once, which is why there is a check for the `initialized` property at the beginning of the `initialize` function.
- Callbacks can be fired immediately or queued based on the `useImmediateCallbacks` property.

📝 **Please note** that this documentation is based on the provided code snippet and assumes familiarity with the Scaleform CLIK framework and ActionScript 3.0.
