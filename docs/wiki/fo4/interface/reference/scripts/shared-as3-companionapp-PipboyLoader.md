# PipboyLoader
The `PipboyLoader` class extends the functionality of the Flash `Loader` class, enabling conditional asset loading depending on whether the Companion App Mode is active or not.
When active, it uses an external interface to retrieve asset paths before performing the load operation.

## Table of Contents
- [Class Definition](#class-definition)
- [Methods](#methods)
  - [Constructor](#constructor)
  - [load](#load-method)
  - [OnGetAssetPathResult](#ongetassetpathresult-method)
- [Usage](#usage)

## Class Definition

```as3
package Shared.AS3.COMPANIONAPP {
    import flash.display.Loader;
    import flash.external.ExternalInterface;
    import flash.net.URLRequest;
    import flash.system.LoaderContext;

    public class PipboyLoader extends Loader {
        private var _request:URLRequest;
        private var _context:LoaderContext;

        public function PipboyLoader() {
            super();
        }

        override public function load(param1:URLRequest, param2:LoaderContext = null) : void {
            if(CompanionAppMode.isOn) {
                if(ExternalInterface.available) {
                    this._request = param1;
                    this._context = param2;
                    ExternalInterface.call.apply(null,["GetAssetPath",param1.url,this]);
                } else {
                    trace("PipboyLoader::load -- ExternalInterface is not available!");
                }
            } else {
                super.load(param1,param2);
            }
        }

        public function OnGetAssetPathResult(param1:String) : void {
            this._request.url = param1;
            super.load(this._request,this._context);
            this._request = null;
            this._context = null;
        }
    }
}
```
**Filename:** `PipboyLoader.as`

## Methods

### Constructor
- **PipboyLoader()**
  - No parameters
  - Initializes the `Loader` superclass.

### Load Method
- **load(param1:URLRequest, param2:LoaderContext = null)**
  - Table of Parameters:

    | Parameter | Type             | Description                    |
    |-----------|------------------|--------------------------------|
    | param1    | URLRequest       | The URLRequest object.         |
    | param2    | LoaderContext    | The LoaderContext (optional).  |

  - This method overrides the Loader's `load` method, adding functionality to manage asset loading depending on the Companion App Mode.

### OnGetAssetPathResult Method
- **OnGetAssetPathResult(param1:String)**
  - Table of Parameters:

    | Parameter | Type   | Description                                    |
    |-----------|--------|------------------------------------------------|
    | param1    | String | String representing the path to the asset file.|

  - Called when the external interface provides the asset path, updating the request URL and invoking the superclass `load` method to load the asset.

## Usage

The `PipboyLoader` class is utilized to handle asset loading within a Flash application that has a companion app feature, enabling special loading behaviors when the companion app is active.

1. Create an instance of `PipboyLoader`.
2. Call the `load` method with appropriate parameters to initiate the asset loading process.
3. If the Companion App Mode is active and `ExternalInterface` is available, an external call is made to fetch the asset path.
4. Upon receiving the asset path via the `OnGetAssetPathResult` callback, the loader updates the URL and continues with the loading process.

**Note:** Error handling for `ExternalInterface` not being available is done through a `trace` statement. Consider enhancing this to a more robust error handling procedure in a production environment.

Remember that the `PipboyLoader` class is an ActionScript 3.0 (AS3) code and is meant for Flash-based projects, which as of the time of the knowledge cutoff for this document, may not be supported in modern web environments due to the deprecation of Flash Player.
