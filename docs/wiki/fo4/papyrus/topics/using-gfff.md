---
title: "Usage of Game.GetFormFromFile"
---

This document attempts to explain the appropriate usage of the `Game.GetFormFromFile()` function.

It has been suggested that variable fields have performance gains over properties.
Though the significance of these gains is not measured, and instead assumed.
This will require further research by using the Papyrus profiler and studying assembly code.

It has also been suggested that using `GetFormFromFile` to simply avoid filling properties in the Creation Kit is a bad practice.
The global papyrus function `GetFormFromFile()` is intended for inter-mod communication where optional soft dependencies can by configured.
Authors have been known to use `Game.GetFormFromFile()` to bypass the need to use properties to get game data.


#### History
Skyrim was the first game that introduced the new Papyrus scripting system.
Before that it was the OBScript scripting system which still lives on powering the condition system and developer console commands.
The old OBScript system relied on FormIDs to work with any data.
It is similar to working with the developer console command syntax in many ways.
The new Papyrus system relies on that information being stored in the data file through properties.

When Skyrim first released there were many discussions revolving around this.
These discussion occurred between skviper and the community on the public Bethsoft forums.
The user skviper was the Bethesda developer behind creating the new Papyrus scripting system, so we can take his word as an authority on the subject.
Early on, there was a community effort to stop using FormIDs to work with scripted data.

All those discussions are long gone now that the old bethsoft forums have been shut down for many years.
Perhaps they have been archived somewhere waiting to be found one day.
For now, the gist of it is that using `Game.GetFormFromFile()` for anything other than an optional dependency is an abuse of the function and should be avoided.


#### Opinion
This leads us to a topic of debate.
Many scripters find opening the Creation Kit and filling their properties with game data to be a burdensome extra step.
When many scripters learn about `Game.GetFormFromFile()` they may naturally begin using this function to fill variables instead of properties.
This is usually to avoid the extra step of using the Creation Kit user interface.

Although using `Game.GetFormFromFile()` is far more convenient than filling properties in the conventional way, it is important not to use it inappropriately.
Using this function to avoid filling properties is bad practice, but perhaps a lesser sin in the bigger picture and under the right conditions.


#### Recommendation
In general, it is recommended to just use properties.

If you use `Game.GetFormFromFile` specifically for things within your own mod, then it *might* be acceptable, at least not excessively.

It may also be acceptable to use `Game.GetFormFromFile` instead of properties in the development phase of a project.
This can greatly speed up development time when writing proof of concepts and prototypes as long as they are converted to properties before release.

There is at least one case of an F4SE Papyrus type that requires use of the `Game.GetFormFromFile` function.
Filling in a property with the Creation Kit is not possible for this F4SE type.


#### See Also
- <https://falloutck.uesp.net/wiki/GetFormFromFile_-_Game>
- <https://ck.uesp.net/wiki/GetFormFromFile_-_Game>
