---
---
# WeakReference
The `WeakReference` class provides a mechanism to hold a reference to an object without preventing the object from being collected by the garbage collector.
This can be particularly useful when you want to keep a reference to an object without affecting its lifecycle.

**Filename**: `WeakReference.as`

## Class `WeakReference`

### Table of Contents

- [Properties](#properties)
- [Constructor](#constructor)
- [Methods](#methods)

### Properties

| Property | Type | Description |
|----------|------|-------------|
| `_dictionary` | `Dictionary` | The internal dictionary holding the weak reference to the object. |

### Constructor

#### `public function WeakReference(param1:Object)`

Constructs a `WeakReference` instance that holds a weak reference to the specified object.

##### Parameters

- `param1:Object` - The object to which this `WeakReference` instance will refer.

##### Code Example

```actionscript
public function WeakReference(param1:Object) {
    super();
    this._dictionary = new Dictionary(true);
    this._dictionary[param1] = 1;
}
```

### Methods

#### `public function get value() : Object`

Returns the object to which this weak reference refers, or `null` if the object has been garbage collected.

##### Returns

- `Object` - The referenced object or `null`.

##### Code Example

```actionscript
public function get value() : Object {
    var _loc1_:* = null;
    for(_loc1_ in this._dictionary) {
        return _loc1_;
    }
    return null;
}
```

## Usage Example

```actionscript
var myObject:Object = new Object();
var weakRef:WeakReference = new WeakReference(myObject);

var referencedObject:Object = weakRef.value;
if (referencedObject) {
    // Do something with the referenced object
} else {
    // The object has been garbage collected
}
```

The `WeakReference` class provides an easy way to keep a reference that does not interfere with garbage collection, which can be very useful in avoiding memory leaks in your applications, especially when dealing with listeners and callbacks.
