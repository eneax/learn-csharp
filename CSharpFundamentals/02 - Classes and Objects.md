# Classes and Objects

Classes are the building blocks of our applications. 
They combine related variables (fields) and functions (methods) together.
A class is a type or blueprint that we use to create objects, so an object is an instance of a class.


## How to create a class
 ```public class Person 
{
    public string Name;

    public void Introduce()
    {
        Console.WriteLine("Hi, my name is " + Name);
    }
}
 ```


 ```public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
}
 ```

- public is the access modifier: it determines who can access this class
- inside a class we can have variables, that we call 'fields'
- void means that the method doesn't return anything
- the Introduce method doesn't take any parameters
- the Add method takes two parameters of type integer


## How to create an object
Person person = new Person();
person.Name = "Enea";
person.Introduce();

In order to create an object, we need to specify a type (Person) and an identifier (person),
plus we need to allocate memory for it (using the 'new' keyword) and finally repeat the type of the class followed by '()'.

Once we create an object, we can access his methods with the dot notation.



## Static Modifier
 ```public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

int result = Calculator.Add(2, 2);


public class Program
{
    static void Main()
    {        
    }
}
 ```

- we don't need to create an object to access a static member
- the method can be accessed by the class itself
- there is only one instance of the Main method in memory and there is only one entry point in each C# app
- WriteLine() is a static method created inside the Console class, so you can just write Console.WriteLine(),
  without having the create any object
- all methods of the Console class are defined as static, because we have only one Console when we run the app