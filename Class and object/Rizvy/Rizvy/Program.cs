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
            Book book1 = new Book();
            book1.titel = "Aronnok";
            book1.author = "Bivutivuson";
            book1.page = 140;
            
            Book book2 = new Book();
            book2.titel = "The Alchemist";
            book2.author = "Paulo Coelho";
            book2.page = 750;

            Console.WriteLine("Book name : " + book1.titel);
            Console.WriteLine("Writer name : " + book1.author);
            Console.WriteLine("Book page : " + book1.page);
            Console.WriteLine();

            Console.WriteLine("Book name : " + book2.titel);
            Console.WriteLine("Writer name : " + book2.author);
            Console.WriteLine("Book page : " + book2.page);
            Console.WriteLine("\n***************THE END***************");
            Console.ReadKey();
        }
    }
}
