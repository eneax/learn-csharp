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
            double answer;
            string ops;

            // Display app info
            Console.WriteLine("Console Calculator");
            Console.WriteLine("*******************");

            // Prompt user for first number
            Console.WriteLine("Enter first number: ");
            firstNum = Double.Parse(Console.ReadLine());

            // Prompt user for math operator
            Console.WriteLine("Select an operator [+, -, *, /, %, ^]: ");
            ops = Console.ReadLine();

            // Prompt user for second number
            Console.WriteLine("Enter second number: ");
            secondNum = Double.Parse(Console.ReadLine());

            // Set possible answers
            switch (ops)
            {
                case "+":
                    answer = firstNum + secondNum;
                    break;
                case "-":
                    answer = firstNum - secondNum;
                    break;
                case "*":
                    answer = firstNum * secondNum;
                    break;
                case "/":
                    answer = firstNum / secondNum;
                    break;
                case "%":
                    answer = firstNum % secondNum;
                    break;
                case "^":
                    answer = Math.Pow(firstNum, secondNum);
                    break;
                default:
                    answer = 0;
                    break;
            }

            // Print final result
            Console.WriteLine($"{firstNum} {ops} {secondNum} = {answer}");
            Console.ReadKey();
        }
    }
}
