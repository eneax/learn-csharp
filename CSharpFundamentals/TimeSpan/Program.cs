using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeSpanExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a TimeSpan 

            // First way to create a TimeSpan (represents a length of time)
            var timeSpan = new TimeSpan(1, 2, 3);

            // 1h, 0 min, 0 sec
            var timeSpan2 = new TimeSpan(1, 0, 0);

            // Second and a more readable way to create a TimeSpan
            var timeSpan3 = TimeSpan.FromHours(1);

            // Third way to create a TimeSpan
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);


            // TimeSpan Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total minutes: " + timeSpan.TotalMinutes);


            /*
            TimeSpan is immutable (just like DateTime), 
            but we can use 'Add' and 'Subtract' for changes

            Add and Subtract create a new TimeSpan
            */
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));


            // Convert TimeSpan to String --> ToString()
            Console.WriteLine("ToString Example: " + timeSpan.ToString());


            // Convert String to TimeSpan --> Parse
            Console.WriteLine("Parse Example: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
