using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            string str;

            do
            {

                Console.Write("Enter a number = ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter another number = ");
                double num2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Please select a symble(+-*/%) : ");
                string symble = Console.ReadLine();

                switch (symble)
                {
                    case "+":
                        {
                            num = num1 + num2;
                            Console.WriteLine("Addition : " + num);
                            break;
                        }

                    case "-":
                        {
                            num = num1 - num2;
                            Console.WriteLine("Substraction : " + num);
                            break;
                        }

                    case "*":
                        {
                            num = num1 * num2;
                            Console.WriteLine("Multiplication : " + num);
                            break;
                        }

                    case "/":
                        {
                            num = num1 / num2;
                            Console.WriteLine("Divition  :" + num);
                            break;
                        }
                    case "%":
                        {
                            num = num1 % num2;
                            Console.WriteLine("Modulus  :" + num);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong answer!");
                            break;
                        }

                }
                Console.WriteLine("Do you want to continue?\nIf you want continue,Please enter (YES)\nelse (NO)");
                Console.Write("Your opinion : ");
                str = Convert.ToString(Console.ReadLine());
                Console.WriteLine("\n");

            }
            while (str == "YES" || str == "Yes" || str == "yes");
           
            Console.ReadLine();
        }
    }
}
