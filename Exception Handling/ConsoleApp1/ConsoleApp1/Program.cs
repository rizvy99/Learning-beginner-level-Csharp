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
            try
            {
                Console.Write("Enter a number : ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number : ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Your answer is : " + num1 / num2);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            /*catch (DivideByZeroException b)
            {
                Console.WriteLine(b.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }*/

            Console.ReadLine();
        }
    }
}
