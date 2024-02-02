using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hollow_Rectangle_pattern
{
    class rectanle
    {
        public rectanle() // Create program using default constructor
        {
            //Hollow Rectangle pattern 



            for (int k = 1; k <= 9; k++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)

            {

                for (int j = 1; j <= 2; j++)
                {
                    Console.WriteLine(" *   Hollow Rectangle    *");
                }
            }
            for (int k = 1; k <= 9; k++)
            {
                Console.Write(" * ");
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            rectanle obj = new rectanle();
            Console.ReadLine();
           
        }
    }
}
