using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working with Dates
            var dateTime = new DateTime(2018, 1, 1);


            // Get current date 
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minutes: " + now.Minute);


            // DateTime is immutable --> to modify, we need to use Add
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);


            // Format DateTime to a string
            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());


            // Custom Date and Time Format Strings
            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }
    }
}
