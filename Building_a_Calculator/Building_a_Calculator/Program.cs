using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double num = num1 + num2;
            Console.WriteLine("Addition : "+ num);
            num = num1 - num2;
            Console.WriteLine("Substraction : " + num);
            num = num1 * num2;
            Console.WriteLine("Multiplication : " + num);
            num = num1 / num2;
            Console.WriteLine("Divition : " + num);

            Console.ReadLine();
        }
    }
}
