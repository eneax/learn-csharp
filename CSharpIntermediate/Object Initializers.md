# Object Initializers

- It's a syntax for quickly initializing an object without the need to call one of its constructors.
- It can be very useful to avoid creating multiple constructors.


```
public class Person
{
    public int Id;
    public string FirstName;
    public string LastName;
    public DateTime BirthDate;
}
```


## Initialize a Person class with constructors

```
public class Person
{
    public Person(int id) { }

    public Person(int id, string firstName) { }

    public Person(int id, string firstName, string lastName) { }

    public Person(int id, DateTime birthDate) { }
}
```


## Initialize a Person class with object initializers

```
var person = new Person
{
    FirstName = "Enea",
    LastName = "Xharja"
};
```