using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check__Pelindrome_number_or_not
{
    internal class Pelindrome_Number
    {
        static void Main(string[] args)
        {
            while (true)
            {

                // Check pelindrome Number or not
                Console.WriteLine("Enter Number To Check Pelindrome Number or not.....");
                long number = long.Parse(Console.ReadLine());

                Console.WriteLine("Your Entered Number is : {0}\n",  number);
           
                long remainder;
                long result = 0;
                long temp = number;
                int a = 1;
                while (number != 0)
                {
                    Console.WriteLine("---------------------" + "Number of loops {0}", a++ + "----------------------------\n");
                    Console.WriteLine("Remainder = Number % 10 ;          ---> remainder = {0} % {1} = {2};\n" , number , 10 , remainder = number % 10);

                    Console.WriteLine("Result = result * 10 + remainder ; ---> result = {0} * {1} + {2} = {3}\n", result , 10 , remainder ,result = result * 10 + remainder);

                    Console.WriteLine("Number =  number / 10 ;            --->  number = {0} / {1} = {2}\n", number , 10 , number = number / 10);
                   
                    // remainder = number % 10; // (121 % 10 = 1) , (12 % 10 =2) , (1 % 10 = 1)
                    // result = result * 10 + remainder; //(0 * 10 + 1 = 1) , (1 * 10 + 2 = 12) , (12 * 10 + 1 = 121)
                    // number = number / 10; // (121 / 10 = 12) , (12 / 10 = 1) , ( 1 / 10 = 0)

                }

                number = temp;
                Console.WriteLine("--------------------Your Result Is------------------------\n");
                Console.WriteLine("A palindromic number is a number (such as 16461) that remains the same when its digits are reversed.\n");

                Console.WriteLine("Entered Number Is  : {0}\n", number);
                Console.WriteLine("Reversed Number Is : {0}\n" , result);
               


                if (number == result)
                {
                    
                    Console.WriteLine("This is a Pelindrome Number", result);
                }
                else
                {
                   
                    Console.WriteLine("This is not a Pelindrome Number ", result);
                }
                Console.WriteLine();
                Console.WriteLine("---------------------Do you want to check another number Enter : yes --------------------- \n\n------------------You want to exit this program enter any other key....----------------");
                string cont = Console.ReadLine().ToLower();
                if (cont == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
