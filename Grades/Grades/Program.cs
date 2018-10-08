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
        }
    }
}

/*
GradeBook book = new GradeBook();
- this is an implicit constructor
- I use a class to create a book object
- instantiate an instance of a class --> invokes a method called constructor (constructs an object)

book.AddGrade(89.5f);
- we need 'f' in order to specify that the number is a float and not a double 

*/
