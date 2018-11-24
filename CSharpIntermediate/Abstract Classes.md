# Abstract Classes and Members

Abstract modifier states that a class or a member misses implementation. 
We use abstract members when it doesn’t make sense to implement them in a base class. 
For example, the concept of drawing a shape is too abstract. 
We don’t know how to draw a shape and this needs to be implemented in the derived classes.

- When a class member is declared as abstract, that class needs to be declared as abstract as well. 
  That means that class is not complete.
- In derived classes, we need to override the abstract members in the base class.


```
public abstract class Shape
{
    // This method doesn’t have a body
    public abstract void Draw();
}


public class Circle : Shape
{
    public override void Draw()
    {
        // Implementation for Circle
    }
}
```


## Rules

- Abstract Members do not include implementation
```
public abstract void Draw();
```

- If a member is declared as abstract, the containing class needs to be declared as abstract too.
```
public abstract class Shape
{
    public abstract void Draw();
}
```

- In a derived class, we need to override all abstract members of the base class, 
  otherwise that derived class is going to be abstract too.

- Abstract classes cannot be instantiated.