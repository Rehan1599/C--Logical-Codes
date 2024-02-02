using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Right_Mirrored_star_pattern
{
    class star
    {
        public static void pattern()
        {
            //Mirrored  Right Angle Triangle Star Pattern

            Console.WriteLine("Enter Number Of Rows ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("You Enter Number Of Rows is : {0}", num);


            Console.WriteLine("Your Mirrored Right angle triangle pattern is ");

            for (int i = 1; i <= num; i++)
            {
                for (int j = num; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int l = 1; l <= i; l++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                star.pattern();
                Console.WriteLine("Do you want to print another  Star pattern Enter : yes / no");
                string val = Console.ReadLine().ToLower();
                if(val == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            


        }
    }
}
