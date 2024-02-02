---
title: "BookMenu"
categories: fo4 interface menus book
---

The `BookMenu` class extends the `IMenu` class and is responsible for managing the book menu within the game, which includes pagination and button hints for navigation.

### Constants

| **Name**           | **Type** | **Description**                     |
|--------------------|----------|-------------------------------------|
| `PAGE_BREAK_TAG`   | `String` | Tag used to indicate a page break.  |
| `CACHED_PAGES`     | `Number` | Number of pages to cache.           |

### Properties

| **Name**                   | **Type**              | **Description**                           |
|----------------------------|-----------------------|-------------------------------------------|
| `ButtonHintBar_mc`         | `BSButtonHintBar`     | The movie clip for the button hint bar.   |
| `ReferenceTextInstance`    | `MovieClip`           | Reference to the text instance movie clip.|
| `PrevButton`               | `BSButtonHintData`    | Data for the previous page button.        |
| `TakeButton`               | `BSButtonHintData`    | Data for the take button.                 |
| `NextButton`               | `BSButtonHintData`    | Data for the next page button.            |
| `ExitButton`               | `BSButtonHintData`    | Data for the exit button.                 |
| `BGSCodeObj`               | `Object`              | Background code object.                   |
| `Language`                 | `String`              | Current language setting.                 |

### Methods

#### Constructor: `BookMenu()`
Initializes the book menu, sets up buttons, and prepares for pagination.

#### `set language(param1:String) : *`
Sets the language of the book menu.

#### `PopulateButtonBar() : void`
Populates the button hint bar with button data.

#### `onPrevButton() : void`
Handles the action when the previous page button is pressed.

#### `onTakeButton() : void`
Handles the action when the take button is pressed.

#### `onNextButton() : void`
Handles the action when the next page button is pressed.

#### `onBackButton() : void`
Handles the action when the back button is pressed.

#### `SetTextOffset(param1:Number, param2:Number) : *`
Sets the text offset.

#### `SetBookText(param1:String, param2:Boolean) : void`
Sets the text of the book and determines if it's a note.

#### `CreateDisplayPage(param1:Number) : *`
Creates a displayable page from the book text.

#### `SetButtonVisibility(param1:int, param2:int, param3:int) : void`
Sets the visibility of the navigation buttons.

#### `CalculatePagination() : void`
Calculates pagination based on the text content.

#### `SetLeftPageNumber(param1:Number) : void`
Sets the left page number for navigation.

#### `ShowPageAtOffset(param1:Number) : void`
Shows the book page at a specific offset.

#### `PrepForClose() : *`
Prepares the book menu for closing.

#### `TurnPage(param1:Number) : Boolean`
Turns the page in the book menu.

#### `UpdatePages() : *`
Updates the pages in the book menu.

#### `__setProp_ButtonHintBar_mc_Scene1_ButtonHintBar_mc_0() : *`
Sets the properties of the button hint bar component.

### Usage Example

```as3
var bookMenu:BookMenu = new BookMenu();
bookMenu.setBookText("This is a sample text for the book.", false);
bookMenu.SetButtonVisibility(1, 0, 1);
```

**Note:**
The actual implementation of the methods and triggering the events would depend on the additional game code and how it interfaces with this class.

### Icons and Emojis
- 📖 Represents the BookMenu or anything related to the textual content.
- ⬅️ Represents the action to go to the previous page.
- ➡️ Represents the action to go to the next page.
- 🗑️ Represents the action to take or remove the book.
- 🚪 Represents the action to exit the book menu.

### Important Notes
- The code handles different language settings and changes the font accordingly.
- Error handling is done with try-catch blocks and the errors are traced for debugging.
- Some methods like `SetTextOffset` and `CreateDisplayPage` have additional logic for handling notes versus regular book text.

**Legend**:
The documentation utilizes bold text for **class names**, **method names**, and other **relevant information**.
Tables are used to organize **properties** and **methods** for clarity.
