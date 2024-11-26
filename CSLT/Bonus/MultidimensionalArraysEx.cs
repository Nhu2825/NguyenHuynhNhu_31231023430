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
            Console.Write("Nhap chuoi: "); string s = Console.ReadLine();
            Console.Write("Nhap sub: "); string sub = Console.ReadLine();
            //checkSub(s, sub);
            Console.WriteLine($"'{sub}' lap lai {countSub(s,sub)} lan trong chuoi.");
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
        static int countSub(string s, string sub)
        {            
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == sub[0])
                {
                    int ok = 0;
                    for (int j = 1; j < sub.Length; j++)
                    {
                        if (s[i+j] == sub[j])
                        {
                            ok++;
                        }    
                    }
                    if (ok==sub.Length-1) count++;
                }
            }
            return count;
        }
        static void checkSub(string s, string sub)
        {
            //if (s.Contains(sub)) Console.WriteLine($"Chuoi co chua {sub}.");
            //else
            //{
            //    Console.WriteLine($"Chuoi khong chua {sub}.");
            //}
            bool check = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[0] != sub[0])
                { break; }
                else if (s[0] == sub[0])
                {
                    for (int j = 1; j < sub.Length; j++)
                    {
                        if (s[j] != sub[j]) break;
                    }
                    check = true;
                }
            }
            if (check) Console.WriteLine($"Ton tai '{sub}' trong chuoi.");
            else Console.WriteLine($"Trong chuoi khong co '{sub}'.");
        }
    }
}
