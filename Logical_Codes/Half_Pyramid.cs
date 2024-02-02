using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Pyramid_of_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Half pyramid of numbers pattern

            Console.WriteLine("Enter Number Of Rows");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("You Enter Number Of Rows Is : {0}", num);

            Console.WriteLine("------------------------------------");



            for (int i = 1; i <= num; i++)
            {


                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");

                }
                Console.WriteLine();
            }

        }
    }
}
