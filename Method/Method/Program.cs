using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Hi();
            SayHi("Rizvy", "23th March");
            their("Rahim", 24);
            their("Karim", 23);
            their("Mahim", 25);

            Console.ReadLine();
        }
        static void Say()
        {
            Console.WriteLine("Hello my friend!");
        }
        static void Hi()
        {
            Console.WriteLine("Hello User!");
        }
        static void SayHi(string name,string date)
        {
            Console.WriteLine("Hey, " + name + " .Congratulations!!\n" + date + " is your Birthday\n___---HAPPY BIRTHDAY---___ dear");
            Console.WriteLine("\n");
        }
        static void their(string name,int age)
        {
            Console.WriteLine("Hello " + name + ". You are " + age +" years old!" );
        }
    }
}
