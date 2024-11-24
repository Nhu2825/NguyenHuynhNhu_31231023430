using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session3
{
    internal class Operators
    {
        public static void Main()
        {
            Ex1_ss3();
            Console.ReadKey();
        }
       /// <summary>
       /// display certain values of the function x = y2+ 2y + 1<br /> (using integer numbers for y, ranging from -5 to +5)
       /// </summary>
        public static void Ex1_ss3()
        {
            //x=y2+2y+1
            Console.WriteLine("voi x = y2 + 2y + 1");
            for (int i = -5; i <= 5; i++)
            {
                Console.WriteLine($"y = {i}, x = {i * i + 2 * i + 1}");
            }
        }
        /// <summary>
        /// Nhập quãng đường và thời gian, in ra vận tốc theo km/h và miles/h
        /// </summary>
        public static void Ex2_ss3()
        {
            Console.Write("Nhap so gio: ");
            byte h = byte.Parse(Console.ReadLine());
            Console.Write("Nhap so phut: ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Nhap so giay: ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Nhap khoang cach (km): ");
            double l = double.Parse(Console.ReadLine());
            Console.WriteLine($"van toc la {l / (h + m / 60 + s / 3600)} km/h");
            Console.WriteLine($"van toc la {(l / (h + m / 60 + s / 3600)) * 0.621371192} km/h");
        }
        /// <summary>
        /// Kiểm tra xem ký tự được nhận là nguyên âm, số hay ký tự khác
        /// </summary>
        //public static void Ex3_ss03()
        //{
        //    Console.Write("Nhập ký tự: ");
        //    char inputChar = Console.ReadLine()[0];
        //    if ("aeiouAEIOU".Contains(inputChar))
        //    {
        //        Console.WriteLine("Day la nguyen am.");
        //    }
        //    else if ((int)inputChar >= 48 && (int)inputChar <= 57)
        //    {
        //        Console.WriteLine("Day la so.");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Day la ky tụ khac, khong phải nguyen am cung khong phai so.");
        //    }
        //}
        public static void Ex5_ss03()
        {
            Console.WriteLine("Enter a character: ");
            char a = Console.ReadKey().KeyChar;
            Console.WriteLine();

            // Check if the input is a vowel
            if ("aeiouAEIOU".Contains(a))
            {
                Console.WriteLine($"{a} is a vowel.");
            }
            // Check if the input is a digit
            else if (char.IsDigit(a))
            {
                Console.WriteLine($"{a} is a digit.");
            }
            // Check if the input is any other symbol
            else if (char.IsLetter(a))
            {
                Console.WriteLine($"{a} is a consonant.");
            }
            else
            {
                Console.WriteLine($"{a} is a symbol.");
            }
        }
    }
}
