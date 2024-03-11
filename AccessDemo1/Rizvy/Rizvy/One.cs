using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rizvy
{
    class One
    { 
            public static void Test1()
            {
                Console.WriteLine("Public Method!");
            }
            private static void Test2()
            {
                Console.WriteLine("private Method!");
            }
            protected static void Test3()
            {
                Console.WriteLine("protected Method!");
            }
            internal static void Test4()
            {
                Console.WriteLine("internal Method!");
            }
            protected internal static void Test5()
            {
                Console.WriteLine("protected internal Method!");
            }
            private protected static void Test6()
            {
                Console.WriteLine("private protected Method!");
            }
        static void Main(string[] args)
        {
            One.Test1(); Test2(); Test3(); Test4(); Test5();
            One.Test6();

            Console.ReadKey();
        }
    }
    }

