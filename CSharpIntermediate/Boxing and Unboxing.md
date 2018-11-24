# Boxing and Unboxing

- C# types are divided into two categories: value types and reference types.

- Value types (i.e. int, char, bool, all primitive types and struct) are stored in the stack. 
  They have a short life time and as soon as they go out of scope are removed from memory.

- Reference types (i.e. all classes) are stored in the heap.

- Both boxing and unboxing have to deal with a performance penalty. 
  This is not noticeable when dealing with small number of objects. 
  But if you’re dealing with several thousands or tens of thousands of objects, it’s better to avoid it. 



## Boxing

The process of converting a value type instance to an object reference.
```
int number = 10;
object obj = number;
```

or

```
object obj = 10;
```


## Unboxing

Unboxing is the opposite of boxing --> an object reference is converted to a value type.

```
object onj = 10;
int number = (int)obj;
```