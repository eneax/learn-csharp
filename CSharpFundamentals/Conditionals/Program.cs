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



            /*
            Ex. 1
            Write a program and ask the user to enter a number. 
            The number should be between 1 to 10. 
            If the user enters a valid number, display "Valid" on the console. 
            Otherwise, display "Invalid". 
            (This logic is used a lot in applications where values entered into input boxes need to be validated.) 
            */
            Console.Write("Enter a number between 1 to 10: ");
            var input = Console.ReadLine();
            var number = Convert.ToInt32(input);
            // int number = int.Parse(Console.ReadLine());
        
            if (number > 0 && number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }



            /*
            Ex. 2
            Write a program which takes two numbers from the console and displays the maximum of the two.
            */
            Console.Write("Enter first number:  ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"The maximum of the two numbers is {Math.Max(num1, num2)}");
            // var max = (number1 > number2) ? number1 : number2;
            // Console.WriteLine("Max is " + max);



            /*
            Ex. 3
            Write a program and ask the user to enter the width and height of an image. 
            Then tell if the image is landscape or portrait.
            */
            Console.Write("Enter the width of an image (in cm): ");
            var width = int.Parse(Console.ReadLine());

            Console.Write("Enter the height of an image (in cm): ");
            var height = int.Parse(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The image is a landscape");
            }
            else
            {
                Console.WriteLine("The image is a portrait");
            }



            /*
            Ex. 4
            Your job is to write a program for a speed camera. 
            For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.

            Write a program that asks the user to enter the speed limit. 
            Once set, the program asks for the speed of a car.

            If the user enters a value less than the speed limit, program should display Ok on the console. 
            If the value is above the speed limit, the program should calculate the number of demerit points. 
            For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
            If the number of demerit points is above 12, the program should display License Suspended.
            */
            Console.Write("Enter speed limit (in km/h): ");
            var speedLimit = int.Parse(Console.ReadLine());

            Console.Write("Enter car speed (in km/h): ");
            var speedOfCar = int.Parse(Console.ReadLine());

            if (speedOfCar < speedLimit)
            {
                Console.WriteLine("OOOkkkk");
            }
            else
            {
                const int kmPerDemeritPoint = 5;

                var demeritPoints = (speedOfCar - speedLimit) / kmPerDemeritPoint;

                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else
                {
                    Console.WriteLine("Demerit points: " + demeritPoints);
                }
            }
        }
    }
}
