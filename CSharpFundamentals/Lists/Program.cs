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
        }
    }
}
