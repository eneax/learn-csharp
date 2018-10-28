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
            /*
            CLASSES AND OBJECTS EXAMPLE

            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "McGill";
            john.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(3, 5);
            Console.WriteLine(result);

            */



            /*
            ARRAYS EXAMPLE
            
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

            */



            /*
            STRINGS EXAMPLE
            
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

            */



            /*
            Verbatim Strings
            VERBATIM STRINGS EXAMPLE

            var text = @"Hi Enea
Look into the following path
c:\folder1\folder2
c:\folder3\folder4";

            Console.WriteLine(text);

            */



            /*
            ENUMS EXAMPLE
            
            var method = ShippingMethod.ExpressMail;
            Console.WriteLine((int)method);

            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);

            // Convert 'method' into string
            Console.WriteLine(method.ToString());

            // Convert (or Parse) string into ShippingMethod
            var methodName = "ExpressMail";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);

            */




            /*
            VALUE TYPES AND REFERENCE TYPES EXAMPLE 1

            var a = 10;
            var b = a;
            b++;
            // A copy of 'a' is copied into 'b', so 'a' doesn't change
            Console.WriteLine(string.Format($"a: {a}, b: {b}"));


            var arr1 = new int[3] { 1, 2, 3 };
            var arr2 = arr1;
            arr2[0] = 0;
            // Both arr1 and arr2 (located in the 'stack') reference the values { 1, 2, 3 } (located in the 'heap')
            Console.WriteLine(string.Format($"arr1[0] --> {arr1[0]}, arr2[0] --> {arr2[0]}"));

            */



            var number = 1;
            Increment(number);
            Console.WriteLine(number); // 1

            // Create object with 'object initialization syntax'
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age); // 30
        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
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
