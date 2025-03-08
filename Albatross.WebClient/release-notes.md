# 8.0.0
* A breaking change was introduced in 7.5.11 by mistake by replacing reference assembly `Albatross.Serialization` with `Albatross.Serialization.Json`.  Fixing by bumping the version to 8
* Took the opportunity to remove the `Albatross.Serialization.Json` dependency all together.
# 7.5.11
* Replace `Albatross.Serialization` with `Albatross.Serialization.Json`
# 7.5.9
* Fix a string bug in [ClientBase](./ClientBase.cs) class where index out of bound exception would be thrown when the relative path is empty.
