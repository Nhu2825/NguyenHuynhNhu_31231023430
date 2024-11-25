using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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
            //thu();
            test();

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
        /// <summary>
        /// Nhập tự động một jagged array với số dòng và số cột mỗi dòng được cung cấp từ người dùng
        /// </summary>
        /// <param name="a"></param>
        /// <param name="rows"></param>
        /// <returns></returns>
        static int[][] nhapmangtudong(int[][] a, int rows)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: "); int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    //Console.Write($"a[{i}, {j} =");
                    a[i][j] = random.Next(1, 100);
                }
            }
            return a;
        }
        /// <summary>
        /// in mảng đã tạo
        /// </summary>
        /// <param name="a"></param>
        static void inmang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }

        }
        static int[] sortRow(int[][] a, int index)
        {
            int[] line = a[index];
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < line.Length - 1; j++)
                {
                    if (line[j] > line[j + 1])
                    {
                        int temp = line[j];
                        line[j] = line[j + 1];
                        line[j + 1] = temp;
                    }
                }
            }
            return line;
        }
        public static void ExVip()
        {

        }
        /// <summary>
        /// Tạo một mảng có sẵn các giá trị
        /// </summary>
        public static string[][][] MangTaoSan()
        {
            // Define a jagged array for 3 groups
            string[][][] groups = new string[3][][];
            {
                // Group 1 with 5 mem
                groups[0] = new string[5][];
                {
                    groups[0][0] = new string[] { "G101", "hhhhj", "task1", "task2" };
                    groups[0][1] = new string[] { "G102", "jhkh", "task1", "task2", "taskt3" };
                    groups[0][2] = new string[] { "G103", "jhkh", "task1", "task2", "taskt3", "taskX" };
                    groups[0][3] = new string[] { "G104", "jhkh", "task1", "task2", "taskt3" };
                    groups[0][4] = new string[] { "G105", "jhkh", "task1", "task2", "taskt3" };
                };
                // Group 2 with 3 mem
                groups[1] = new string[3][];
                {
                    groups[1][0] = new string[] { "G201","hhhhj", "task1" };
                    groups[1][1] = new string[] { "G202","jhkh", "task1", "task2", "taskt3" };
                    groups[1][2] = new string[] { "G203", "task1", "task2", "taskt3", "taskX" };
                };
                // Group 3 with 6 mem
                groups[2] = new string[6][];
                {
                    groups[2][0] = new string[] { "G301", "hhhhj", "task1", "task2" };
                    groups[2][1] = new string[] { "G302", "jhkh", "task1", "task2", "taskt3" };
                    groups[2][2] = new string[] { "G303", "jhkh", "task1", "task2", "taskt3", "taskX" };
                    groups[2][3] = new string[] { "G304","jhkh", "task1", "task2", "taskt3" };
                    groups[2][4] = new string[] { "G305", "jhkh", "task1", "task2", "taskt3" };
                    groups[2][5] = new string[] { "G306", "jhkh", "task1", "task2", "taskt3", "taskA", "taskB", "TaskC" };
                };
            }
            return groups;
        }

        /// <summary>
        /// Menu để chọn tác vụ
        /// </summary>
        static void menu()
        {
            int choice;
            do
            {
                Console.Clear();
                Console.WriteLine("=== MENU ===");
                Console.WriteLine("1. Tùy chọn 1");
                Console.WriteLine("2. Tùy chọn 2");
                Console.WriteLine("3. Tùy chọn 3");
                Console.WriteLine("0. Thoát");
                Console.Write("Nhập lựa chọn của bạn: ");
                do
                {
                    bool check = int.TryParse(Console.ReadLine(), out choice);
                    if (!check)
                    {
                        Console.WriteLine("Vui long nhap mot so nguyen");
                    }
                    else
                        break;
                }
                while (true);                 
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Bạn đã chọn Tùy chọn 1.");
                        break;
                    case 2:
                        Console.WriteLine("Bạn đã chọn Tùy chọn 2.");
                        break;
                    case 3:
                        Console.WriteLine("Bạn đã chọn Tùy chọn 3.");
                        break;
                    case 0:
                        Console.WriteLine("Thoát chương trình...");
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng thử lại.");
                        break;
                }

                if (choice != 0)
                {
                    Console.WriteLine("\nNhấn phím bất kỳ để tiếp tục...");
                    Console.ReadKey();
                }

            } while (choice != 0); // Lặp lại nếu chưa chọn "0"
        }
        static string[][][] nhapmangbangcom(string[][][] a, uint soGroup)
        {
            a=new string[soGroup][][];
            for (int i = 0; i < soGroup-1; i++)
            {
                Console.Write($"So nhan vien cua Group {i+1}: ");  uint mem = YeucauNhapSoNguyenDuong();
                a[i] = new string[mem][];
                for (int j = 0; j < mem-1; j++)
                {
                    Console.Write($"Nhap ID nhan vien {j+1}: "); string ID = Console.ReadLine();
                    Console.Write("Nhap ten nhan vien: "); string name = Console.ReadLine();
                    Console.Write("Nhap so task: "); uint task = YeucauNhapSoNguyenDuong();
                    a[i][j] =new string[task];
                    a[i][j][0] = ID;
                    a[i][j][1] = name;
                    for (int k = 1; k < task+1; k++)
                    {
                        Console.Write($"Nhap ten task {k}: ");
                        string taskname = Console.ReadLine();
                    }    
                }
            }
            return a;
        }
        public static void InmangGroups(string[][][]groups)
        {
            // Display the data
            for (int i = 0; i < groups.Length; i++)
            {
                for (int j = 0; j < groups[i].Length; j++)
                {
                    Console.Write($"ID: {groups[i][j][0]} \t Name: {groups[i][j][0]}. \n Tasks list: ");
                    for (int k =2; k < groups[i][j].Length; k++)
                    {
                        Console.WriteLine($"{groups[i][j][k]}; ");
                    }
                    Console.WriteLine();
                }
            }
        }
        public static uint YeucauNhapSoNguyenDuong()
        {
            uint nhap;
            do
            {
                bool check = uint.TryParse(Console.ReadLine(), out nhap);
                if (!check)
                {
                    Console.WriteLine("Vui long nhap mot so nguyen duong!");
                }
                else
                    break;
            }
            while (true);
            return nhap;
        }
        public static void test()
        {
            Console.Write("Nhap so group: ");
            uint soGroup=YeucauNhapSoNguyenDuong();
            string[][][] groups = new string [soGroup][][];
            nhapmangbangcom(groups,soGroup);
            InmangGroups(groups);
        }
        /// <summary>
        /// Print the information on a member when the ID is known.
        /// </summary>
        public static void TimtheoID(string[][][]groups)
        {
            Console.Write("Nhap ID can tim: "); string FindID = Console.ReadLine();
            foreach (string[][] G in groups)
            {
                foreach (string[] mem in G)
                {
                    if (mem[0]==FindID)
                    {
                        Console.WriteLine($"ID: {mem[0]}, Name: {mem[1]}, Completed task: {mem.Length-1}. ");
                        return;
                    }    
                }    
            }
            Console.Write("ID khong ton tai.");
        }
        public static void NhieuTaskNhat(string[][][]groups)
        {
            foreach (string[][] G in groups)
            {
                foreach (string[] mem in G)
                {
                    Console.WriteLine($"ID: {mem[0]}, Name: {mem[1]}, Completed task: {mem.Length - 1}. ");                   
                }
            }
        }

    }
}
