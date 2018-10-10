using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class ReferenceTypeTest
    {
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }

        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scott's grade book";
            Assert.AreNotEqual(g1.Name, g2.Name);
        }
    }
}

/*
Reference Types
- Variables store a reference to an object 
    * every time I create a class, I'm creating a new reference type
    * multiple variables can point to the same object
*/


/*
Value Types
- Variables hold the value
    * No pointers, no references
- They are generally faster than Reference Types to allocate in memory
- They are smaller in size
- Many build-in primitives are value types
    * int, double, float
*/
