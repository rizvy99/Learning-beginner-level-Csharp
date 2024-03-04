using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double ans;
            Console.Write("Enter a number : ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operation : ");
            string op = Console.ReadLine();
            Console.Write("Enter another number : ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            if (op == "+")
            {
                ans = num1 + num2;
                Console.WriteLine("Your answer is : " + ans);
            }
            else if(op == "-")
            {
                ans = num1 - num2;
                Console.WriteLine("Your answer is : " + ans);
            }
            else if(op == "*")
            {
                ans = num1 * num2;
                Console.WriteLine("Your answer is : " + ans);
            }
            else if(op == "/")
            {
                ans = num1 / num2;
                Console.WriteLine("Your answer is : " + ans);
            }
            else
            {
                Console.WriteLine("********Invalid number!!***********");
            }

            Console.ReadLine();
        }
    }
}
