# Upcasting and Downcasting
All objects can be implicitly converted to a base class reference.

## Upcasting
It's the conversion from a derived class to a base class

```
public class Shape
{
}

public class Circle : Shape
{
}
```

Convert the Circle into Shape, without casting.
```
Circle circle = new Circle();
Shape shape = circle;
```


## Downcasting
- It's the conversion from a base class to a derived class
- It requires a cast

```
Circle circle = new Circle();
Shape shape = circle

Circle anotherCircle = (Circle)shape;   --> valid
Car car = (Car)shape;                   --> throws InvalidCastException
```


## The 'as' keyword
Casting throws an exception if the conversion is not successful. 
We can use the 'as' keyword to prevent this. 
However, if conversion is not successful, null is returned.

```
Car car = (Car) obj;

Car car = obj as Car;
if(car != null)
{
    // some code
}
```


## The 'is' keyword

```
if(obj is Car)
{
    Car car = (Car) obj;
    ...
}
```