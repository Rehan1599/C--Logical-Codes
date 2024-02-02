using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Using_Method
{
    internal class Program
    {

        //addition 

        public static void add(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("Your addition number is:" + result);
        }

        //subtraction
        public static void sub(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine("Your Subtraction number is:" + result);
        }


        //multiply

        public static void mult(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine("Your Multiplication number is:" + result);
        }

        //Devide 

        public static void dev(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine("Your Devided number is:" + result);
        }
        //reminder
        public static void rem(int num1, int num2)
        {
            int result = num1 % num2;
            Console.WriteLine("Your Reminder number is:" + result);
        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter First Number");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Seconad Number");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Select Oprator ... what you want to calculate : + , - , * , / , % ");
                string op = Console.ReadLine();
                if (op.Equals("+"))
                {
                    Program.add(num1, num2);
                }
                else if (op.Equals("-"))
                {
                    Program.sub(num1, num2);
                }
                else if (op.Equals("*"))
                {
                    Program.mult(num1, num2);
                }
                else if (op.Equals("/"))
                {
                    Program.dev(num1, num2);
                }
                else if (op.Equals("%"))
                {
                    Program.rem(num1, num2);
                }
                else
                {
                    Console.WriteLine("invalid oprator");
                }


                Console.WriteLine("You want to calculate other numbers : yes / no");
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
            Console.WriteLine("Thank you...");


        }
    }
}
