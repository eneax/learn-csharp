using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class Customer
    {
        public int ID;
        public string Name;
        public List<Order> Orders;

        // Default or Parameterless constructor
        public Customer()
        {
            /*
            Whenever you have a class that has a list of objects (of any type),
            always initialize that list to an empty list.
            */
            Orders = new List<Order>();
        }


        /*
        When 'Customer(int id)' is called, 
        it will run first the constructor without parameters
        */
        public Customer(int id)
            : this()
        {
            this.ID = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }
    }
}
