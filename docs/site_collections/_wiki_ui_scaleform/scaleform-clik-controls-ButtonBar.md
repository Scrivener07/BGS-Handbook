---
---
# ButtonBar
The `ButtonBar` class is a component that creates a navigable bar of buttons, which is commonly used in user interfaces.
This class is part of the Scaleform CLIK (Common Lightweight Interface Kit) controls and extends the `UIComponent` class to provide additional functionality for button navigation and management.

## Class Details

- **Package**: `scaleform.clik.controls`
- **Filename**: `ButtonBar.as`

### Import Statements

The `ButtonBar` class imports several classes which are used within the code:

```as3
import flash.display.MovieClip;
import flash.events.Event;
import flash.system.ApplicationDomain;
import flash.text.TextFieldAutoSize;
import scaleform.clik.constants.InputValue;
import scaleform.clik.constants.InvalidationType;
import scaleform.clik.constants.NavigationCode;
import scaleform.clik.core.UIComponent;
import scaleform.clik.data.DataProvider;
import scaleform.clik.events.ButtonBarEvent;
import scaleform.clik.events.ButtonEvent;
import scaleform.clik.events.IndexEvent;
import scaleform.clik.events.InputEvent;
import scaleform.clik.interfaces.IDataProvider;
import scaleform.clik.ui.InputDetails;
```

### Properties

| Property               | Type             | Description                                                                |
|------------------------|------------------|----------------------------------------------------------------------------|
| `DIRECTION_HORIZONTAL` | `String`         | A constant for horizontal direction of the button bar.                     |
| `DIRECTION_VERTICAL`   | `String`         | A constant for vertical direction of the button bar.                       |
| `_autoSize`            | `String`         | Indicates how the button bar should auto-size.                             |
| `_buttonWidth`         | `Number`         | The width of each button in the bar.                                       |
| `_dataProvider`        | `IDataProvider`  | The data provider for the button bar.                                      |
| `_direction`           | `String`         | The direction in which the buttons are laid out.                           |
| `_group`               | `ButtonGroup`    | The group that the buttons belong to.                                      |
| `_itemRenderer`        | `String`         | The class name of the item renderer.                                       |
| `_itemRendererClass`   | `Class`          | The Class object of the item renderer.                                     |
| `_labelField`          | `String`         | The field of the data provider to use for button labels.                   |
| `_labelFunction`       | `Function`       | A function used to determine the label for each button.                    |
| `_renderers`           | `Array`          | An array of item renderer instances.                                       |
| `_spacing`             | `Number`         | The spacing between buttons in the bar.                                    |
| `_selectedIndex`       | `Number`         | The index of the currently selected button in the bar.                     |
| `container`            | `MovieClip`      | The MovieClip container that holds the buttons.                            |

### Methods

#### Constructor

```as3
public function ButtonBar()
```

- Initializes a new instance of the `ButtonBar` class.

#### Public Methods

- `function get dataProvider() : IDataProvider`
- `function set dataProvider(param1:IDataProvider) : void`
- `function set itemRendererName(param1:String) : void`
- `function get spacing() : Number`
- `function set spacing(param1:Number) : void`
- `function get direction() : String`
- `function set direction(param1:String) : void`
- `function get autoSize() : String`
- `function set autoSize(param1:String) : void`
- `function get buttonWidth() : Number`
- `function set buttonWidth(param1:Number) : void`
- `function get selectedIndex() : int`
- `function set selectedIndex(param1:int) : void`
- `function get selectedItem() : Object`
- `function get data() : Object`
- `function get labelField() : String`
- `function set labelField(param1:String) : void`
- `function get labelFunction() : Function`
- `function set labelFunction(param1:Function) : void`
- `function invalidateSettings() : void`
- `function itemToLabel(param1:Object) : String`
- `function getButtonAt(param1:int) : Button`

#### Protected Methods

- `function initialize() : void`
- `function handleInput(param1:InputEvent) : void`
- `function toString() : String`
- `function configUI() : void`
- `function draw() : void`
- `function refreshData() : void`
- `function updateRenderers() : void`
- `function populateData(param1:Array) : void`
- `function populateRendererData(param1:Button, param2:uint) : void`
- `function setupRenderer(param1:Button, param2:uint) : void`
- `function handleButtonGroupChange(param1:Event) : void`
- `function handleDataChange(param1:Event) : void`
- `function changeFocus() : void`

### Events

- `Event.CHANGE`: Dispatched when the data provider is changed.
- `IndexEvent.INDEX_CHANGE`: Dispatched when the selected index has changed.
- `ButtonEvent.CLICK`: Dispatched when a button within the group is clicked.
- `ButtonBarEvent.BUTTON_SELECT`: Dispatched when a button is selected.

## 📝 Remarks

- The class uses constants `DIRECTION_HORIZONTAL` and `DIRECTION_VERTICAL` to determine the layout of buttons within the bar.
- The `dataProvider` property is used to populate the buttons with data. Data can come from any class that implements the `IDataProvider` interface.
- It uses an item renderer class (default is `"Button"`) to create the individual buttons.
- The `ButtonBar` class supports auto-sizing, custom button widths, and manages button spacing.
- It also includes functionality for handling button selection and focus management.

---

**Example Usage**:

```as3
var buttonBar:ButtonBar = new ButtonBar();
buttonBar.dataProvider = new DataProvider([ { label: "Home" }, { label: "Settings" }, { label: "About" } ]);
buttonBar.itemRendererName = "MyCustomButton";
buttonBar.direction = ButtonBar.DIRECTION_HORIZONTAL;
buttonBar.spacing = 5;
buttonBar.autoSize = TextFieldAutoSize.LEFT;
buttonBar.buttonWidth = 100;
addChild(buttonBar);
```

This will create a button bar with three buttons labeled "Home", "Settings", and "About", using a custom button renderer class, laid out horizontally with 5 pixels spacing between each button, left auto-sizing, and a button width of 100 pixels.
