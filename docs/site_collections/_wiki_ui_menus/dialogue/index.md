---
title: "DialogueMenu"
categories: fo4 interface menus dialogue
---

The `DialogueMenu` class extends the `IMenu` class and is responsible for handling the dialogue menu within a game, consisting of four button hints for positive, negative, neutral, and question responses.

**Filename**: `DialogueMenu.as`


## Class Members

#### Public Members
- **FadeHolder_mc**: A `MovieClip` object that holds the animations related to the dialogue menu.
- **BGSCodeObj**: An `Object` used to interact with external code, likely to handle game-specific logic and UI feedback.

#### Private Members
- **Buttons**: A `Vector` containing `BSButtonHint` objects to represent the button hints on the dialogue menu.
- **ButtonAnimators**: A `Vector` containing `MovieClip` objects for animating the button hints' appearance.
- **ButtonData**: A `Vector` containing `BSButtonHintData` objects that store data related to the button hints.
- **PositiveBtnData, NegativeBtnData, NeutralBtnData, QuestionBtnData**: Individual `BSButtonHintData` objects for the four types of dialogue responses.
- **LastPressedButtonIndex**: A `uint` representing the index of the last pressed button.
- **_ButtonsShown**: A `Boolean` indicating whether the buttons are currently displayed.


### Constructor

```as3
public function DialogueMenu() {
    ...
}
```

Initializes button data, binds animations, and prepares the `FadeHolder_mc` for interaction.

### Public Functions
- `onSetSafeRect()`: Locks the menu to a safe area on the screen.
- `onCodeObjCreate()`: Registers objects with `BGSCodeObj` and initializes button hints.
- `SetButtonText(param1:uint, param2:String)`: Sets the text for a specific button.
- `ShowButtonHelp()`: Animates the appearance of button hints.
- `HideButtonHelp()`: Animates the disappearance of button hints.
- `EnableMenu()`: Shows the dialogue menu.
- `DisableMenu()`: Hides the dialogue menu.
- `ProcessUserEvent(param1:String, param2:Boolean)`: Processes user input and triggers the appropriate response.
- `PlaySpeechChallengeAnim()`: Begins an animation related to a speech challenge.
- `OnSpeechChallengeAnimComplete()`: Callback for when the speech challenge animation is complete.

### Private Functions
- `onPositivePress(), onNegativePress(), onNeutralPress(), onQuestionPress()`: Handlers for button press events.
- `onPositiveRelease(), onNegativeRelease(), onNeutralRelease(), onQuestionRelease()`: Handlers for button release events.
- `onButtonPress(param1:uint)`: Marks a button as pressed.
- `onButtonRelease(param1:uint)`: Marks a button as released and informs `BGSCodeObj`.

### Frame Scripts
- `frame1()`: Stops playback at frame 1.
- `frame5()`: Stops playback at frame 5.

## Usage Example
To use the `DialogueMenu`, an instance must be created and the necessary functions called in response to user input or game events.
Here is a stylized example of how it might be used, assuming the `DialogueMenu` class is integrated into an existing game engine or framework:

```as3
// Create an instance of the DialogueMenu
var dialogueMenu:DialogueMenu = new DialogueMenu();

// Show the menu
dialogueMenu.EnableMenu();

// Set button texts
dialogueMenu.SetButtonText(0, "Agree");
dialogueMenu.SetButtonText(1, "Disagree");
dialogueMenu.SetButtonText(2, "Ask");
dialogueMenu.SetButtonText(3, "Ignore");

// Show button help when needed
dialogueMenu.ShowButtonHelp();

// ... (during gameplay) ...

// Process user input
var userInput:String = "MultiActivateA"; // Example input
dialogueMenu.ProcessUserEvent(userInput, true);
```

## 📋 Table: Button Data Summary

| Index | Button Hint Data           | Description      |
|-------|----------------------------|------------------|
| 0     | `PositiveBtnData`          | Positive response|
| 1     | `NegativeBtnData`          | Negative response|
| 2     | `NeutralBtnData`           | Neutral response |
| 3     | `QuestionBtnData`          | Question/response|

**Note**: The `SetButtonText` method capitalizes the provided text before setting it on the button.
