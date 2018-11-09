# Methods

Methods (functions) have behavior (logic). 
They execute code and do things for us. 
That's where we implement our algorithms and write code.


## Signature of a Method

- Name (i.e. Move())
- Number an Type of parameters (i.e. int)

```
public class Point
{
    public void Move(int x, int y) { }
}
```


## Overloading Methods

Having a method with the same name and different signatures.

```
public class Point
{
    public void Move(int x, int y) { }

    public void(Point newMapLocation) { }

    public void(Point newMapLocation, int speed) { }
}
```


## The Params Modifier

```
public class Calculator
{
    public int Add(params int[] numbers) {}
}

var result = calculator.Add(new int[] {1, 2, 3, 4});

var result = calculator.Add(1, 2, 3, 4);
```