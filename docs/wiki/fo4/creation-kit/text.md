---
title: "Text"
---


### Creation Kit
- <https://falloutck.uesp.net/wiki/Message>
- <https://falloutck.uesp.net/wiki/Message_Script>
- <https://falloutck.uesp.net/wiki/MessageBox_-_Debug>
- <https://falloutck.uesp.net/wiki/Text_Replacement>
- <https://falloutck.uesp.net/wiki/Button_Tag_Replacement>


## Papyrus Strings
In practice, Papyrus strings are *case-insensitive* due to the way the game engine's string pool operates for efficiency reasons.
Most strings in the engine come from this same *case-insensitive* string pool, with a few exceptions.
The pool works by caching a unique occurrence of a string whenever one is encountered by the game engine for the first time.
The pool will reuse the cached version of a string for any following occurrences.
This means the distinction between uppercase and lowercase may not exist.

For example, the strings "MyString" and "mYsTrInG" are technically equivalent.
Which string is used depends on which version of the string is encountered by the game engine first.
The game's load order has an influence on this, among other things.
Following the example, if "mYsTrInG" is cached first then any following occurrence of "mystring" will always be "mYsTrInG".

This is potentially a problem for some game systems which require a **case-sensitive** string.

##### **Workarounds**
In general the workaround to creating a string with any preferred casing would be to use a pseudo uniqueness.
For example the string "raider" is cached but you want "Raider".
You can use a pseudo uniqueness by prefixing or suffixing the string with a space character (" ").

Sticking with the example, the user would be none the wiser if you used "Raider " for UI purposes.
This is not a suitable workaround for all cases.
For other cases you should make your strings more unique if possible.

##### **Notes**
- The game engine internally uses a data structure called `BSFixedString` for handling string data.
- Localized strings, internally `BGSLocalizedString`, are also vulnerable to string pool limitations.
- [UI Script](https://falloutck.uesp.net/wiki/UI_Script) function calls to Scaleform are affected by this string casing limitation.
- [Initialization File](https://falloutck.uesp.net/wiki/Initialization_File) related function calls are affected by this string casing limitation.
