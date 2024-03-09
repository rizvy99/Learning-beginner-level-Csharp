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
            //2D Jagged Array
            int[][, ] jaggedarray = new int[3][,]
            {
                new int[ , ] { { 1, 3 }, { 5, 7 } },
                new int[ , ] { { 0, 2 }, { 4, 0 }, { 8, 1 } },
                new int[ , ] { { 11, 2}, {99, 88 }, { 0, 9 } }
            };
            //Print a specific index
            Console.WriteLine(jaggedarray[1][2, 0]);

            //Change the specific index
            jaggedarray[1][2, 0] = 100;
            Console.WriteLine(jaggedarray[1][2, 0]);

            //Print full array with index
            for(int i = 0; i < jaggedarray.Length; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < jaggedarray[i].GetLength(0); j++){
                   // Console.WriteLine();
                    for (int x = 0; x < jaggedarray[j].GetLength(1); x++) {
                        Console.WriteLine("Element [" + i + "][" + j + "][" + x + "]: " + jaggedarray[i][j, x]);
                    }
                }
                
            }
            Console.WriteLine("\n****************THE END****************");
            Console.ReadLine();
        }
    }
}
