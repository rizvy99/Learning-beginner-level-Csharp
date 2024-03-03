using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //int ismale;
           // bool gender;
            Console.Write("Please enter a number 1 or 2 : ");
            int ismale = Console.ReadLine();

            if(ismale == 1)
            {
                bool gender = true;
            }
            else if(ismale == 2){
                bool gender = false;
            }

            if (gender)
            {
                Console.WriteLine("You are a boy");
            }
            else if (!gender)
            {
                Console.WriteLine("You are not a boy!");
            }

            Console.ReadLine();

        }
    }
}
