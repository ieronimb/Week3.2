using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tema2Exercitiul3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercitiul 3: Add two numbers in a file");
            Console.WriteLine("You have data in a file in two rows. On the third row save the sum of the numbers above.");
            Console.WriteLine("Example:\nFile content:\n10\n20\nSum: 30");

            int i = 10;
            int y = 20;
            int z = i + y;
            TextWriter tw = new StreamWriter("date.txt");
            tw.WriteLine(i);
            tw.WriteLine(y);
            tw.WriteLine("Sum: {0}", z);
        }
    }
}
