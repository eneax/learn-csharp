# Object Oriented Programming

- Encapsulation
- Inheritance
- Polymorphism


## Encapsulation

We want to design the classes to do only one job and do it perfectly.
Sometimes, we want the classes to hide some information and display only 
some parts of the code.
Objects should reveal what they can do, instead of how they do it. 

- Define fields as private 
- Provide getter / setter methods as public

Fields is the implementation details that we hide from the outside.

```
public class Person
{
    private string _name;

    public void SetName(string name)
    {
        if(!String.IsNullOrEmpty(name))
        {
            this._name = name;
        }
    }

    public strings GetName()
    {
        return _name;
    }
}
```

## Access Modifiers

It's a way to control access to a class and/or its members.
It's useful in order to create some safety in our application.

```
public class Customer
{
    private string Name;
}

var john = new Customer();
john.Name; // it won't compile
```