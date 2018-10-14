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
            string inputName = Console.ReadLine();

            Console.WriteLine($"Hello {inputName}, let's play a game...");

            while (true)
            {
                // Create a new random object (from 1 to 10)
                Random random = new Random();

                // Init currect number
                int correctNumber = random.Next(1, 10);

                // Init guess var
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
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell users it's not a number
                        Console.WriteLine("Please enter an actual number!");

                        // Reset text color
                        Console.ResetColor();

                        // Keep going
                        continue;
                    }

                    // Cast to int and put to guess var
                    guess = int.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // Tell user it's the wrong number
                        Console.WriteLine("Wrong number, please try again!!");

                        // Reset text color
                        Console.ResetColor();
                    }
                }

                // Output success message
                // Change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Tell user it's the right number
                Console.WriteLine("You are correct!");

                // Reset text color
                Console.ResetColor();

                // Ask user to play again
                Console.WriteLine("Play again? [y or n]");

                // Get answer
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    continue;
                }
                else if (answer == "n")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }
    }
}

/*
- We use classes to create objects
- When we use static, we refer to the function itself
- Main --> Entry Point Method (a method is like a function inside a class)
*/
