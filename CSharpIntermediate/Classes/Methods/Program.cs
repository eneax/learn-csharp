using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Out Modifier Example

            // Parse --> FormatExeption (it's an invalid string)
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("Conversion failed!");
            }

            /*
               TryParse 
               - returns a bool to show if the conversion was successful or not
               - it doesn't throw an exception like int.Parse
            */
            int number2;
            var result = int.TryParse("abc", out number2);
            if (result)
            {
                Console.WriteLine(number2);
            }
            else
            {
                Console.WriteLine("Conversion failed!");
            }
        }

        // Params Example
        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        // Points Example
        static void UsePoints()
        {
            try
            {
                // create a point object
                var point = new Point(10, 20);

                // call Move method and pass a point object
                point.Move(new Point(40, 60));
                Console.WriteLine($"Point is at: ({point.X}, {point.Y})");

                // call Move method and pass coordinates
                point.Move(100, 200);
                Console.WriteLine($"Point is at: ({point.X}, {point.Y})");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("An unexpected error occurred!");
            }
        }
    }
}
