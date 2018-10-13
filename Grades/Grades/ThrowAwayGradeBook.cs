using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                // grade I'm looking at and existing lowest score
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

            return base.ComputeStatistics();
        }
    }
}

/*
Inheritance
- relationship between two classes, where one class takes on the members of another class

base.ComputeStatistics();
- allows me to use 'ComputeStatistics' from the base class I inherited from GradeBook
*/



/*
Polymorphism = "many shapes"
- one var can point to different types of objects
*/
