using CSharpFundamentals.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "McGill";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(3, 5);
            Console.WriteLine(result);
        }
    }
}
