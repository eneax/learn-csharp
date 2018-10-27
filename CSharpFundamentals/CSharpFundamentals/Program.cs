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

            // Arrays
            int[] numbers = new int[3];
            numbers[0] = 1;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);


            var flags = new bool[3];
            flags[0] = true;

            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);


            var names = new string[3] { "Jim", "John", "Jack" };


            // Strings
            var firstName = "Enea";
            var lastName = "Xharja";

            var fullName = firstName + " " + lastName;
            var fullName2 = string.Format("My name is {0} {1}", firstName, lastName);
            var fullName3 = $"My name is {firstName} {lastName}";

            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);
            Console.WriteLine(fullName3);


            var namesArr = new string[3] { "Jim", "John", "Jack" };
            var formattedNames = string.Join(", ", namesArr);
            Console.WriteLine(formattedNames);


            // Verbatim Strings
            var text = @"Hi Enea
Look into the following path
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(text);



            // Enums
            var method = ShippingMethod.ExpressMail;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            // Convert 'method' into string
            Console.WriteLine(method.ToString());

            // Convert (or Parse) string into ShippingMethod
            var methodName = "ExpressMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }

        // Enums example
        public enum ShippingMethod
        {
            RegularMail = 1,
            FastMail = 2,
            ExpressMail = 3,
        }
    }
}
