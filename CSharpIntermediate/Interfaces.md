# Interfaces

- An interface is a language construct that is similar to a class (in terms of syntax) but is fundamentally different.
- An interface is simply a declaration of the capabilities (or services) that a class should provide.

```
public interface ITaxCalculator
{
    int Calculate();
}
```

As you can see, interfaces don't have neither an implementation nor public modifiers.
The interface above states that, a class that wants to play the role of a tax calculator, 
should provide a method called Calculate() that takes no parameters and returns an int. 

The implementation of this class might look like this:

```
public class TaxCalculator : ITaxCalculator
{
    public void Calculate() 
    {
    }
}
```

Finally
- an interface is purely a declaration. Members of an interface do not have implementation.
- an interface can only declare methods and properties, but not fields (because fields are about implementation detail).
- interfaces help building loosely coupled applications. 
  We reduce the coupling between two classes by putting an interface between them. 
  This way, if one of these classes changes, it will have no impact on the class that is dependent on that 
  (as long as the interface is kept the same).
