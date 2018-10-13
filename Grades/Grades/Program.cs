using System;
using System.Collections.Generic;
using System.IO;
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
            GetBookName(book);
            AddGrades(book);
            SaveGrades(book);
            WriteResults(book);
        }

        private static void WriteResults(GradeBook book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        private static void SaveGrades(GradeBook book)
        {
            using (StreamWriter outputFile = File.CreateText("grade.txt"))
            {
                book.WriteGrades(outputFile);
            }
        }

        private static void AddGrades(GradeBook book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName(GradeBook book)
        {
            try
            {
                Console.WriteLine("Enter a name: ");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}");
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



/*
Events
- allows a class to send notifications to other classes or objects
- the publisher (or a button being clicked) raises an event
- the subscriber (or the code interested in the event) subscribes to the event
- you can have multiple subscribers listening to an event
- the publisher doesn't have to keep track of who is subscribing
- the subscribers don't need to know about each other
- everything is handled by delegates
*/



/*
Delegates
- a delegate is a type that references methods
- they can reference multiple methods (multicast delegates)

* For instance...
public delegate void Writer(string message);

 public class Logger 
 {
    public void WriteMessage(string message)
    {
        Console.WriteLine(message);
    }
 }

Logger logger = new Logger();
Writer writer = new Writer(logger.WriteMessage);
writer("Success");
*/


/*
Console.Out represents the output stream that goes to the console window
book.WriteGrades(Console.Out);
*/



/*
Finally
- Finally code adds finalization code 
    * i.e. code that cleans up resources that have been acquired previously
- it will always execute even if there is an exception inseide the block 
*/