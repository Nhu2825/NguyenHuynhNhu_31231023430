using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session4
{
    internal class Note
    {
        public static void Main(string[] args)
        {
            ex02();
            Console.ReadKey();
        }
        /// <summary>
        /// Giải và biện luận phương trình bậc 1 <br/>
        /// hmmm
        /// </summary>
        /// <param name="args"></param>
        static void ex01()
        {
            Console.WriteLine("nhap a"); int a = int.Parse(Console.ReadLine());
            Console.WriteLine("nhap b"); int b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("vo so nghiem");
                else
                    Console.WriteLine("vo nghiem");
            else
                Console.WriteLine("x = " + (-b / (float)a));
        }
        /// <summary>
        /// game đoán số <br/>
        /// Đoán giống máy thì thắng
        /// </summary>
        static void ex02()
        {
            do
            {
                Random rnd = new Random();
                int com_num = rnd.Next(0, 10) + 1;
                int count = 0;
                bool tiep = true;
                do
                {
                    count++;
                    Console.WriteLine("ban doan so may? tu 1 den 10");
                    int ur_num = int.Parse(Console.ReadLine());
                    if (ur_num == com_num)
                    {
                        Console.WriteLine($"ban doan dung sau {count} lan");
                        tiep = false;
                    }
                    else
                    {
                        if (ur_num >= com_num)
                        {
                            Console.WriteLine("ban doan lon hon may. Doan lai di!");
                        }
                        else
                        {
                            Console.WriteLine("ban doan nho hon may. Doan lai di!");
                        }
                    }
                } while (tiep);
                Console.WriteLine("===============================================================");
                Console.WriteLine("Tiep khong? ok/ko");
                string rep = Console.ReadLine();
                if (rep.ToLower().Equals("ko"))
                {
                    Console.WriteLine("ok nghi");
                    return;
                }


            } while (true);
        }
    }
}
