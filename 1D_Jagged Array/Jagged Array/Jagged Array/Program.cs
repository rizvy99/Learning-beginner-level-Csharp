using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1D Array
            Console.WriteLine("****************1D Array****************");
            int[][] jaggedarray = new int[3][];
            jaggedarray[0] = new int[3] { 10, 20, 30 };
            jaggedarray[1] = new int[5] { 10, 20, 40, 30, 50 };
            jaggedarray[2] = new int[2] { 10, 20 };

            //Print a specific index.
            Console.WriteLine(jaggedarray[0][2]);


            //This loop prints all the arrays that have been declared
            for (int i = 0; i < jaggedarray.Length; i++)
            {
                Console.WriteLine();
                for(int j = 0; j < jaggedarray[i].Length; j++)
                {
                    Console.WriteLine(jaggedarray[i][j] + "\t");
                }
            }


            //this process also print the all array but ccode is different from previous loop and declaration
            Console.WriteLine("-----------------------------------------");
            int[][] jaggedarray1 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 1, 2, 2 } };
            foreach (int[] number in jaggedarray1)
            {
                Console.WriteLine();
                foreach(int i in number) {
                    Console.Write(i + "\t");
                }
            }
            
            

            Console.ReadLine();
        }
    }
}
