using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quantiend_and_remainder_program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter Dividend Number");
                int divdend = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Divisor Number");
                int divisor = int.Parse(Console.ReadLine());
                int quontient = divdend / divisor;
                int remainder = divdend % divisor;

                Console.WriteLine("Dividend = {0} , Divisor = {1}", divdend, divisor);

                Console.WriteLine("Quontient = {0}", quontient);
                Console.WriteLine("Remainder = {0}", remainder);

                Console.WriteLine("You want to continue this program Enter ( Yes )\n\nAnd You want to Exit this program press any other key....");
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

        }
    }
}
