# 8.0.2
* Add `StringEnumConverterWithFallback` class so that WebClient doesn't need to take dependency on `Albatross.Serialization.Json` package.
* `Albatross.Serialization.Json` package is meant to be used by services and utilities.  Proxies are being shared by multiple projects and should take as few dependencies as possible.
# 8.0.0
* A breaking change was introduced in 7.5.11 by mistake by replacing reference assembly `Albatross.Serialization` with `Albatross.Serialization.Json`.  Fixing by bumping the version to 8.0.0
* Took the opportunity to remove the `Albatross.Serialization.Json` and `Albatross.Dates` dependency.
# 7.5.11
* Replace `Albatross.Serialization` with `Albatross.Serialization.Json`
# 7.5.9
* Fix a string bug in [ClientBase](./ClientBase.cs) class where index out of bound exception would be thrown when the relative path is empty.