using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsandInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("XYZ123");
            // Vehicle is being initialized before Car
        }
    }
}
