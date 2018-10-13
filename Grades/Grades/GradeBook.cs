using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();
        }

        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics");

            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public override void WriteGrades(TextWriter destination)
        {
            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }
        }

        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public override IEnumerator GetEnumerator()
        {
            return grades.GetEnumerator();
        }

        // protected can be accessed from this class or a derived class
        protected List<float> grades;
    }
}

/*
GradeBook State
- state is the data that you need in order to work inside a class
- the grades for a user

GradeBook Behavior (methods)
- add a new grade
- calculate statistics
*/



/*
public void AddGrade(float grade) {}
- it's a method
- the parenthesis are used to pass parameters to the method
- grade is scoped to the AddGrade method
*/



/*
System.Collections.Generic
- contains several collections and one of them is List<>
*/




/*
public GradeBook() {}
- explicit constructor
*/



/*
Encapsulation
- Enclosing or hiding details


Access Modifiers (public or private)
- the GradeBook constructor is public
- AddGrade method is public
- grades is private
*/



/*
static
- use static members of a class without creating an instance
- Console.WriteLine() --> Console is static
*/



/*
stats.AverageGrade = sum / grades.Count;
- Count tells you how many items are inside a list
*/



/*
@out --> escapes the out reserved keyword in C#
*/



/*
Jumping
    * break      --> break out of a loop and stop looping
    * continue   --> skip executing any conde after the 'continue' statement and go to the next iteration of the loop
    * goto       --> jump to a statement marked by a label
    * return     --> you can use a return in a void method (break out of loop and jump out of method)
    * throw
*/



/*
Throwing Exceptions
- use throw to raise an exception
- when you throw an exception, you throw an object
- an exception is a signal that an error exists
- use it only in excceptional cases 
  (i.e. bad input value, program out of memory, network not available for comunication)
*/



/*
Handling Exceptions 
- handle exception using a try block
- the try block is then followed by a catch statement
*/



/*
Chaining Catch Blocks
- place most specific type in the first catch clause
- catching a System.Exception catches everything
    * except for few 'special' exceptions
*/