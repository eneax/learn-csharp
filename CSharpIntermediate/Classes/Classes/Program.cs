using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hello {to}, I'm {Name}!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "John";
            person.Introduce("Enea");
        }
    }
}
