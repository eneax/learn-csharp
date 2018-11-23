using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Upcasting
            Text text = new Text();

            // convert text to shape
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); // 100 (both text and shape are reference to the same obj)


            /*
            Donwcasting

            Shape shape = new Text();
            Text text = (Text)shape;
            */
        }
    }
}