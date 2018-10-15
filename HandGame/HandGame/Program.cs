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
                            Console.WriteLine("Computer chose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("CPU WINS");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS");
                                scorePlayer++;
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW");
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine($"SCORES --> PLAYER: {scorePlayer}, CPU: {scoreCPU}");
                }

                if (scorePlayer == 3)
                {
                    Console.WriteLine("Player WON");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("CPU WON");
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
                    Console.WriteLine("Bye bye!");
                    return;
                }
            }
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
    }
}
