---
---
# QuantityMenuNEW
The `QuantityMenuNEW` class is a user interface component that allows users to select a quantity value through both a slider and text input.

It extends the `BSUIComponent` from the Shared package, which suggests a foundation for UI components in a larger system, possibly a game.

### Features

- A **header** with auto-sized text displaying the title.
- A **slider** to adjust the quantity value.
- A **count** displayed as text that reflects the current value.
- The ability to handle and dispatch a **quantity changed event**.
- Custom bracket graphics to visually enhance the header.

### Constants

| Name               | Value             |
|--------------------|-------------------|
| `QUANTITY_CHANGED` | "QuantityChanged" |

### Public Properties

- `Header_tf` (TextField): The text field for the header.
- `TopBracketHolder_mc` (MovieClip): MovieClip holder for top bracket graphics.
- `Count_tf` (TextField): The text field showing the current count.
- `Slider_mc` (BSSlider): The slider component for adjusting quantity.
- `Background_mc` (MovieClip): The background movie clip.

### Private Properties

- `_CurrCount` (uint): The current selected count.
- `_MaxCount` (uint): The maximum value that the count can reach.

### Constructor

The constructor takes a single parameter `param1` which sets the maximum count:

```actionscript
public function QuantityMenuNEW(param1:uint)
```

### Public Methods

- `get count()`: Returns the current count as a `uint`.
- `set count(param1:uint)`: Sets the current count to the provided `uint` value.
- `redrawUIComponent()`: Redraws the UI components based on their properties.
- `onSliderValueChanged(param1:CustomEvent)`: Event handler for when the slider value changes.
- `ProcessUserEvent(param1:String, param2:Boolean)`: Processes a user event.

## Usage Example

```actionscript
var quantityMenu:QuantityMenuNEW = new QuantityMenuNEW(100);
addChild(quantityMenu);
```

## UI Component Lifecycle

1. **Initialization**: The constructor initializes the component and sets up the slider with the maximum value and step sizes.
2. **UI Redraw**: The `redrawUIComponent` method is responsible for updating the UI graphics and positioning.
3. **Event Handling**: The `onSliderValueChanged` method listens for changes in the slider and updates the count accordingly.
4. **User Interaction**: The `ProcessUserEvent` method allows the component to handle user input events.

### Event Listeners

The `QuantityMenuNEW` class listens for the `BSSlider.VALUE_CHANGED` event to handle changes in the slider value.

## 🚀 Sample Event Dispatch

When the count is changed, an event with `QUANTITY_CHANGED` is dispatched:

```actionscript
dispatchEvent(new CustomEvent(QUANTITY_CHANGED, _loc2_, true));
```

### Graphics Creation

The class creates custom bracket graphics around the header to visually indicate the boundaries of the header text.

## Developer Notes 📝

- The `TextFieldEx.setTextAutoSize` is used to enable text auto-sizing for the header and count text fields.
- `GlobalFunc.SetText` function is called to update the count text field's value.
- Extensions and other custom functionalities not native to ActionScript are used, implying this code is part of a larger framework or system with extended capabilities.

**Important**: The code provided is part of a larger system and may depend on external functions and libraries such as `GlobalFunc`, `CustomEvent`, and `Extensions`. Ensure all dependencies are included when using this class.
