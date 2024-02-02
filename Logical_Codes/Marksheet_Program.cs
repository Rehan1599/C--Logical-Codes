using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marksheet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your First Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter Your Class Name.");
            string stnd = Console.ReadLine();
            Console.WriteLine("Enter Your Roll No.");
            string roll = Console.ReadLine();
            Console.WriteLine("Enter Your Hindi Marks");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your English Marks");
            int e = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Maths Marks");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your Bio Marks");
            int b = int.Parse(Console.ReadLine());

            int total = h + e + m + b;
            int per = total * 100 / 400;

            Console.WriteLine("----Marksheet Details----");
            Console.WriteLine("Your Full name is : {0} {1}", name,lname);
            Console.WriteLine("Your Class is : {0}", stnd);
            Console.WriteLine("Your Roll  Number is : {0}", roll);
            Console.WriteLine("Your Toatal Number is : {0}", total);
            Console.WriteLine("Your Percentage is : {0}", per);
            Console.WriteLine("Hindi : {0} -- English : {1} -- Maths : {2} -- Bio : {3}" , h , e , m , b);
            if(per >= 80)
            {
                Console.WriteLine("Grade - A++");
            }
            else if(per >= 75)
            {
                Console.WriteLine("Grade - A ");
            }
            else if (per >= 60)
            {
                Console.WriteLine("Grade - B ");
            }
            else if (per >= 45)
            {
                Console.WriteLine("Grade - C ");
            }
            else if (per >= 33)
            {
                Console.WriteLine("Grade - D ");
            }
            else
            {
                Console.WriteLine("You're Fail \n   \n            Krapya agle saal Dobara pesa Bhare or fir se Prayaas kare....    \n\n                                                               Dhanyawad");
            }

            int supply = 0;

            if(h < 33)
            {
                supply++;
            }
            if(e < 33)
            {
                supply++;
            }
            if(m < 33)
            {
                supply++;
            }
            if(b < 33)
            {
                supply++;
            }

            Console.WriteLine("You're Failed in : {0} Subjects", supply);
            Console.ReadLine();
        }
    }
}
