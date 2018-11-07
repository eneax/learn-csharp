using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Formatting Strings
                Strings are immutable, so each method will return a new string
                and the original string will not be affected
            */
            var fullName = "Enea Xharja ";
            Console.WriteLine($"Trim: '{fullName.Trim()}'");
            Console.WriteLine($"ToUpper: '{fullName.Trim().ToUpper()}'");


            // Split a string with 'IndexOf'
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);       // from 0 until white space
            var lastName = fullName.Substring(index + 1);       // from index+1 until the end
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");


            // Split a string with 'Split' --> it return a string array
            var names = fullName.Split(' ');
            Console.WriteLine($"firstName: {names[0]}");
            Console.WriteLine($"lastName: {names[1]}");


            // Replace
            Console.WriteLine(fullName.Replace('j', 'J'));


            // Null checking
            if (String.IsNullOrEmpty(" ".Trim()))
            {
                Console.WriteLine("Invalid");
            }

            if (string.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("Invalid");
            }


            // Convert string into number
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);


            // Convert number into string
            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));



            // Exercises for working with Text
            var exercises = new Exercises();
            //exercises.Number1();
            //exercises.Number2();
            exercises.Number3();
        }
    }
}
