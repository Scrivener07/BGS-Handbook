---
---
# BSScrollingListInterface
The `BSScrollingListInterface` class is a part of the **Shared.AS3.COMPANIONAPP** package.

It provides constants for linkage IDs used by the scrolling list interface and a method to map these linkage IDs to their corresponding properties for the mobile scrolling list.


## Constants
The class defines several constants for linkage IDs. These are identifiers for list entries and their corresponding renderers within the mobile application.

| Constant | Linkage ID | Description |
| --- | --- | --- |
| `STATS_SPECIAL_ENTRY_LINKAGE_ID` | `"SPECIALListEntry"` | Linkage ID for the SPECIAL stats entry. |
| `STATS_PERKS_ENTRY_LINKAGE_ID` | `"PerksListEntry"` | Linkage ID for the Perks entry. |
| `INVENTORY_ENTRY_LINKAGE_ID` | `"InvListEntry"` | Linkage ID for the Inventory entry. |
| ... | ... | ... |
| `RADIO_ENTRY_LINKAGE_ID` | `"RadioListEntry"` | Linkage ID for the Radio entry. |
| `PIRBOY_MESSAGE_ENTRY_LINKAGE_ID` | `"MessageBoxButtonEntry"` | Linkage ID for Pipboy message entry. |

## Renderer Linkage IDs
The constants for renderer linkage IDs specify the renderer components associated with the list entries.

| Constant | Renderer Linkage ID | Description |
| --- | --- | --- |
| `STATS_SPECIAL_RENDERER_LINKAGE_ID` | `"SPECIALItemRendererMc"` | Renderer ID for SPECIAL stats. |
| `STATS_PERKS_RENDERER_LINKAGE_ID` | `"PerksItemRendererMc"` | Renderer ID for Perks. |
| ... | ... | ... |
| `RADIO_RENDERER_LINKAGE_ID` | `"RadioItemRendererMc"` | Renderer ID for Radio. |
| `PIRBOY_MESSAGE_RENDERER_LINKAGE_ID` | `"PipboyMessageItemRenderer"` | Renderer ID for Pipboy messages. |

## Method: GetMobileScrollListProperties
The static method `GetMobileScrollListProperties` provides a way to retrieve properties for mobile scrolling lists based on the provided class name (which should be one of the linkage IDs).

```as3
public static function GetMobileScrollListProperties(className:String) : MobileScrollListProperties {
    // Method implementation...
}
```

## MobileScrollListProperties
When calling `GetMobileScrollListProperties`, an instance of `MobileScrollListProperties` is returned with properties configured based on the linkage ID that was passed. These properties define how the mobile scrolling list for that specific item behaves.

### Sample Usage
```as3
var specialListProps:MobileScrollListProperties = BSScrollingListInterface.GetMobileScrollListProperties(BSScrollingListInterface.STATS_SPECIAL_ENTRY_LINKAGE_ID);
```

The returned `MobileScrollListProperties` would have properties set as per the SPECIAL stats entry configuration.

## Full Code Block

```as3
package Shared.AS3.COMPANIONAPP {
    import Mobile.ScrollList.MobileScrollList;

    public class BSScrollingListInterface {

        // Linkage ID Constants
        public static const STATS_SPECIAL_ENTRY_LINKAGE_ID:String = "SPECIALListEntry";
        public static const STATS_PERKS_ENTRY_LINKAGE_ID:String = "PerksListEntry";
        // ... (other constants)
        public static const PIPBOY_MESSAGE_ENTRY_LINKAGE_ID:String = "MessageBoxButtonEntry";

        // Renderer Linkage ID Constants
        public static const STATS_SPECIAL_RENDERER_LINKAGE_ID:String = "SPECIALItemRendererMc";
        public static const STATS_PERKS_RENDERER_LINKAGE_ID:String = "PerksItemRendererMc";
        // ... (other constants)
        public static const PIPBOY_MESSAGE_RENDERER_LINKAGE_ID:String = "PipboyMessageItemRenderer";

        // Constructor
        public function BSScrollingListInterface() {
            super();
        }

        // GetMobileScrollListProperties method
        public static function GetMobileScrollListProperties(className:String) : MobileScrollListProperties {
            var props:MobileScrollListProperties = new MobileScrollListProperties();
            // Switch statement for setting up properties...
            // ...
            return props;
        }
    }
}
```

This documentation provides an overview of the `BSScrollingListInterface` class with its constants and method for retrieving mobile scroll list properties. Additional details for each linkage ID and renderer linkage ID can be provided if necessary for further clarification.
