using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades;
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