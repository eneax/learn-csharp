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
            // Define variables
            string inputPlayer, inputCPU;
            int randomInt;
            int scorePlayer = 0;
            int scoreCPU = 0;

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
                    break;
            }
        }
    }
}
