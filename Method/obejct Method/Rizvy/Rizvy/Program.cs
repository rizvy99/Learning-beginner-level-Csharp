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
            Student st = new Student("Onu", "Arts", 3.49);
            Student st2 = new Student("Opu", "Science", 3.75);

            Console.WriteLine(st.result());
            Console.WriteLine(st2.result());


            Console.ReadKey();
        }
    }
}
