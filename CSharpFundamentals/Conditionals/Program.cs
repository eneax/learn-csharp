using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // if/else statement
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }


            // conditional operator
            bool isPrimeCustomer = true;

            //float price;
            //if (isPrimeCustomer)
            //{
            //    price = 19.95f;
            //}
            //else
            //{
            //    price = 29.99f;
            //}

            // OR
            float price = isPrimeCustomer ? 19.95f : 29.99f;
            Console.WriteLine($"Price: { price }$");



            // Switch statement
            var season = Season.Autumn;

            switch (season)
            {
                // if season is Spring or Summer, write 'Promo time' 
                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("Promo time");
                    break;
                case Season.Autumn:
                    Console.WriteLine("It's Autumn");
                    break;
                case Season.Winter:
                    Console.WriteLine("It's Winter");
                    break;
                default:
                    break;
            }

        }
    }
}
