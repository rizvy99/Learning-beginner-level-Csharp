using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_user_input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            String name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Hello " + name +"\nPlease enter your correct age and Date of Birth " +
                "also your present address and your Education and Qualification that means your corrent Educational Institution ");
            Console.Write("\nDate of Birth and year : ");
            string dob = Console.ReadLine();
            string year = Console.ReadLine();
            Console.WriteLine("Congratulations!!. Your birthday is : " + dob);
            Console.Write("Age : ");
            string age = Console.ReadLine();
            Console.Write("Address : ");
            string address = Console.ReadLine();
            Console.Write("Educational Institution : ");
            string institution = Console.ReadLine();
            Console.WriteLine("Hello " + name + "\nYou are " + age + " years old and present you live in " 
                + address +". Your running educational Institution is " + institution);
            Console.WriteLine("\n\n__________________________**********END**********_______________________________");

            Console.ReadLine();
        }
    }
}
