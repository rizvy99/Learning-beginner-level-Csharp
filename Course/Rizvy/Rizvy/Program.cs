using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c1 = new Course();
            c1.setName("Object Oriented Programming - 2");
            c1.setCode("01585");
            c1.setCredit(3);
            c1.ShowInfo();

            Course c2 = new Course("Theory of Computation", "01490", 3);
            c2.ShowInfo();

            Course c3 = new Course("Digital Logic Circuit lab ", "01483", 1);
            c3.ShowInfo();

            Course c4 = new Course("Digital Logic Circuits", "01056", 3);
            c4.ShowInfo();

            Course c5 = new Course("Principlas of Economics", "00376", 2);
            c5.ShowInfo();

            Console.ReadLine();
        }
    }
}


