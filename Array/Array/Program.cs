using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 9, 12, 34, 94, 64 };
            Console.WriteLine(numbers[2]);

            string[] boys = new string[5];
            boys[1] = "Rahim";
            boys[4] = "Mahim";
            Console.WriteLine(boys[1]);

            string[] friends = {"Anik","Niak","Elin","Tusher","Jim" };
            Console.WriteLine(friends[3]);

            Console.ReadLine();
        }
    }
}
