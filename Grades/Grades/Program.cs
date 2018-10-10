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
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine("Average Grade " + stats.AverageGrade);
            Console.WriteLine("Highest Grade " + stats.HighestGrade);
            Console.WriteLine("Lowest Grade " + stats.LowestGrade);
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
