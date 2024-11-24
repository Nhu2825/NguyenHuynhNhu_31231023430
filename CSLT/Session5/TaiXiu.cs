using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session5
{
    internal class TaiXiu
    {
        /// <summary>
        /// lắc xí ngầu
        /// </summary>
        /// <returns></returns>
        public static int rollDice()
        {
            Random rnd = new Random();
            int die_1 = rnd.Next(6) + 1;
            int die_2 = rnd.Next(6) + 1;
            int die_3 = rnd.Next(6) + 1;
            int sum_of_die = die_1 + die_2 + die_3;
            return sum_of_die;
        }
        /// <summary>
        /// chơi một lần
        /// </summary>
        static void playoneRound()
        {
            int com_die = rollDice();
            Console.Write("Ban doan tai hay xiu (T/X)___");
            string user_guessing = Console.ReadLine();
            if (user_guessing.ToUpper().Equals("T"))
                if (com_die >= 10) //tài
                {
                    Console.WriteLine($"Ket qua la {com_die} nut");
                    Console.WriteLine("ok, ban thang roi!");
                }
                else
                {
                    Console.WriteLine($"Ket qua la {com_die} nut");
                    Console.WriteLine("hehe thua roi");
                }
            else if (user_guessing.ToUpper().Equals("X"))
                if (com_die < 10)//xỉu
                {
                    Console.WriteLine($"Ket qua la {com_die} nut");
                    Console.WriteLine("ok, ban thang roi!");
                }
                else
                {
                    Console.WriteLine($"Ket qua la {com_die} nut");
                    Console.WriteLine("hehe thua roi");
                }
            else { Console.WriteLine("Nhap cho dung!!!"); }
            Console.WriteLine("===========================================================================");
        }
        /// <summary>
        /// cấp tài khoản có tiền sẵn để có thể cược và tính điểm  
        /// <br/> nếu không tạo tài khoản, vẫn có thể chơi nhưng không có chức năng cược và tính điểm
        /// </summary>
        public static int taoacc()
        {
            /*int acc = 0;
            do
            {
                Console.WriteLine("Ban co muon tao tai khoan co san 300 xu mien phi khong?  <ok/ko>");
                string rep = Console.ReadLine();                
                if (rep.ToLower().Equals("ok"))
                {
                    Console.WriteLine("Chuc mung ban nhan duoc 300 xu!!");
                    acc += 300;                    
                    break;
                }
                else if (rep.ToLower().Equals("ko"))
                {
                    Console.WriteLine("Ban co the choi ma khong su dung chuc nang cuoc, tinh diem.");
                    break;
                }
                else
                {
                    Console.WriteLine( "Vui long tra loi dung cu phap!");
                }                     
            }
            while (true);
            Console.WriteLine("Ok, get go!");
            */
            Console.Write("Ban hay dat ten cho tai khoan: ___");
            string taikhoan = Console.ReadLine();
            Console.WriteLine("Ban da tao tai khoan thanh cong. Ban muon nap bao nhieu tien vao tai khoan? <100xu - 200xu - 300xu> ____");
            int acc = int.Parse(Console.ReadLine());
            Console.WriteLine($"Tai khoan {taikhoan} hien co {acc} xu.");
            return acc;
        }
        /// <summary>
        /// Cho phép đặt cược
        /// </summary>
        static void betable()
        {
            int tien = taoacc();
            int win = 0;
            int loose = 0;
            do
            {
                int com_die = rollDice();
                Console.Write("ban doan tai hay xiu (T/X)___");
                string user_guessing = Console.ReadLine();
                Console.Write("Chon muc cuoc la mot so nguyen lon hon 0 __");
                int cuoc = int.Parse(Console.ReadLine());
                if (cuoc > tien)
                {
                    Console.WriteLine($"Tai khoan cua ban con it hon {cuoc} xu, vui long chon lai muc cuoc");
                }
                else if (cuoc < 0)
                {
                    Console.WriteLine("Vui long nhap so tien lon hon");
                }

                if (user_guessing.ToUpper().Equals("T"))
                    if (com_die >= 10) //tài
                    {
                        Console.WriteLine($"Ket qua la {com_die} nut");
                        Console.WriteLine("ok, ban thang roi!");
                        tien += cuoc;
                        win++;
                    }
                    else
                    {
                        Console.WriteLine($"Ket qua la {com_die} nut");
                        Console.WriteLine("hehe thua roi");
                        loose++;
                        tien -= cuoc;
                    }
                else if (user_guessing.ToUpper().Equals("X"))
                    if (com_die < 10)//xỉu
                    {
                        Console.WriteLine($"Ket qua la {com_die} nut");
                        Console.WriteLine("ok, ban thang roi!");
                        tien += cuoc;
                        win++;
                        Console.WriteLine($"+ {cuoc}xu. Ban co {tien} xu");
                    }
                    else
                    {
                        Console.WriteLine($"Ket qua la {com_die} nut");
                        Console.WriteLine("hehe thua roi");
                        tien -= cuoc;
                        loose++;
                        Console.WriteLine($"- {cuoc} xu. Ban con {tien} xu");
                    }
                else { Console.WriteLine("Nhap cho dung!!!"); }
                Console.Write("Choi nua hong? <ok/ko>___"); string choice = Console.ReadLine();
                Console.WriteLine("===========================================================================");
                if (choice.ToLower().Equals("ko"))
                    break;
            }
            while (true);
            Console.WriteLine($"Ban co {tien} xu sau {win + loose} luot choi. Ban da thang {win} van va thua {loose} van.");
            Console.WriteLine("Bye bye! Mai choi tiep nhe!");
        }
        /// <summary>
        /// chơi nhiều lần, có thể tạo acc
        /// </summary>
        static void rungame()
        {
            do
            {
                Console.Write("Ban muon tao acc hay khong? <ok/ko> ___");
                string traloi = Console.ReadLine();
                if (traloi.ToLower().Equals("ok"))
                {
                    betable();
                    break;
                }
                else if (traloi.ToLower().Equals("ko"))
                {
                    do
                    {
                        playoneRound();
                        Console.Write("Choi nua hong? <ok/ko>___"); string choice = Console.ReadLine();
                        if (choice.ToLower().Equals("ko"))
                            break;
                    }
                    while (true);
                    Console.WriteLine("Bye bye! Mai choi tiep nhe!");
                }
                else
                    Console.WriteLine("Vui long nhap dung cu phap!");
            }
            while (true);
        }

        public static void Main()
        {
            rungame();
            //taoacc();
            Console.ReadKey();
        }
    }
}

