using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    public class Exercises
    {
        /*
        Ex. 1
        Write a program and ask the user to enter a few numbers separated by a hyphen. 
        Work out if the numbers are consecutive. 
        For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", 
        display a message: "Consecutive"; otherwise, display "Not Consecutive".
        */
        public void Number1()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var item in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(item));
            }
            numbers.Sort();
            
            var isConsecutive = true;
            for (int i = 1; i < numbers.Count; i++)
            {
                if (numbers[0] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }

            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }



        /*
        Ex. 2
        Write a program and ask the user to enter a few numbers separated by a hyphen. 
        If the user simply presses Enter, without supplying an input, exit immediately; 
        otherwise, check to see if there are duplicates. If so, display "Duplicate" on the console.
        */
        public void Number2()
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen: ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var item in input.Split('-'))
            {
                numbers.Add(Convert.ToInt32(item));
            }
            numbers.Sort();

            var includesDuplicates = false;
            var uniques = new List<int>();

            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
            {
                Console.WriteLine("Duplicate");
            }
        }



        /*
        Ex. 3
        Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
        A valid time should be between 00:00 and 23:59. 
        If the time is valid, display "Ok"; otherwise, display "Invalid Time". 
        If the user doesn't provide any values, consider it as invalid time. 
        */
        public void Number3()
        {
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00).");
            var input = TimeSpan.Parse(Console.ReadLine());

            var timeStart = new TimeSpan(0, 0, 0);
            var timeEnd = new TimeSpan(23, 59, 0);

            if (input > timeStart && input < timeEnd)
            {
                Console.WriteLine("OK");
            }
            else
            {
                Console.WriteLine("Invalid Time");
            }
        }

        // Alternative Ex.3 solution
        public void Exercise3()
        {
            Console.Write("Enter time: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            try
            {
                var hour = Convert.ToInt32(components[0]);
                var minute = Convert.ToInt32(components[1]);

                if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time");
            }
        }
    }
}
