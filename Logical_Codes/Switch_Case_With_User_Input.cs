using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("Enter Yuor Item Name");
            string items = Console.ReadLine();

            switch (items)
            {
                case "Tandoori":
                    Console.WriteLine("Enter Your Tandoori Item Name");
                    string Tandoor = Console.ReadLine();
                    switch (Tandoor)
                    {
                        case "Tikka":
                            Console.WriteLine("You're Selected Chicken Tikka");
                            break;
                        case "Malai Tikka":
                            Console.WriteLine("You're Selected Chicken Malai Tikka");
                            break;
                        case "Barbique":
                            Console.WriteLine("You're Selected Chicken Barbique");
                            break;
                    }
                    break;
                case "Paneer":
                    Console.WriteLine("Enter Your Tandoori Item Name");
                    string Paneer = Console.ReadLine();
                    switch (Paneer)
                    {
                        case "Tikka":
                            Console.WriteLine("You're Selected Paneer Tikka");
                            break;
                        case "Malai Tikka":
                            Console.WriteLine("You're Selected Paneer Malai Tikka");
                            break;
                        case "Special":
                            Console.WriteLine("You're Selected Paneer special Tikka");
                            break;


                    }
                    break;
            }


            Console.WriteLine("Additional calculator");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();


            //Other Program 

            //switch case programes
            /*
            int week_day = int.Parse(Console.ReadLine());

            switch(week_day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednessday");
                    break;
                case 4 :
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday -- Half day --");
                    break;
                case 7:
                    Console.WriteLine("Sunday -- Holiday --");
                    break;
                default:
                    Console.WriteLine("Invalid week number");
                    break;
                    */
        }
    }
}
