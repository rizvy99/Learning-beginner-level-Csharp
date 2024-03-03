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
            Console.WriteLine("Enter only 2 integer data type number!!\n");
            Console.Write("Please enter num1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter num2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The laarge number is : " + getMax(num1, num2));
            //Console.WriteLine(getMax(50, 46));
            //Console.WriteLine(Rizvy(54.214, 87.16, 62.987));
            Console.WriteLine("\n----------------------------------\n");
            Console.WriteLine("Please enter 3 double data type numbers!!\n");
            Console.Write("Please enter num3 : ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter num4 : ");
            double num4 = (Convert.ToDouble(Console.ReadLine()));
            Console.Write("Please enter num5 : ");
            double num5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The large number is : " + Rizvy(num3, num4, num5));
            Console.WriteLine("\n**********************THE END**********************");

            Console.ReadLine();
        }
        static int getMax(int num1,int num2)
        {
            int result;
            if (num1 > num2)
            {
                result= num1;
            }
            else
            {
                result = num2;
            }
            return result;

        }
        static double Rizvy(double num3,double num4,double num5)
        {
            double result1;
            if(num3>num4 && num3 > num5)
            {
                result1 = num3;
            }
            else if(num3<num4 && num5<num4)
            {
                result1 = num4;
            }
            else
            {
                result1 = num5;
            }
            return result1;

        }
    }
}
