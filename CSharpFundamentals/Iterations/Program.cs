using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            // 'for loop' (example n.1)
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("for loop " + i);
                }
            }


            // Reverse 'for loop'
            for (int i = 11; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("reverse for loop " + i);
                }
            }


            // for loop vs foreach loop
            var name = "Enea Xharja";

            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }


            // foreach loop --> it's better for ienumerable objects (strings and arrays)
            var numbers = new int[] { 1, 2, 3, 4 };

            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }


            // while loop (it's useful when you don't know how many times you are gonna perform an iteration)
            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }


            // while loop (example n.2)
            while (true)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                if (!string.IsNullOrEmpty(name))
                {
                    Console.WriteLine(name);
                    continue;
                }

                break;
            }



            /*
            Ex. 1
            Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
            Display the count on the console.
            */
            var count = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
                Console.WriteLine($"There are {count} numbers divisible by 3 between 1 and 100.");
            }


            /*
            Ex. 2
            Write a program and continuously ask the user to enter a number or "ok" to exit. 
            Calculate the sum of all the previously entered numbers and display it on the console.
            */
            var sum = 0;
            while (true)
            {
                Console.Write("Enter a number or 'ok' to exit: ");
                var entry = Console.ReadLine();

                if (entry.ToLower() == "ok")
                {
                    break;
                }

                var num = int.Parse(entry);
                sum += num;

                Console.WriteLine($"Sum of all numbers is: {sum}");
            }



            /*
            Ex. 3
            Write a program and ask the user to enter a number. 
            Compute the factorial of the number and print it on the console. 
            For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            */
            Console.WriteLine("Enter a number: ");
            var number = int.Parse(Console.ReadLine());

            var factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{number}! = {factorial}");



            /*
            Ex. 4
            Write a program that picks a random number between 1 and 10. 
            Give the user 4 chances to guess the number. 
            If the user guesses the number, display “You won"; otherwise, display “You lost". 
            (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            */
            Random random = new Random();
            var rnd = random.Next(1, 10);

            var shots = 4;
            while (shots > 0)
            {
                Console.WriteLine("Guess the number: ");
                var guess = int.Parse(Console.ReadLine());

                var message = (guess == rnd) ? "You won" : "You lost";
                Console.WriteLine(message);

                shots--;
            }



            /*
            Ex. 5
            Write a program and ask the user to enter a series of numbers separated by comma. 
            Find the maximum of the numbers and display it on the console. 
            For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            */
            Console.WriteLine("Enter a series of numbers separated by comma: ");
            var input = Console.ReadLine();

            var numbersList = input.Split(',');

            var max = int.Parse(numbersList[0]);

            foreach (var str in numbersList)
            {
                var num = int.Parse(str);

                if (num > max)
                {
                    max = num;
                }
            }

            Console.WriteLine($"Max is {max}");
        }
    }
}
