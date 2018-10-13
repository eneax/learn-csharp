using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "eneax";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Print out app info
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            // Reset text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user name
            string input = Console.ReadLine();

            Console.WriteLine($"Hello {input}, let's play a game...");
        }
    }
}

/*
- We use classes to create objects
- When we use static, we refer to the function itself
- Main --> Entry Point Method (a method is like a function inside a class)
*/
