using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        List<float> grades;
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
