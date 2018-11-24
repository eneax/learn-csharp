# Sealed Classes and Members

Prevents derivation of classes or overriding of methods.

- If applied to a class, prevents derivation from that class.
(we cannot create a class that derives from Circle)

```
public sealed class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Draw a circle");
    }
}
```


- If applied to a method, prevents overriding of that method in a derived class.

```
public class Circle : Shape
{
    public sealed override void Draw()
    {
        Console.WriteLine("Draw a circle");
    }
}
```
