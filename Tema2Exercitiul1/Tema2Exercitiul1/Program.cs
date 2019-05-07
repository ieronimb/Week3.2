using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema2Exercitiul1
{
    class Program
    {
        static void Main(string[] args)
        {
            int year;

            Console.Write("Program to Check Whether the Entered Year is a Leap Year or Not");
            Console.Write("\n>Write an year : ");
            year = Convert.ToInt32(Console.ReadLine());

            //https://en.wikipedia.org/wiki/Leap_year

            if ((year % 4) != 0)
            {
                Console.WriteLine("{0} is a common year.\n", year);
            }

            else if ((year % 100) != 0)
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }

            else if ((year % 400) != 0)
            {
                Console.WriteLine("{0} is a common year.\n", year);
            }

            else
            {
                Console.WriteLine("{0} is a leap year.\n", year);
            }

            Console.ReadKey();
        }
    }
}
