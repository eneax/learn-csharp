using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get and display app info
            GetAppInfo();

            // Ask user name and greet
            GreetUser();

            // Define game variables
            string inputPlayer, inputCPU;
            int randomInt;

            while (true)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    // Ask user to choose an option
                    Console.Write("Choose between ROCK, PAPER AND SCISSORS:     ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    // Generate random num from 1 to 3
                    Random rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            PrintColorMessage(ConsoleColor.DarkCyan, "Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "DRAW");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "YOU WIN");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "CPU WINS");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            PrintColorMessage(ConsoleColor.DarkCyan, "Computer chose PAPER");
                            if (inputPlayer == "ROCK")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "CPU WINS");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "DRAW");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "YOU WIN");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            PrintColorMessage(ConsoleColor.DarkCyan, "Computer chose SCISSORS");
                            if (inputPlayer == "ROCK")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "YOU WIN");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "CPU WINS");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "DRAW");
                            }
                            break;
                        default:
                            PrintColorMessage(ConsoleColor.DarkRed, "Invalid entry!");
                            break;
                    }

                    PrintColorMessage(ConsoleColor.DarkRed, $"SCORES --> PLAYER: {scorePlayer}, CPU: {scoreCPU}");
                }

                if (scorePlayer == 3)
                {
                    PrintColorMessage(ConsoleColor.Green, "YOU WON THE GAME");
                }
                else if (scoreCPU == 3)
                {
                    PrintColorMessage(ConsoleColor.Green, "CPU WON THE GAME");
                }

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
                    PrintColorMessage(ConsoleColor.Cyan, "Bye Bye!");
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app variables
            string appName = "Rock, Paper, Scissors";
            string appVersion = "1.0.0";
            string appAuthor = "eneax";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

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
