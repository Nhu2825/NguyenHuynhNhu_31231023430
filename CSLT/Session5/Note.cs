using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session5
{
    internal class Note
    {
        /// <summary>
        /// Hàm tính tổng 2 số
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float sum(float a, int b)
        {
            return a + b;
        }
        public static void tinhtong()
        {
            Console.WriteLine("Get go!");
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            float x = 6;
            int y = 5;
            float tong = sum(x, y);
            Console.WriteLine(tong);
        }
        public static void swap(ref int x, ref int y)
        {
            int z = 0;
            z = x;
            x = y;
            y = z;
        }
        public static void VD()
        {
            //Console.Write("Nhap a: "); int a=int.Parse(Console.ReadLine());
            //Console.Write("Nhap b: "); int b=int.Parse(Console.ReadLine());
            int a = 9;
            int b = 10;
            Console.WriteLine($"Truoc: a = {a}, b={b}");
            swap(ref a, ref b);
            Console.WriteLine($"sau: a = {a}, b={b}");
        }
        /// <summary>
        /// Hàm tìm max 3 số
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
    }
}
