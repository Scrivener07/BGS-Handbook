---
title: "CreditsMenu"
categories: fo4 interface menus credits
---

The **Credits Menu** is a scrolling list of names which recognize the Bethesda Studios team behind Fallout 4 and the Creation Kit.

This menu loads the credits text from the `Data\Interface\Credits.txt` file.

## AS3
- `var BGSCodeObj:Object`
- `var CreditsStrings:Array`
- `var CreditsLines:Array`
- `var CreditsContainer:MovieClip`
- `var CreditsFonts:Array`
- `var Background_mc:MovieClip`
- `var ButtonHintBar_mc:BSButtonHintBar`
- `function onCodeObjDestruction():*`
- `function onCodeObjCreate():void`
- `function ProcessUserEvent(param1:String, param2:Boolean):Boolean`
- `function onEnterFrame(param1:Event):void`
- `function formatLine(param1:TextField, param2:int):void`
- `function appendCredits(param1:String):void`
- `function onMouseWheel(param1:MouseEvent):void`
- `function onQuitPress():Boolean`

#### BGSCodeObj
- `function closeMenu():void`
- `function getScrollSpeed():Number`
- `function requestCredits():void`




# CreditsMenu.as Documentation
This documentation provides information about the `CreditsMenu` class located in the `CreditsMenu.as` file.

## Overview
The `CreditsMenu` class extends `IMenu` and is responsible for creating and managing the behavior of a credits screen within a game, specifically designed for the Adobe ActionScript 3 environment.

## Properties
Here is a list of properties with their descriptions:

| Property Name      | Type              | Description                                                                  |
|--------------------|-------------------|------------------------------------------------------------------------------|
| `StartY`           | `Number`          | The starting Y position for the credits.                                     |
| `FadeStart`        | `Number`          | The Y position where the fading of text starts.                              |
| `FadeEnd`          | `Number`          | The Y position where the fading of text ends.                                |
| `EndY`             | `Number`          | The ending Y position for the credits.                                       |
| `TextYRate`        | `Number`          | The rate at which the credits scroll.                                        |
| `MinHeight`        | `Number`          | The minimum height for text fields.                                          |
| `FontSize`         | `int`             | The font size for the credits text.                                          |
| `TextColor`        | `int`             | The color of the credits text.                                               |
| `BGSCodeObj`       | `Object`          | An object for interacting with game-specific code.                           |
| `CreditsStrings`   | `Array`           | Array containing strings that represent individual credits.                  |
| `CreditsLines`     | `Array`           | Array containing display objects for each line of credits.                   |
| `CreditsContainer` | `MovieClip`       | The MovieClip container that holds the credits display objects.              |
| `CreditsFonts`     | `Array`           | An array of font information used to format the credits text.                |
| `Background_mc`    | `MovieClip`       | The background movie clip for the credits screen.                            |
| `startIndex`       | `int`             | The starting index of the currently displayed credits.                       |
| `endIndex`         | `int`             | The ending index of the currently displayed credits.                         |
| `maxEndIndex`      | `int`             | The maximum index of credits that have been displayed.                       |
| `ButtonHintBar_mc` | `BSButtonHintBar` | The bar containing button hints.                                             |
| `BackButton`       | `BSButtonHintData`| The data for the back button hint.                                           |


## Methods
Here is a list of methods with their descriptions:

| Method Name            | Return Type | Description                                                                                                                   |
|------------------------|-------------|-------------------------------------------------------------------------------------------------------------------------------|
| `CreditsMenu()`        | `void`      | Constructor for the `CreditsMenu` class. Initializes properties and listeners.                                                |
| `onSetSafeRect()`      | `void`      | Protected method called to set the safe rectangle.                                                                            |
| `onCodeObjDestruction()`| `*`        | Cleans up listeners and references when the code object is destroyed.                                                         |
| `onCodeObjCreate()`    | `void`      | Called when the code object is created, initializes the credits.                                                              |
| `PopulateButtonBar()`  | `void`      | Populates the button bar with hint data.                                                                                      |
| `ProcessUserEvent()`   | `Boolean`   | Processes user events such as "Cancel" or "Start", and determines if the quit press action should be executed.                |
| `onEnterFrame()`       | `void`      | Called on each frame to animate the credits.                                                                                  |
| `formatLine()`         | `void`      | Applies formatting to a given text field based on font and index.                                                             |
| `appendCredits()`      | `void`      | Appends a new credits string to the credits display, with optional font tags for styling.                                     |
| `onMouseWheel()`       | `void`      | Handles the mouse wheel event to scroll the credits.                                                                          |
| `onQuitPress()`        | `Boolean`   | Handles the quit button press event and closes the menu.                                                                      |
| `moveCredits()`        | `void`      | Moves the credit lines according to a given Y offset, managing which lines are displayed and the fade effect.                 |

## Example Usage

```as
// Create a new instance of CreditsMenu
var creditsMenu:CreditsMenu = new CreditsMenu();

// Add credit lines with appendCredits method
creditsMenu.appendCredits("Director: John Doe");
creditsMenu.appendCredits("Producer: Jane Smith");

// Start the credits animation
creditsMenu.onCodeObjCreate();

// Handle the back button press
creditsMenu.onQuitPress();
```

## Additional Notes
- The `CreditsMenu` class utilizes `TextField` objects to display text, formatted by `TextFormat`.
- The `BSButtonHintBar` and `BSButtonHintData` classes are used to add interactive elements such as a back button to the credits screen.
- For proper functionality, the game-specific code object (`BGSCodeObj`) must be set up to handle requests for credits and control the menu closure.
- The `pop` and `append` patterns are used to manipulate the credits lines and fonts arrays which form the dynamic behavior of the scrolling credits.
