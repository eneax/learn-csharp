# Lists

While arrays have a fixed size, lists have a dynamic size.
We use a list when we don't know how many objects we are going to store in that list.


## Create a list

List is a generic type --> List<>

```
var numbers = new List<int>();
```

If you know the objects that will go inside a list

```
var numbers = new List<int>() { 1, 2, 3, 4 };
```


# Useful methods for the List class

* Add()             --> to add an object to a list
* AddRange()        --> to add a list of objects
* Remove()          --> remove an object from a list
* RemoveAt()        --> removes the object at a given index
* IndexOf()         --> return the index of a given object
* Contains()        --> tells if the list contains the object or not
* Count()           --> return the number of objects in the list