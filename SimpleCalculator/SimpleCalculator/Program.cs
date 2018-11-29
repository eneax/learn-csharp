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
            GetAppInfo();
            PrintColorMessage(ConsoleColor.DarkCyan, "*******************************************");

            while (true)
            {
                try
                {
                    // Prompt user for first number
                    Console.Write("\nEnter a number:      ");
                    firstNum = double.Parse(Console.ReadLine());
                    
                    // Prompt user for operator
                    Console.Write("Enter an operator (+, -, *, /, %, ^):    ");
                    ops = char.Parse(Console.ReadLine());

                    // Prompt user for second number
                    Console.Write("Enter a number:      ");
                    secondNum = double.Parse(Console.ReadLine());

                    if (ops != '+' &&
                        ops != '-' &&
                        ops != '*' &&
                        ops != '/' &&
                        ops != '%' &&
                        ops != '^')
                        throw new Exception(ops.ToString());

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
                        case '%':
                            result = firstNum % secondNum;
                            break;
                        case '^':
                            result = Math.Pow(firstNum, secondNum);
                            break;
                        default:
                            PrintColorMessage(ConsoleColor.DarkRed, "Bad Operation!");
                            break;
                    }

                    // Print final result
                    PrintColorMessage(ConsoleColor.DarkGreen, $"\nFinal result: {firstNum} {ops} {secondNum} = {result}");
                }
                catch (FormatException)
                {
                    PrintColorMessage(ConsoleColor.DarkRed, "Only numbers are allowed!");
                }
                catch (Exception ex)
                {
                    PrintColorMessage(ConsoleColor.DarkRed, $"\nOperation Error: {ex.Message} is not a valid operator");
                }

                // Keep asking to run calc again until user answers [y or n]
                while (true)
                {
                    // Ask user to run again
                    PrintColorMessage(ConsoleColor.DarkYellow, "\n\nRun again? [y or n]");

                    // Get answer
                    var answer = Console.ReadLine().ToLower();

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
                        PrintColorMessage(ConsoleColor.DarkRed, "Invalid entry!");
                        continue;
                    }
                }
            }
        }

        // Display app info
        static void GetAppInfo()
        {
            // Set app variables
            var appName = "Simple Calculator";
            var appVersion = "1.0.0";
            var appAuthor = "eneax";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Print out app info
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            // Reset text color
            Console.ResetColor();
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
