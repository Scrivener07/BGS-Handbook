---
---
# TextFieldEx
The `TextFieldEx` class provides an enhanced version of the `TextField` interactive object with additional functionalities for text fields within the Scaleform GFX framework.
It extends the `InteractiveObjectEx` class.

## Class Definition

```actionscript
package scaleform.gfx {
    import flash.display.BitmapData;
    import flash.text.TextField;

    public final class TextFieldEx extends InteractiveObjectEx {
        // ...
    }
}
```

## Constants

**Vertical Alignment Constants:**

| Constant | Value | Description |
|----------|-------|-------------|
| `VALIGN_NONE` | `"none"` | No vertical alignment. |
| `VALIGN_TOP` | `"top"` | Align text to the top of the text field. |
| `VALIGN_CENTER` | `"center"` | Center text vertically within the text field. |
| `VALIGN_BOTTOM` | `"bottom"` | Align text to the bottom of the text field. |

**Text Auto Size Constants:**

| Constant | Value | Description |
|----------|-------|-------------|
| `TEXTAUTOSZ_NONE` | `"none"` | No automatic text resizing. |
| `TEXTAUTOSZ_SHRINK` | `"shrink"` | Shrink text to fit the text field without wrapping. |
| `TEXTAUTOSZ_FIT` | `"fit"` | Scale text up or down to fill the width of the text field without wrapping. |

**Vertical Auto Size Constants:**

| Constant | Value | Description |
|----------|-------|-------------|
| `VAUTOSIZE_NONE` | `"none"` | No vertical auto-sizing. |
| `VAUTOSIZE_TOP` | `"top"` | Auto-size starting from top of the text field. |
| `VAUTOSIZE_CENTER` | `"center"` | Auto-size with center of the text field as the anchor point. |
| `VAUTOSIZE_BOTTOM` | `"bottom"` | Auto-size starting from bottom of the text field. |

## Class Methods

- **appendHtml**
  Appends HTML-formatted text to the existing text field content.
  ```actionscript
  public static function appendHtml(textField:TextField, newHtml:String) : void
  ```

- **setIMEEnabled**
  Enables or disables the Input Method Editor (IME) for the text field.
  ```actionscript
  public static function setIMEEnabled(textField:TextField, isEnabled:Boolean) : void
  ```

- **setVerticalAlign**
  Sets the vertical alignment of the text within the text field.
  ```actionscript
  public static function setVerticalAlign(textField:TextField, valign:String) : void
  ```

- **getVerticalAlign**
  Retrieves the current vertical alignment setting of the text field.
  ```actionscript
  public static function getVerticalAlign(textField:TextField) : String
  ```

- **setVerticalAutoSize**
  Sets the vertical auto-sizing behavior of the text field.
  ```actionscript
  public static function setVerticalAutoSize(textField:TextField, vautoSize:String) : void
  ```

- **getVerticalAutoSize**
  Retrieves the current vertical auto-size setting of the text field.
  ```actionscript
  public static function getVerticalAutoSize(textField:TextField) : String
  ```

- **setTextAutoSize**
  Sets the text auto-sizing behavior of the text field.
  ```actionscript
  public static function setTextAutoSize(textField:TextField, autoSz:String) : void
  ```

- **getTextAutoSize**
  Retrieves the current text auto-size setting of the text field.
  ```actionscript
  public static function getTextAutoSize(textField:TextField) : String
  ```

- **setImageSubstitutions**
  Defines image substitutions for text field placeholders.
  ```actionscript
  public static function setImageSubstitutions(textField:TextField, substInfo:Object) : void
  ```

- **updateImageSubstitution**
  Updates a specific image substitution in the text field.
  ```actionscript
  public static function updateImageSubstitution(textField:TextField, id:String, image:BitmapData) : void
  ```

- **setNoTranslate**
  Sets whether or not the text field should be translated.
  ```actionscript
  public static function setNoTranslate(textField:TextField, noTranslate:Boolean) : void
  ```

- **getNoTranslate**
  Retrieves the translate setting of the text field.
  ```actionscript
  public static function getNoTranslate(textField:TextField) : Boolean
  ```

- **setBidirectionalTextEnabled**
  Enables or disables bidirectional text in the text field.
  ```actionscript
  public static function setBidirectionalTextEnabled(textField:TextField, en:Boolean) : void
  ```

- **getBidirectionalTextEnabled**
  Retrieves the bidirectional text setting of the text field.
  ```actionscript
  public static function getBidirectionalTextEnabled(textField:TextField) : Boolean
  ```

- **setSelectionTextColor**
  Sets the color of the text selection.
  ```actionscript
  public static function setSelectionTextColor(textField:TextField, selColor:uint) : void
  ```

- **getSelectionTextColor**
  Retrieves the current color of the text selection.
  ```actionscript
  public static function getSelectionTextColor(textField:TextField) : uint
  ```

- **setSelectionBkgColor**
  Sets the background color of the text selection.
  ```actionscript
  public static function setSelectionBkgColor(textField:TextField, selColor:uint) : void
  ```

- **getSelectionBkgColor**
  Retrieves the current background color of the text selection.
  ```actionscript
  public static function getSelectionBkgColor(textField:TextField) : uint
  ```

- **setInactiveSelectionTextColor**
  Sets the text color of an inactive selection.
  ```actionscript
  public static function setInactiveSelectionTextColor(textField:TextField, selColor:uint) : void
  ```

- **getInactiveSelectionTextColor**
  Retrieves the text color of an inactive selection.
  ```actionscript
  public static function getInactiveSelectionTextColor(textField:TextField) : uint
  ```

- **setInactiveSelectionBkgColor**
  Sets the background color of an inactive text selection.
  ```actionscript
  public static function setInactiveSelectionBkgColor(textField:TextField, selColor:uint) : void
  ```

- **getInactiveSelectionBkgColor**
  Retrieves the background color of an inactive text selection.
  ```actionscript
  public static function getInactiveSelectionBkgColor(textField:TextField) : uint
  ```

## Usage Example

To set the vertical alignment of a `TextField` instance to the center, you can use the following code:

```actionscript
import scaleform.gfx.TextFieldEx;
import flash.text.TextField;

var myTextField:TextField = new TextField();
TextFieldEx.setVerticalAlign(myTextField, TextFieldEx.VALIGN_CENTER);
```

## Filename

`TextFieldEx.as`

## Remarks

This documentation is for the ActionScript `TextFieldEx` class which is part of the Scaleform GFX library.
It is used primarily within the context of video game UI development.
The class methods are mainly static, which means they are called on the class itself rather than on an instance of the class.
