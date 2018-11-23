# Access Modifiers

Your classes should be like a black box (limited visibility from the outside or Encapsulation).

- Public --> A member declared as public is accessible everywhere

```
public class Customer
{
    public void Promote()
    {
    }
}

var customer = new Customer();
customer.Promote();
```


- Private --> A member declared as private is accessible only from the class

```
public class Customer
{
    private void CalculateRating()
    {
    }
}

var customer = new Customer();
customer.CalculateRating();     // not accessible
```


- Protected --> A member declared as protected is accessibly only from the class and its derived classes. 
            --> Protected breaks encapsulation, because the implementation details of a class will leak into its derived classes

```
public class Customer
{
    protected void CalculateRating()
    {
    }
}

var customer = new Customer();
customer.CalculateRating();
```


- Internal --> A member declared as internal is accessibly only from the same assembly.

```
internal class RateCalculator
{
}

// in the same assembly --> allowed
var calc = new RateCalculator();

// in another assembly --> not allowed
var calc = new RateCalculator();
```


- Protected Internal --> A member declared as protected internal is accessible only from the same assembly or any derived classes

```
public class Customer
{
    protected internal void Weirdo()
    {
    }
}
```