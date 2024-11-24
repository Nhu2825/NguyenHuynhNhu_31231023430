using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session5
{
    internal class Function
    {
        public static void Main(string[] args)
        {
            //VD();
            Ex05();
            Console.ReadLine();
        }
        public static float max(ref float a, ref float b, ref float c)
        {
            float m = Math.Max(Math.Max(a, b), c);
            return m;
        }
        /// <summary>
        /// In ra số lớn nhất trong 3 số được nhập.
        /// </summary>
        public static void Ex01()
        {
            Console.Write("Nhap so thu nhat: __"); float x = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: __"); float y = float.Parse(Console.ReadLine());
            Console.Write("Nhap so thu ba: __ "); float z = float.Parse(Console.ReadLine());
            float kq = max(ref x, ref y, ref z);
            Console.WriteLine($"So lon nhat trong ba la {kq}");
        }
        /// <summary>
        /// Hàm tính giai thừa
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int giaithua(int a)
        {
            int GT = 1;
            for (int i = 1; i <= a; i++)
                GT = GT * i;
            return GT;
        }
        /// <summary>
        /// In giai thừa 1 số được nhập
        /// </summary>
        public static void Ex02()
        {
            Console.Write("Nhap so nguyen duong: __");
            int x = int.Parse(Console.ReadLine());
            bool nhap = true;
            do
            {
                if (x >= 0)
                    break;
                else
                    nhap = false;
                Console.WriteLine("Ban can nhap mot so nguyen duong!");
            }
            while (true);
            int kq = giaithua(x);
            Console.WriteLine($"{x}! = {kq}");
        }
        /// <summary>
        /// Hàm kiểm tra số nguyên tố
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        static int checkPrime(int a)
        {
            int count = 0;
            for (int i = 2; i < a - 1; i++)
            {
                if ((a % i) == 0)
                {
                    count++;
                }
            }

            return count;
        }
        /// <summary>
        /// Kiểm tra số nguyên tố
        /// </summary>
        public static void Ex03()
        {
            Console.Write("Nhap so nguyen bat ky: __"); int n = int.Parse(Console.ReadLine());
            int kq = checkPrime(n);
            if (n == 0)
            {
                Console.WriteLine("day la so nguyen to!");
            }
            else
            {
                Console.WriteLine("Day khong phai so nguyen to!");
            }
        }
        /// <summary>
        /// 1. in ra số nguyên tố nhỏ hơn x. <br/>
        /// 2. in ra n số nguyên số đầu tiên.
        /// </summary>
        public static void Ex04()
        {
            Console.Write("Nhap mot so nguyen duong: __"); int x = int.Parse(Console.ReadLine());
            Console.Write($"Cac so nguyen to nho hon {x} la: ");
            for (int i = 2; i < x; i++)
            {
                if (checkPrime(i) == 0)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
            //in ra n số nguyên tố đầu tiên
            Console.Write("Ban muon in ra bao nhieu so nguyen to dau tien? __"); int n = int.Parse(Console.ReadLine());
            Console.Write($"{n} so nguyen to dau tien la:  ");
            int count = 0;

            for (int i = 2; count < n; i++)
            {
                if (checkPrime(i) == 0)
                {
                    Console.Write($"{i} ");
                    count++;
                }
            }
        }
        /// <summary>
        /// hàm kiểm tra số hoàn hảo
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static bool checkPerfectNum(ref int x)
        {
            bool ktra = false;
            int sum = 0;
            for (int j = 1; j < x; j++)
            {
                if (x % j == 0)
                {
                    sum += j;
                }
            }
            if (sum == x)
            {
                ktra = true;
            }
            return ktra;
        }
        /// <summary>
        /// Kiểm tra một số có phải số hoàn hảo không.<br/>
        /// (Số hoàn hảo là số có giá trị bằng tổng các ước số của nó.)<br/>
        /// In ra các số hoàn hảo nhỏ hơn 1000.
        /// </summary>
        public static void Ex05()
        {
            Console.Write("Nhap so can kiem tra: __"); int a = int.Parse(Console.ReadLine());
            if (checkPerfectNum(ref a) == true)
            { Console.WriteLine($"{a} la so hoan hao"); }
            else
            { Console.WriteLine($"{a} khong phai so hoan hao"); }
            Console.Write("Cac so hoan hao tu 1 den 1000  ");
            for (int i = 1; i < 1000; i++)
            {
                if (checkPerfectNum(ref i) == true)
                {
                    Console.Write($"{i} ");
                }
            }
        }
        /// <summary>
        /// kiem tra 1 cau co phai la pangram khong </br>(tat ca chu trong bang chu cai xuat hien it nhat mot lan)
        /// </summary>
        public static void Ex06()
        {
            Console.WriteLine("Moi nhap mot cau: "); string s = Console.ReadLine();
            int count = 0;
            for (int i = 65; i <= 90; i++)
                if (s.ToUpper().Contains((char)i))
                {
                    count++;
                }
            if (count >= 26)
            { Console.WriteLine("Ban vua nhap mot chuoi pangram!"); }
            else { Console.WriteLine("Day khong phai la chuoi pangram"); }
        }
    }
}
