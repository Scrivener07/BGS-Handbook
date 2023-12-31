---
title: "UI Menu Custom Popup"
---

A `MessageBoxPopup` is easy to create.
It would only need to be a new `MovieClip` with a background rectangle, a single `TextField`, and an OK button that can execute the same code you already do.
Finally you would create a script called `MessageBoxPopup.as` and attach it to your `MessageBoxPopup` (MovieClip) library object.

To show/hide the `MessageBoxPopup`, you might try this.
Code is shortened for brevity.
```as
// Create object in class constructor
var myPopup:MessageBoxPopup = new MessageBoxPopup();

// Call a function to set the textfield value on MessageBoxPopup.as
// You would have to define whatever is needed, but probably something like this.
myPopup.SetText("This is a MessageBoxPopup test parameter!");

// After you are certain the menu had an added-to-stage event you may safely call this members such as `stage`.
// You might also store the root MovieClip at index zero on your class like this to prevent excessive casting and cleaner code.
// Maybe even add a null check and some try/catch blocks.
var menuRoot:MovieClip = stage.getChildAt(0) as MovieClip;

// To show your popup, add it to the visual display root.
// The addChild function inserts your created MessageBoxPopup into the visual display root of the LevelUpMenuEx.
// I think added children are rendered top-most by default?
menuRoot.addChild(myPopup);

// To hide your popup, simply remove it from the visual display root.
// Be sure to setup a removed-from-stage event for your managing AS3 class that will clean up
// your popup clip from the root to prevent issues where your project leaves a mess behind itself.
menuRoot.removeChild(myPopup);
```

The events you will need.
```as
package
{
    import flash.display.MovieClip;
    import flash.events.Event;

    public class MyMovieClip extends MovieClip
    {

        public function MyMovieClip()
        {
            addEventListener(Event.ADDED_TO_STAGE, this.OnAddedToStage);
            addEventListener(Event.REMOVED_FROM_STAGE, this.OnRemovedFromStage);

            // This is what unregistration looks like.
            //removeEventListener(Event.ADDED_TO_STAGE, this.OnAddedToStage);
            //removeEventListener(Event.REMOVED_FROM_STAGE,this.OnRemovedFromStage);
        }

        private function OnAddedToStage(e:Event) : void
        {
            trace("MyMovieClip::OnAddedToStage:" + e.toString());
            // This MovieClip is now inserted into the visual tree hierarchy.
            // It is now safe to call dependent members.
        }

        private function OnRemovedFromStage(e:Event) : void
        {
            trace("MyMovieClip::OnRemovedFromStage:" + e.toString());
            // This MovieClip is now removed from the visual tree hierarchy.
        }

    }
}
```
