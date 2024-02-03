using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work_with_String
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print a string
            Console.WriteLine("Hello World");

            //Print a string with line break;
            Console.WriteLine("Hello\nWorld");
            //Print string by different way
            Console.WriteLine("Hello\"World");

            //Print string using data type
            string str = "Hello World";
            Console.WriteLine(str);

            string str1 = "Hello" + " World";
            Console.WriteLine(str1);

            //Print string length
            Console.WriteLine(str1.Length);

            //for all are upper case
            Console.WriteLine(str1.ToUpper());

            //for all lower case
            Console.WriteLine(str1.ToLower());

            //verify true or false
            Console.WriteLine(str1.Contains("Hello"));
            Console.WriteLine(str1.Contains("HELLO"));

            //Print substring
            Console.WriteLine(str1.Substring(6));
            Console.WriteLine(str1.Substring(6,4));

            //Print single character
            Console.WriteLine(str1[9]);

            //Print index where it  from start
            Console.WriteLine(str1.IndexOf("World"));

            //Print the index number
            Console.WriteLine(str1.IndexOf('r'));
            Console.WriteLine(str1.IndexOf('t'));

            //.....................................
            Console.WriteLine(str1.Substring(str1.IndexOf("Hello")));


            Console.ReadLine();
        }
    }
}
