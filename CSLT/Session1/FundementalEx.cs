using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session1
{
    internal class FundementalEx
    {
        public static void Main()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// 1. To add/sum 2 numbers
        /// </summary>
        public static void q1()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b; ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a}+{b}={c}");
        }
        /// <summary>
        /// 2. to Swap Values of Two Variables
        /// </summary>
        public static void q2()
        {
            Console.Write("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            int c = b;
            b = a;
            a = c;
            Console.WriteLine($"Gia tri moi cua a la {a}");
            Console.WriteLine($"Gia tri moi cua b la {b}");

        }
        /// <summary>
        /// 3. to Multiply two Floating Point Numbers
        /// </summary>
        public static void q3()
        {
            Console.Write("nhap so thuc a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("nhap so thuc b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"{a}*{b}={c}");
        }
        /// <summary>
        /// 4. to convert feet to meter
        /// </summary>
        public static void q4()
        {
            Console.Write("Input feet = ");
            double a = double.Parse(Console.ReadLine());
            double c = a * 0.3048;
            Console.WriteLine($"{a} feet ={c} meter(s)");
        }
        /// <summary>
        /// 5. to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void q5()
        {
            Console.Write("Input Celsius degree = ");
            double a = double.Parse(Console.ReadLine());
            double c = (a * 1.8 + 32);
            double d = (a - 32) / 1.8;
            Console.WriteLine($"{a} do C ={c} do F");
            Console.WriteLine($"{a} do F ={d} do C");
        }
        /// <summary>
        /// 6. to find the Size of data types
        /// </summary>
        public static void q6()
        {
            Console.WriteLine($"1. Size of int: {sizeof(int)} bytes");
            Console.WriteLine($"2. Size of double: {sizeof(double)} bytes");
            Console.WriteLine($"3. Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"4. Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"5. Size of bool: {sizeof(bool)} bytes");
            Console.WriteLine($"6. Size of long: {sizeof(long)} bytes");
            Console.WriteLine($"7. Size of short: {sizeof(short)} bytes");
            Console.WriteLine($"8. Size of ushort: {sizeof(ushort)} bytes");
            Console.WriteLine($"9. Size of byte: {sizeof(byte)} bytes");
            Console.WriteLine($"10. Size of uint: {sizeof(uint)} bytes");
            Console.WriteLine($"11. Size of decimal: {sizeof(decimal)} bytes");
        }
        /// <summary>
        /// 7. to Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        public static void q7()
        {
            Console.Write("Nhap ky tu: ");
            Char a = Char.Parse(Console.ReadLine());
            int maso = a;
            Console.WriteLine($"{a} in ASCII = {maso}");
        }
        /// <summary>
        /// 8. to Calculate Area of Circle
        /// </summary>
        public static void q8()
        {
            Console.Write("nhap ban kinh: ");
            float a = float.Parse(Console.ReadLine());
            double s = Math.PI * Math.Pow(a, 2);
            Console.WriteLine($"Dien tich hinh tron la {s}");
        }
        /// <summary>
        /// 9. to Calculate Area of Square
        /// </summary>
        public static void q9()
        {
            Console.Write("nhap do dai canh: ");
            float a = float.Parse(Console.ReadLine());
            double s = a * a;
            Console.WriteLine($"Dien tich hinh vuong la {s}");
        }
        /// <summary>
        /// 10. to convert days to years, weeks and days
        /// </summary>
        public static void q10()
        {
            Console.Write("Nhap so ngay bat ky: ");
            int d = int.Parse(Console.ReadLine());
            int y = d / 365;
            int w = (d - y * 365) / 7;
            int le = d % 7;
            Console.WriteLine($"{d} ngay bang {y} nam, {w} tuan, {le} ngay");
        }
    }
}     
/*                                                                          __
                __                                     |_|     __          /  \      _______                                                  __
 \\      //  / /--\\        //\\     | \  ||  ||   ||  | |    /  \__/         /      | ____|   |  \    /  |    | |  | |      \ \  / /     /  /  \_\
  \\    //  | |    ||      //  \\    ||\\ ||  ||___||  | |                           | |___    | |\\  //| |    | |  | |       \ \/ /      | |
   \\  //   | |    ||     //====\\   || \\||  ||---||  | |                           | |____   | | \\// | |    | |  | |        |  |       | |    __
    \\//     \ \==//     //      \\  ||  \\|  ||   ||  |_|                           |_____|   | |  \/  | |    \ \__/ /        |  |        \ \__/ /

--------------------------------------------------------------------------------
________________________________________________________________________________
\\\
 \\\
 ///
///
\\\
 \\\
 ///
///
 */
1