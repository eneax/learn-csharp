# Method Overriding

Method overriding means changing the implementation of an inherited method.
If a declare a method as virtual in the base class, we can override it in a derived class.

```
public class Shape
{
    public virtual void Draw()
    {
        // Default implementation for all derived classes
    }
}


public class Circle : Shape
{
    public override void Draw()
    {
        // Changed implementation
    }
}
```


This technique allows us to achieve polymorphism. 
Polymorphism is am object-oriented technique that allows use get rid of long procedural switch statements (or conditionals).