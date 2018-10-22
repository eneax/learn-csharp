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
            double firstNum, secondNum;
            double result = 0.0;
            char ops;

            // Display app info
            Console.WriteLine("Console Calculator");
            Console.WriteLine("*******************");

            while (true)
            {
                try
                {
                    // Prompt user for first number
                    Console.Write("Enter a number: ");
                    firstNum = double.Parse(Console.ReadLine());
                    
                    // Prompt user for operator
                    Console.Write("Enter an operator: ");
                    ops = char.Parse(Console.ReadLine());

                    // Prompt user for second number
                    Console.Write("Enter a number: ");
                    secondNum = double.Parse(Console.ReadLine());

                    if (ops != '+' &&
                        ops != '-' &&
                        ops != '*' &&
                        ops != '/')
                        throw new Exception(ops.ToString());

                    if (ops == '/') if (ops == 0)
                        throw new DivideByZeroException("It is not allowed to divide by zero!");

                    switch (ops)
                    {
                        case '+':
                            result = firstNum + secondNum;
                            break;
                        case '-':
                            result = firstNum - secondNum;
                            break;
                        case '*':
                            result = firstNum * secondNum;
                            break;
                        case '/':
                            result = firstNum / secondNum;
                            break;
                        default:
                            Console.WriteLine("Bad Operation");
                            break;
                    }

                    // Print final result
                    Console.WriteLine($"\nFinal result: {firstNum} {ops} {secondNum} = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nOperation Error: {ex.Message} is not a valid operator");
                }
                Console.ReadKey();

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
