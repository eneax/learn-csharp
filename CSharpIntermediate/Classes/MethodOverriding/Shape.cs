using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            // Any code specific to the circle itself
            Console.WriteLine("Draw a Circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            // Any code specific to the rectangle itself
            Console.WriteLine("Draw a Rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            // Any code specific to the triangle itself
            Console.WriteLine("Draw a Triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    }
}
