# Arrays

An array is a data structure that we use to store a collection of 
variables of the same type. It is a non-primitive type in C#.


## Declare an array

```
int[] numbers = new int[3];
```

The first pair of square brackets is used to tell the compiler that we want to declare an array,
while the second one is used to set the size of that array.

In C#, arrays have a fixed size and must be specified during declaration. Cannot be changed at a later time.

An array is an object behind the scenes, that's why we need to allocate memory for it,
using the 'new' keyword.


## Declare and initialize an array

```
int[] numbers = new numbers[3] { 1, 2, 3 };
```


## Access an array

```
numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;
```
