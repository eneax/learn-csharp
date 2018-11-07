using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new StringBuilder();

            // Append (you can append and repeat)
            builder.Append('-', 10)
                   .AppendLine()
                   .Append("Header")
                   .AppendLine()
                   .Append('-', 10);


            // Replace
            builder.Replace('-', '+');


            // Remove (starts from an index and remove some characters)
            builder.Remove(0, 10);


            // Insert (add a line of '-' at the beginning of the StringBuilder)
            builder.Insert(0, new string('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine($"First char: {builder[0]}");
        }
    }
}
