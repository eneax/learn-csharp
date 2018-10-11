using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Test.Types
{
    [TestClass]
    public class TypeTest
    {
        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name = name.ToUpper();

            Assert.AreEqual("SCOTT", name);
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;
            IncrementNumber(x);

            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(book2);
            Assert.AreEqual("A GradeBook", book1.Name);
        }

        private void GiveBookAName(GradeBook book)
        {
            book.Name = "A GradeBook";
        }

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
    * string is a reference type, but it behaves like a value type
*/


/*
Value Types
- Variables hold the value
    * No pointers, no references
- They are generally faster than Reference Types to allocate in memory
- They are smaller in size
- Many build-in primitives are value types
    * int, double, float
- They are immutable
    * once you create a value, it cannot change
    * the data inside the value can change

Creating Value Types
- struct (creates a structure)
    * it's very similar to a Class
    * as a rule of thumb, use class by default
    * it should represent a single value
    * it should be small
    * i.e. contact number, currency amount, DateTime

- enums (enumeration)
    * it creates a type that holds specific numerical values
    * useful to create a set of named constans
    * underlying data type is 'int' by default
    * if you don't specify a starting value, the default one is 0
*/



/*
Methods Parameters
- By default parameters are passed "by values"
- Value types pass a copy of the value
*/



/*
IncrementNumber --> doesn't modify the 'x' variable

name.ToUpper(); --> doesn't modify the 'name' string I'm pointing to,
                    instead it creates a new one
*/
