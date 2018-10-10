using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradeStatistics result = book.ComputeStatistics();
            Assert.AreEqual(90, result.HighestGrade);
        }
    }
}



/*
- In order to use GradeBook, we need to make a reference to the Grades project
- We do it by going to References and adding a reference from a project
- Moreover we need to be able to access the class from the Grades project 
  and we cannot do it if the access modifier of a class is set to 'internal'
*/



/*
Access Modifiers 
    public      --> visibility everywhere
    private     --> visibility only in the same class
    internal    --> visibility only in the same assembly
*/



/*
Assert.AreEqual(90, result.HighestGrade);
- I expect a result of 90 as a highest grade
*/
