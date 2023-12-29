# LayoutData
The `LayoutData` class is part of the `scaleform.clik.layout` package and is utilized for defining the layout properties related to the Scaleform CLIK (Common Lightweight Interface Kit) framework.

## Contents
- [Constants](#constants)
- [Properties](#properties)
- [Constructor](#constructor)
- [Methods](#methods)

## Constants

The `LayoutData` class provides constants to define common aspect ratios:

| Constant | Value |
|----------|-------|
| **ASPECT_RATIO_4_3** | `"4:3"` |
| **ASPECT_RATIO_16_9** | `"16:9"` |
| **ASPECT_RATIO_16_10** | `"16:10"` |

## Properties

The following table describes the properties of the `LayoutData` class:

| Property | Type | Description |
|----------|------|-------------|
| `alignH` | `String` | Horizontal alignment of the element. |
| `alignV` | `String` | Vertical alignment of the element. |
| `offsetH` | `int` | Horizontal offset of the element. |
| `offsetV` | `int` | Vertical offset of the element. |
| `offsetHashH` | `Dictionary` | Dictionary to store horizontal offset hashes. |
| `offsetHashV` | `Dictionary` | Dictionary to store vertical offset hashes. |
| `relativeToH` | `String` | The horizontal relative point for alignment. |
| `relativeToV` | `String` | The vertical relative point for alignment. |
| `layoutIndex` | `int` | Index used to determine the order of layout. |
| `layoutIdentifier` | `String` | Identifier for the layout data. |

## Constructor

The `LayoutData` class constructor initializes the layout properties with optional parameters:

```actionscript
public function LayoutData(param1:String = "none", param2:String = "none", param3:int = -1, param4:int = -1, param5:String = null, param6:String = null, param7:int = -1, param8:String = null) {
    super();
    this.alignH = param1;
    this.alignV = param2;
    this.offsetH = param3;
    this.offsetV = param4;
    this.relativeToH = param5;
    this.relativeToV = param6;
    this.layoutIndex = param7;
    this.layoutIdentifier = param8;
    this.offsetHashH = new Dictionary();
    this.offsetHashV = new Dictionary();
}
```

### Parameters

| Parameter | Default Value | Description |
|-----------|---------------|-------------|
| `param1` | `"none"` | Initial value for horizontal alignment. |
| `param2` | `"none"` | Initial value for vertical alignment. |
| `param3` | `-1` | Initial horizontal offset. |
| `param4` | `-1` | Initial vertical offset. |
| `param5` | `null` | Initial relative horizontal point. |
| `param6` | `null` | Initial relative vertical point. |
| `param7` | `-1` | Initial layout index. |
| `param8` | `null` | Initial layout identifier. |

## Methods

### `toString()` Method

The `toString` method provides a string representation of the `LayoutData` object for debugging purposes.

```actionscript
public function toString() : String {
    return "[LayoutData, h: " + this.alignH + ", v: " + this.alignV + ", oh: " + this.offsetH + ", ov: " + this.offsetV + ", relh: " + this.relativeToH + ", relv: " + this.relativeToV + ", idx: " + this.layoutIndex + "]";
}
```

## Full Code

The entire `LayoutData` ActionScript class is provided below for reference:

```actionscript
package scaleform.clik.layout {
    import flash.utils.Dictionary;

    public class LayoutData {
        public static const ASPECT_RATIO_4_3:String = "4:3";
        public static const ASPECT_RATIO_16_9:String = "16:9";
        public static const ASPECT_RATIO_16_10:String = "16:10";

        public var alignH:String = null;
        public var alignV:String = null;
        public var offsetH:int = -1;
        public var offsetV:int = -1;
        public var offsetHashH:Dictionary = null;
        public var offsetHashV:Dictionary = null;
        public var relativeToH:String = null;
        public var relativeToV:String = null;
        public var layoutIndex:int = -1;
        public var layoutIdentifier:String = null;

        public function LayoutData(param1:String = "none", param2:String = "none", param3:int = -1, param4:int = -1, param5:String = null, param6:String = null, param7:int = -1, param8:String = null) {
            super();
            this.alignH = param1;
            this.alignV = param2;
            this.offsetH = param3;
            this.offsetV = param4;
            this.relativeToH = param5;
            this.relativeToV = param6;
            this.layoutIndex = param7;
            this.layoutIdentifier = param8;
            this.offsetHashH = new Dictionary();
            this.offsetHashV = new Dictionary();
        }

        public function toString() : String {
            return "[LayoutData, h: " + this.alignH + ", v: " + this.alignV + ", oh: " + this.offsetH + ", ov: " + this.offsetV + ", relh: " + this.relativeToH + ", relv: " + this.relativeToV + ", idx: " + this.layoutIndex + "]";
        }
    }
}
```

📄 **Filename**: `LayoutData.as`
