# Constructor
- It's a method that is called when an instance of a class is created
- We need it to initialize an object upon creation
- It's required to have the same name of the class
- Does not have a return type and not even 'void'


```
public class Customer
{
    public Customer()
    {
    }   
}
```

This constructor initializes the fields of the class to their default values:
- numbers   --> set to 0
- bool      --> set to false
- strings   --> set to null
- char      --> set to empty char



Another example of constructor

```
public class Customer
{
    public string Name;

    public Customer(string name)
    {
        this.Name = name;
    }
}

var customer = new Customer("John");
```



## Constructor Overloading

Constructor Overloading means having a method with the same name, but with different signatures.
A signatures is what uniquely identifies a method, for instance: 
- its return type 
- its name
- types and numbers of its parameters

Overloading makes initialization easier.

```
public class Customer
{
    public Customer() { ... }

    public Customer(string name) { ... }

    public Customer(int id, string name) { ... }
}
```