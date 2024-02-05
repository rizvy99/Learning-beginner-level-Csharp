using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Rizvy";
            int age = 24;
            String date = "23 March 2001";
            Console.WriteLine("Hey,");
            Console.WriteLine("This is " + name);
            Console.WriteLine("I am " + age  +" years old  ");
            Console.WriteLine("I study in AIUB at CSE department");
            Console.WriteLine(date +" - this is my date of birth");

            name = "Google";
            Console.WriteLine("I will be a software engineer in " + name);

            Console.ReadLine();
        }
    }
}
