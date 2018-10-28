using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop (example n.1)
            for (int i = 1; i <= 10; i++)
            {
                if ( i % 2 == 0)
                {
                    Console.WriteLine("for loop " + i);
                }
            }


            // reverse for loop
            for (int i = 11; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("reverse for loop " + i);
                }
            }


            // for loop vs foreach loop
            var name = "Enea Xharja";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }


            // foreach loop --> it's better for ienumerable objects (strings and arrays)
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


            // while loop (it's useful when you don't know how many times you are gonna perform an iteration)
            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }


            // while loop (example n.2)
            while (true)
            {
                Console.Write("Enter your name: ");
                string input = Console.ReadLine();

                if (!string.IsNullOrEmpty(input))
                {
                    Console.WriteLine(input);
                    continue;
                }

                break;
            }
        }
    }
}
