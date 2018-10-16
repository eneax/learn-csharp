using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define app variables
            double firstNum;
            double secondNum;
            double input;
            string ops;

            // Display app info
            Console.WriteLine("Console Calculator");
            Console.WriteLine("*******************");

            while (true)
            {
                // Prompt user for first number
                Console.Write("\nEnter first number:    ");
                firstNum = Double.Parse(Console.ReadLine());

                // Prompt user for math operator
                Console.Write("Select an operator [+, -, *, /, %, ^]:   ");
                ops = Console.ReadLine();

                // Prompt user for second number
                Console.Write("Enter second number:     ");
                secondNum = Double.Parse(Console.ReadLine());

                // Set possible answers
                switch (ops)
                {
                    case "+":
                        input = firstNum + secondNum;
                        break;
                    case "-":
                        input = firstNum - secondNum;
                        break;
                    case "*":
                        input = firstNum * secondNum;
                        break;
                    case "/":
                        input = firstNum / secondNum;
                        break;
                    case "%":
                        input = firstNum % secondNum;
                        break;
                    case "^":
                        input = Math.Pow(firstNum, secondNum);
                        break;
                    default:
                        input = 0;
                        break;
                }

                // Print final result
                Console.WriteLine($"\nFinal result: {firstNum} {ops} {secondNum} = {input}");


                // Keep asking to run calc again until user answers [y or n]
                while (true)
                {
                    // Ask user to run again
                    Console.WriteLine("\n\nRun again? [y or n]");

                    // Get answer
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "y")
                    {
                        break;
                    }
                    else if (answer == "n")
                    {
                        Console.WriteLine("\nBye Bye!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry!");
                        continue;
                    }
                }
            }
        }
    }
}
