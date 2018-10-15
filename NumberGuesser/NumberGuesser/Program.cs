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
            // Get and display app info
            GetAppInfo();

            // Ask user name and greet
            GreetUser();

            while (true)
            {
                // Create a new random object (from 1 to 10)
                Random random = new Random();

                // Init currect number
                int correctNumber = random.Next(1, 10);

                // Init guess variable
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // While guess is not correct
                while (guess != correctNumber)
                {
                    // Get user input
                    string input = Console.ReadLine();

                    // Make sure it's a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number!");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put to guess variable
                    guess = int.Parse(input);

                    // Match guess to correct number
                    if (guess < correctNumber)
                    {
                        // Print error message for guess < correctNumber
                        PrintColorMessage(ConsoleColor.Red, $"Wrong number, the number I'm thinking of is greater than {guess}");
                    }
                    else if (guess > correctNumber)
                    {
                        // Print error message for guess > correctNumber
                        PrintColorMessage(ConsoleColor.Red, $"Wrong number, the number I'm thinking of is lower than {guess}");
                    }
                }

                // Print success message
                PrintColorMessage(ConsoleColor.Yellow, "You are correct!");

                // Ask user to play again
                Console.WriteLine("Play again? [y or n]");

                // Get answer
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo()
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
        }

        // Ask user name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user name
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell users it's not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}

/*
- We use classes to create objects
- When we use static, we refer to the function itself
- Main --> Entry Point Method (a method is like a function inside a class)
*/
