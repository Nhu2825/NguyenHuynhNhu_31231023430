using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session2
{
    internal class DataType
    {
        public static void Main()
        {
            
            Console.ReadKey();
        }
        /// <summary>
        /// Chuyển độ C sang độ K
        /// </summary>
        public static void Ex1()
        {
            Console.Write("Nhap do C: ");
            double c = double.Parse(Console.ReadLine());
            double k = c + 273;
            double f = c * 18 / 10 + 32;
            Console.WriteLine($"kenvin = {k}");
            Console.WriteLine($"fahrenheit = {f}");
        }
        /// <summary>
        /// Tính diện tích và thể tích hình cầu với bán kính được nhập từ bàn phím.
        /// </summary>
        public static void Example2()
        {
            Console.Write("Nhap ban kinh: ");
            float r = float.Parse(Console.ReadLine());
            double s = 4 * Math.PI * Math.Sqrt(r);
            double v = (4 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Surface: {s}");
            Console.WriteLine($"Volume: {v}");
        }
        /// <summary>
        /// Nhập 2 số, in ra các phép tính cộng, trừ, nhân, chia giữa 2 số.
        /// </summary>
        public static void Example3()
        {
            Console.Write("Nhap so thu nhat: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            double b = double.Parse(Console.ReadLine());
            double tong = a + b;
            double tich = a * b;
            double hieu = a - b;
            double thuong = a / b;
            double mod = a % b;
            Console.WriteLine($"{a} + {b} = {tong}");
            Console.WriteLine($"{a} - {b} = {hieu}");
            Console.WriteLine($"{a} * {b} = {tich}");
            Console.WriteLine($"{a} / {b} = {thuong}");
            Console.WriteLine($"{a} mod {b} = {mod}");
        }
    }
}
