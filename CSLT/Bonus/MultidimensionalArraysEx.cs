using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CSLT.Bonus
{
    internal class MultidimensionalArraysEx
    {
        public static void Main()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.
        /// </summary>
        static void ex18()
        {
            int[,] matrix = new int[3, 3];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine($"element - [{i},{j}]: "); Console.ReadLine();
                }
            }
        }
    }
}
