# CompanionAppMode.as Documentation

This document provides details about the `CompanionAppMode` class found in the `CompanionAppMode.as` file. This class is part of the `Shared.AS3.COMPANIONAPP` package.

## Overview

The `CompanionAppMode` class is a simple class that contains a static boolean variable indicating whether the companion app mode is active (`true`) or not (`false`). This class does not contain any methods other than a constructor.

## Class Definition

Below is the `CompanionAppMode` class definition:

```actionscript
package Shared.AS3.COMPANIONAPP {
    public class CompanionAppMode {
        public static var isOn:Boolean = false;

        public function CompanionAppMode() {
            super();
        }
    }
}
```

## Class Members

### Properties

| Property | Type    | Description                                  | Default Value |
|----------|---------|----------------------------------------------|---------------|
| `isOn`   | Boolean | Indicates if the companion app mode is active | `false`       |

### Constructor

The `CompanionAppMode` class has a constructor which invokes the constructor of the superclass.

```actionscript
public function CompanionAppMode() {
    super();
}
```

## Usage

The `isOn` property can be accessed statically to determine whether the companion app mode is currently enabled.

**Example:**

```actionscript
if (CompanionAppMode.isOn) {
    // Code to execute when companion app mode is active
} else {
    // Code to execute when companion app mode is not active
}
```

## 📝 Notes

- The class does not provide any methods to change the `isOn` property directly; it is expected to be managed externally.
- The class is specifically tailored for use within an ActionScript 3 project that interacts with a companion application.

**Bold Text**: Properties and methods of the class are highlighted in **bold** for quick identification.
