using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

/*
Unit Testing

- it's where I write some C# code to test some other C# code in an automatic manner
- it produces an assembly with the test code
- [TestClass] and [TestMethod] are attributes (piece of data associated with a class or method)
- we can use an Assert class to make assertion about a particular piece of data or particular piece of code
    Assert.AreEqual(3, 4); --> test will fail
    Assert.AreEqual(3, 3); --> test will pass
*/
