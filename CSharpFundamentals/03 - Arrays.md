# Arrays

An array is a data structure that we use to store a collection of 
variables of the same type. It is a non-primitive type in C#.

An array is a class with properties (Length) and methods (Clear(), Copy(), IndexOf(), Reverse(), Sort()).


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


## Single dimension arrays

```
var nums = new int[4];
var nums = new int[4] {1, 2, 3, 4};
```


## Multi dimension arrays
In C#, there are two types of multi dimension arrays

- Rectangular: each row has the same amount of columns

```
var matrix = new int[3, 5];
```

Or using object initialization syntax: 2D and 3D arrays:

```
var matrix = new int[3, 5]
{
    {1, 2, 3, 4, 5},
    {6, 7, 8, 9, 10},
    {11, 12, 13, 14, 15}
};

var element = matrix[0, 0]; --> 1
```

```
var color = new int[3, 5, 4];
```


- Jagged: it's like an array of arrays

```
var array = new int[3][];

array[0] = new int[4];
array[1] = new int[5];
array[2] = new int[3];

array[0][0] = 1;
```