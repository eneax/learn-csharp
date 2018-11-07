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
    }
}
