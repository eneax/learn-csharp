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



## Interfaces and Testability

Unit testing is part of the automated practice which helps improve the quality of our code. 
With automated testing, we write code to test our own code. This helps catching bugs early on as we change the code.

In order to unit test a class, we need to isolate it. 
This means: we need to assume that every other class in our application is working properly and 
see if the class under test is working as expected.

A class that has tight dependencies to other classes cannot be isolated.
To solve this problem, we use an interface. Here is an example:

```
public class OrderProcessor
{
    private IShippingCalculator _calculator;

    public Customer(IShippingCalculator calculator)
    {
        _calculator = calculator;
    }

    ...
}
```

OrderProcessor is not dependent on the ShippingCalculator class. 
It’s only dependent on an interface (IShippingCalculator). 
If we change the code inside the ShippingCalculator (i.e. add a new method or change the method implementations),
it will have no impact on OrderProcessor (as long as the interface is kept the same).