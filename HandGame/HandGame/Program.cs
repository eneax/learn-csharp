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

            // Ask user to choose an option
            Console.Write("Choose between ROCK, PAPER AND SCISSORS:     ");
            inputPlayer = Console.ReadLine();

            // Generate random num from 1 to 3
            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);

            switch (randomInt)
            {
                case 1:
                    inputCPU = "ROCK";
                    break;
                case 2:
                    inputCPU = "PAPER";
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    break;
                default:
                    break;
            }
        }
    }
}
