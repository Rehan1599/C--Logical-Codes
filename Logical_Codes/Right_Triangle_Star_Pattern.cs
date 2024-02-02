using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Right_triangle_star_pattern
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Right Triangle Star pattern

            Console.WriteLine("Enter Number Of Rows");

            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("You're Enter Numbers of Rows Is {0}\n\n", num);
            Console.WriteLine("Right Triangle Star pattern\n");

            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


        }
    }
}
