# Properties

A property is a class member that encapsulates a getter/setter for accessing a field.
We may need a property in order to write a getter/setter with less code.

```
public class Person
{
    private DateTime _birthdate;

    public void SetBirthdate(DateTime birthdate)
    {
        this._birthdate = birthdate;
    }

    public DateTime GetBirthdate()
    {
        return _birthdate;
    }
}
```

We can convert the code above using properties:

```
public class Person
{
    private DateTime _birthdate;

    public DateTime BirthDate
    {
        get { return _birthdate; }
        set { _birthdate = value; }
    }
}
```

Using auto-implemented properties, 
the C# compiler will automatically create a private field.

```
public class Person
{
    public DateTime BirthDate { get; set; }
}
```