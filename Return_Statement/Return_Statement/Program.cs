using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(cube(50));
            double number = cube(8.987);
            Console.WriteLine(number);

            Console.ReadLine();
        }
        static double cube(double num)
        {
            double result = num* num *num;
            return result;
        }
    }
}
