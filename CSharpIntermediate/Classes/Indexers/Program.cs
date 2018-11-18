using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Enea";    // 'name' is the key, 'Enea' is the value
            Console.WriteLine(cookie["name"]);
        }
    }
}
