using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        private List<float> grades;

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
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
