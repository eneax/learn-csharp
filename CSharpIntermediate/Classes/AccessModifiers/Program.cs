﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    // class that derives from the Customer class
    public class GoldenCustomer : Customer
    {
        public void OfferVoucher()
        {
            var rating = this.CalculateRating(excludeOrders: true);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            customer.Promote();
        }
    }
}







/*
 
namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(1992, 1, 1));
            Console.WriteLine(person.GetBirthdate());
        }
    }
}

*/
