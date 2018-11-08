using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.ID = 1;
            customer.Name = "Enea";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.ID);
            Console.WriteLine(customer.Name);
        }
    }
}
