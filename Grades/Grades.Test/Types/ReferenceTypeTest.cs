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
        public void StringComparisons()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

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

Creating Value Types
- struct 
    * it's very similar to a Class
    * as a rule of thumb, use class by default
    * should represent a single value
    * should be small

- enums (enumeration)
    * a set of named constans
    * underlying data type is 'int' by default
    * if you don't specify a starting value, the default one is 0
*/
