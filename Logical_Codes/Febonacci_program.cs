using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace febonacci_series
{

    class Febonacci_program
    {
        public void method() // create program using method
        {
            //Febonacci program

            int x = 0;
            int y = 1;
            int z;

            Console.WriteLine("x = {0};", x);
            Console.WriteLine("y = {0};", y);

            Console.WriteLine("------------------------------------------");

            for (int l = 0; l < 10; l++)
            {
                z = x + y;
                Console.WriteLine(z);
                x = y;
                y = z;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Febonacci_program print = new Febonacci_program(); // create class object 
            //print.method();
            //Console.ReadLine();

    //Febonacci program 

            int a = 0;
            int b = 1;
            int c;
            int j = 1;
            Console.WriteLine("A = {0};", a);
            Console.WriteLine("B = {0};", b);
            Console.WriteLine("-------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("c = a   +   b;");
                c = a + b;
                Console.WriteLine("A : {0} + B : {1} :\n                    C = {2};", a, b, c);
                a = b;
                b = c;

                Console.WriteLine("        ----number of loops : {0}----", j++);
                Console.WriteLine("          A = B : {0}; \n          B = C : {1};", a, b);
              
            }



        }
    }
}
