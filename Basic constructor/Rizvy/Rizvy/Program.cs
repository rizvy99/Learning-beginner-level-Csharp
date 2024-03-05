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
            Book book1 = new Book("Auronnok", "Bivhutivuson", 150);
            Book book2 = new Book("The Alchemist", "Paulo", 750);
            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.page);

            Console.WriteLine("\n");
            Console.WriteLine(book2.title);
            Console.WriteLine(book2.author);
            Console.WriteLine(book2.page);
            Console.WriteLine("\n**********THE END**********");


            Console.ReadKey();
        }
    }
}
