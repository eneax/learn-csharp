using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.Name = "Scott's Grade Book";
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", (int)stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}

/*
GradeBook book = new GradeBook();
- this is an implicit constructor
- I use a class to create a book object
- instantiate an instance of a class --> invokes a method called constructor (constructs an object)
- classes are reference types
- variables hold a pointer value

book.AddGrade(89.5f);
- we need 'f' in order to specify that the number is a float and not a double 
*/



/*
using System.Speech.Synthesis;
SpeechSynthesizer synth = new SpeechSynthesizer();
synth.Speak("Hello, this is the grade book program");

- In order to use the SpeechSynthesizer class, we have to add System.Speech to Assembly References 
  and import System.Speech.Synthesis;
- A .Net Assembly is a file that contains our compiled code
- Assemlies are .exe or .dll files (they contain metadata about all types inside)
    * .exe is an executable file (just double click on it on Windows)
    * .dll (Dynamic Link Library) cannot be executed directly, but another program can load it and 
      use the code inside (as a reusable piece of code)
*/



/*
Methods
- are all about behavior
- every method has a return type (void, if no value is returned)
- it has 0 or more parameters
    * use 'params' keyword to accept a variable number of parameters
- every method has a signature (name of method + parameter)
*/


/*
Console.WriteLine("{0}: {1}", description, result);
- 0 and 1 are like placeholders for description and result

Console.WriteLine("{0}: {1:F2}", description, result);
- takes the result and returns a float with 2 decimal numbers

Console.WriteLine("{0}: {1:C}", description, result);
- format result as a currency
*/



/*
Fields
- it defines the variables (state or data) inside a class
- it can be readonly
- it's common to make them private and hide them from the outside
- we make them available on the outside thanks to properties
*/



/*
Properties
- are all about state

- it defines a get and/or set accessor
    * used to expose and control fields

- auto-implemented properties use a hidden field
    public string Name
    {
        get;
        set;
    }

- allow you to write some logic into a get and set accessor

- use public property and private fields
*/