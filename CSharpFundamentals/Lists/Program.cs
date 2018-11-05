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
            exercises.Number1();
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
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} liked your post!");
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
    }
}
