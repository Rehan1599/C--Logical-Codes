using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace swap_2_int_without_using_third_variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("Enter First Number ...");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number ...");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine("You Enter first number A = {0}", a);
                Console.WriteLine("You Enter Second number B = {0}", b);


                Console.WriteLine("Before Swap A ={0} , B ={1}\n\n", a, b);



                Console.WriteLine("-------------------------------------\n\n");





                Console.WriteLine("You Want to swap numbers Enter :  y  / n\n\n");
                string value = Console.ReadLine().ToLower();
                Console.WriteLine();
                if (value == "y")
                {

                    Console.WriteLine("a =  a + b ---> a = {0} + {1} = {2} ", a, b, a = a + b);

                    Console.WriteLine("b =  a - b ---> b = {0} - {1} = {2} ", a, b, b = a - b);

                    Console.WriteLine("a =  a - b ---> a = {0} - {1} = {2} \n\n", a, b, a = a - b);




                    //a = a + b; //10 + 33 = 43;
                    //b = a - b; //43 - 33 = 10;
                    //a = a - b; //43 - 10 = 33;
                    Console.WriteLine("After Swap A = {0} ,  B = {1}", a, b);
                }
                else
                {
                    Console.WriteLine("You're Exit");
                }




                
         
        }
    }
}
    