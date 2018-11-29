using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
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

            // Start playing
            while (true)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;

                while (scorePlayer < 3 && scoreCPU < 3)
                {
                    // Ask user to choose an option
                    Console.Write("Choose between ROCK [1], PAPER [2] AND SCISSORS [3]:     ");
                    inputPlayer = Console.ReadLine().ToUpper();
                     
                    // Generate random num from 1 to 3
                    var rnd = new Random();
                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            
                            if (inputPlayer == "ROCK" || inputPlayer == "1")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "DRAW");
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "2")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "YOU WIN");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS" || inputPlayer == "3")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "CPU WINS");
                                scoreCPU++;
                            }
                            else
                            {
                                PrintColorMessage(ConsoleColor.DarkRed, "Invalid entry!");
                                continue;
                            }
                            PrintColorMessage(ConsoleColor.DarkCyan, $"Computer chose {inputCPU}");
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            
                            if (inputPlayer == "ROCK" || inputPlayer == "1")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "CPU WINS");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "2")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "DRAW");
                            }
                            else if (inputPlayer == "SCISSORS" || inputPlayer == "3")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "YOU WIN");
                                scorePlayer++;
                            }
                            else
                            {
                                PrintColorMessage(ConsoleColor.DarkRed, "Invalid entry!");
                                continue;
                            }
                            PrintColorMessage(ConsoleColor.DarkCyan, $"Computer chose {inputCPU}");
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                           
                            if (inputPlayer == "ROCK" || inputPlayer == "1")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "YOU WIN");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER" || inputPlayer == "2")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "CPU WINS");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS" || inputPlayer == "3")
                            {
                                PrintColorMessage(ConsoleColor.DarkYellow, "DRAW");
                            }
                            else
                            {
                                PrintColorMessage(ConsoleColor.DarkRed, "Invalid entry!");
                                continue;
                            }
                            PrintColorMessage(ConsoleColor.DarkCyan, $"Computer chose {inputCPU}");
                            break;
                        default:
                            PrintColorMessage(ConsoleColor.DarkRed, "Invalid entry!");
                            break;
                    }

                    PrintColorMessage(ConsoleColor.Cyan, $"SCORES --> PLAYER: {scorePlayer}, CPU: {scoreCPU}");
                }

                if (scorePlayer == 3)
                {
                    PrintColorMessage(ConsoleColor.Green, "YOU WON THE GAME");
                }
                else if (scoreCPU == 3)
                {
                    PrintColorMessage(ConsoleColor.Green, "CPU WON THE GAME");
                }

                // Keep asking to play until user answers [y or n]
                while (true)
                {
                    // Ask user to play again
                    Console.WriteLine("Play again? [y or n]");

                    // Get answer
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "y")
                    {
                        break;
                    }
                    else if (answer == "n")
                    {
                        PrintColorMessage(ConsoleColor.Cyan, "Bye Bye!");
                        return;
                    }
                    else
                    {
                        PrintColorMessage(ConsoleColor.DarkRed, "Invalid entry!");
                        continue;
                    }
                }
            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set app variables
            var appName = "Rock, Paper, Scissors";
            var appVersion = "1.0.0";
            var appAuthor = "eneax";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Magenta;

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
            var inputName = Console.ReadLine();

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
