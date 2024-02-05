using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_a_Mad_Libs_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, noun, name;
            Console.Write("Write your fevorite color : ");
            color = Convert.ToString(Console.ReadLine());
            Console.Write("Enter a noun which are colorful : ");
            noun = Convert.ToString(Console.ReadLine());
            Console.Write("Write a celebraty person name : ");
            name = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Rose is " + color + "\n" + noun + " is blue" + "\nYou like " + name);

            Console.ReadLine();
        }
    }
}
