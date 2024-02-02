using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Star_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reverse Star Triangle Program
            do { 
            Console.WriteLine("Enter The Number Of Rows");
            int no = int.Parse(Console.ReadLine());
                for (int i = no; i >= 1; i--)
                {
                    for (int j = no; j > i; j--)
                    {
                        Console.Write(" ");
                    }
                    for (int k = 1; k < i; k++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();

                    
                }
                Console.WriteLine("Do You  Want to continue this program : yes / no");
                string cont = Console.ReadLine().ToLower();
                if(cont == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            while (true) ;
        }
    }
}
