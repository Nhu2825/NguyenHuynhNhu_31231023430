using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session7
{
    internal class Note
    {
        public static void Main()
        {
            /*int[,] a; 
            Console.Write("Nhap so dong: _"); int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: _"); int columns = int.Parse(Console.ReadLine());
            //tạo mảng 2 chiều
            a=new int[rows, columns];
            nhapmangtudong(a, rows, columns);

            xuatmang(a);*/
            thu();

            Console.ReadKey();
        }
        public static void nhapmangbangcom(int[,] a, int rows, int columns)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i}, {j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
        }
        static void xuatmang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void timvitriphantu(int[,] a, int val)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == val)
                    {
                        Console.WriteLine($"Gia tri xuat hien tai dong {i}, cot {j}\n");
                    }
                }
            }
        }
        public static void nhapmangtudong(int[,] a, int rows, int columns)
        {
            Random rand = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i}, {j}] = ");
                    a[i, j] = rand.Next(0, 100);
                }
                Console.WriteLine();
            }
        }
        public static (int, int) swap(ref int a, ref int b)
        {
            int z = a;
            a = b;
            b = z;
            return (a, b);
        }
        public static void thu()
        {
            int x = 6;
            int y = 9;
            swap(ref x, ref y);
        }
    }
}
