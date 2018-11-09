using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{
    public class Customer
    {
        public int ID;
        public string Name;

        // Create and initialize List<Order> field 
        // readonly --> so it will be initialized only once
        readonly public List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.ID = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // ...
        }
    }
}

/*
A field is like a variable that we declare at a class level 
and use that to store data about a class.
*/
