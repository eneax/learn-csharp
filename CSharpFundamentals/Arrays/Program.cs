using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 7, 9, 2, 14, 6};

            // Instance methods --> can be accessed on the method itself
            // Overload method --> it's a method with different versions

            // Length --> returns the size of an array
            Console.WriteLine("Length: " + numbers.Length);



            //Static methods --> can be accessed directly in the Array class

            // IndexOf() --> find the position of an element in the array
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine(index);


            /*
            Clear() 
                - clear from index 0 to index 2 of the numbers array
                - clearing an int array means setting the values to 0
                - clearing a bool array means setting the values to false
                - clearing a string array means setting the values to null
            */
            Array.Clear(numbers, 0, 2);
            Console.WriteLine("Clear() effect");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            // Copy() --> it copies the first 3 items of the 'numbers' array into the 'anotherArr'
            var anotherArr = new int[3];
            Console.WriteLine("Copy() effect");
            Array.Copy(numbers, anotherArr, 3);

            foreach (var item in anotherArr)
            {
                Console.WriteLine(item);
            }


            // Sort() 
            Array.Sort(numbers);

            Console.WriteLine("Sort() effect");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


            // Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Reverse() effect");

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}