using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            // Add() --> it adds an object to a list
            numbers.Add(1);


            // AddRange() --> add another list or array of lists
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }


            /*
            IndexOf() 
                - returns the index of a given object or '-1' if object doesn't exist
                - it searches from the beginning of the List
                - LastIndexOf searches from the end of the List
            */
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));


            // Count() --> returns the number of objects in the list
            Console.WriteLine("Count: " + numbers.Count());


            /*
            Remove()
                - cannot modify a collection from within a 'foreach' group
            */
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            // we removed both '1s' from the list


            // Clear() --> removes all items from the List
            numbers.Clear();
            Console.WriteLine("Count of numbers: " + numbers.Count());



            // Exercises
            var exercises = new Exercises();
            //exercises.Number1();
            //exercises.Number2();
            //exercises.Number3();
            //exercises.Number4();
            exercises.Number5();
        }
    }



    public class Exercises
    {
        /*
          Ex. 1
              When you post a message on Facebook, depending on the number of people who like your post, 
              Facebook displays different information.

              - If no one likes your post, it doesn't display anything.
              - If only one person likes your post, it displays: [Friend's Name] likes your post.
              - If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
              - If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.

              Write a program and continuously ask the user to enter different names, 
              until the user presses Enter (without supplying a name). 
              Depending on the number of names provided, display a message based on the above pattern. 
        */
        public void Number1()
        {
            var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");

                var input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    break;
                }
                names.Add(input);
            }

            if (names.Count > 2)
            {
                Console.WriteLine($"{names[0]}, {names[1]} and other {names.Count - 2} liked your post!");
            }
            else if (names.Count == 2)
            {
                Console.WriteLine($"{names[0]} and {names[1]} liked your post!");
            }
            else if (names.Count == 1)
            {
                Console.WriteLine($"{names[0]} liked your post!");
            }
            else
            {
                Console.WriteLine();
            }
        }



        /*
        Ex. 2 
        Write a program and ask the user to enter their name. 
        Use an array to reverse the name and then store the result in a new string. 
        Display the reversed name on the console.

        (ToCharArray converts strings to character arrays. 
         It is called on a string and returns a new char array.)
        */
        public void Number2()
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();

            var charArray = name.ToCharArray();
            Array.Reverse(charArray);

            var reversed = new string(charArray);
            Console.WriteLine("Reversed name: " + reversed);
        }



        /*
        Ex. 3
        Write a program and ask the user to enter 5 numbers.
        If a number has been previously entered, display an error message and ask the user to re-try. 
        Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
        */
        public void Number3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                {
                    Console.WriteLine($"You've already entered {number}");
                    continue;
                }

                numbers.Add(number);
            }

            numbers.Sort();

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
        }



        /*
        Ex. 4 
        Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
        The list of numbers may include duplicates. Display the unique numbers that the user has entered.
        */
        public void Number4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number or type 'Quit' to exit: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                numbers.Add(Convert.ToInt32(input));
            }

            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                {
                    uniques.Add(number);
                }
            }

            Console.WriteLine("Unique numbers:");
            foreach (var item in uniques)
            {
                Console.WriteLine(item);
            }
        }



        /*
        Ex. 5
        Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). 
        If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
        otherwise, display the 3 smallest numbers in the list.
        */
        public void Number5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers (e.g 5, 1, 9, 2, 10): ");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                    {
                        break;
                    }
                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();
            foreach (var number in elements)
            {
                numbers.Add(Convert.ToInt32(number));
            }

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Let's assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                    {
                        min = number;
                    }
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
            {
                Console.WriteLine(number);
            }
        }
    }
}
