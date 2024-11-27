using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session7
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ss7
    {
        internal class jagged
        {
            public static void Main()
            {
                ex02();
                Console.ReadLine();
            }
            /// <summary>
            /// Create a jagged array and initialize it using the following values for its rows and columns. Then, display it. <br />
            ///1 1 1 1 1 <br />
            ///2 2<br /> 3 3 3 3 <br />4 4
            /// </summary>
            public static void E01()
            {
                int[][] a =
                {
                new int[] {1,1,1,1,1},
                new int[] {2, 2 },
                new int[] {3, 3, 3, 3},
                new int[]  {4, 4 }
            };
                inmang(a);
            }
            /// <summary>
            /// Create a Jagged Array with random integer numbers (or by user input) by getting the number of rows and columns from the user and printing the data in the array to the user.<br />
            /// Then, create functions to implement following tasks: <br />
            /// 1. Print the biggest number of each row and the largest number of the whole array. <br />
            /// 2. Sort values ascending of each row. <br />
            /// 3. Print items of the array that are prime. <br />
            /// 4. Search and print all positions of a number (enter from the user).
            /// </summary>
            public static void ex02()
            {
                int[][] a;
                Console.Write("Nhap so dong:  "); int rows = int.Parse(Console.ReadLine());
                a = new int[rows][];
                nhapmangtudong(a, rows);
                inmang(a);
                Console.WriteLine("Mang da sap xep: ");
                inmang(sort(a));
                //maxofrow(a);
                //Console.Write("Nhap so can tim vi tri:  "); int x = int.Parse(Console.ReadLine());
                //search(a, x);
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
            /// <summary>
            /// Tạo mảng tự động
            /// </summary>
            /// <param name="a"></param>
            /// <param name="rows"></param>
            static void nhapmangtudong(int[][] a, int rows)
            {
                Random random = new Random();
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"Nhap so cot cho dong {i}: "); int cols = int.Parse(Console.ReadLine());
                    a[i] = new int[cols];
                    for (int j = 0; j < cols; j++)
                    {
                        //Console.Write($"a[{i}, {j} =");
                        a[i][j] = random.Next(100);
                    }
                }
            }
            /// <summary>
            /// Sắp xếp phần tử trong từ dòng của mảng
            /// </summary>
            /// <param name="a"></param>
            /// <returns></returns>
            static int[][] sort(int[][] a)
            {
                for (int k = 0; k < a.Length; k++)
                {

                    int[] line = a[k];
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
                    a[k] = line;
                }
                return a;
            }
            /// <summary>
            /// TÌm số lớn nhất trong từng dòng
            /// </summary>
            /// <param name="a"></param>
            public static void maxofrow(int[][] a)
            {
                int[] arrMax = new int[a.Length];
                for (int k = 0; k < a.Length; k++)
                {
                    int[] line = a[k];
                    int max = line[0];
                    for (int i = 1; i < line.Length; i++)
                    {
                        max = timmax(line);
                        arrMax[k] = max;
                    }
                    Console.WriteLine($"Max dong {k} la {max}.");
                }

                Console.WriteLine($"Gia tri lon nhat jagged array la {timmax(arrMax)}");
            }
            /// <summary>
            /// Tìm số lớn nhất trong 1 dòng cụ thể
            /// </summary>
            /// <param name="a"></param>
            /// <returns></returns>
            static int timmax(int[] a)
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (max < a[i])
                    {
                        max = a[i];
                    }
                }
                return max;
            }
            static void search(int[][] a, int key)
            {
                int hang = -1;
                int cot = -1;
                for (int i = 0; i < a.Length; i++)
                {
                    for (int j = 0; j < a[i].Length; j++)
                    {
                        if (a[i][j] == key)
                        {
                            hang = i;
                            cot = j; break;
                        }
                    }
                }
                if (hang == -1)
                { Console.WriteLine("So nay khong co trong chuoi"); }
                else { Console.WriteLine($"So {key} nam ơ hang {hang}, cot {cot} cua jagged array."); }
            }
            /// <summary>
            /// The X company has 3 working groups; group 1 has 5 members, group 2 has 3 members, and group 3 has 6 members.
            /// The data stored for each member has an ID number, full name, and completed tasks.<br />
            /// An ID identifies each member.<br />
            /// ▸Select an appropriate data structure to save this info.Then, write functions to perform the following tasks: <br />
            /// 1. Initialize an array with pre-assigned values ​or values ​entered from the keyboard.<br />
            /// 2. Print a list of all members.<br />
            /// 3. Print the information on a member when the ID is known.<br />
            /// 4. Print the member with the highest number of completed tasks.<br />
            /// 1. Create the main program with menus that allow you to select the tasksto be performed.<br />
            /// Hint: create a jagged array to store these members in the form [id,[name, tasks]].
            /// </summary>
            public static void ExVip()
            { // Define a jagged array for 3 groups
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
                        groups[1][0] = new string[] { "G201", "hhhhj", "task1" };
                        groups[1][1] = new string[] { "G202", "jhkh", "task1", "task2", "taskt3" };
                        groups[1][2] = new string[] { "G203", "task1", "task2", "taskt3", "taskX" };
                    };
                    // Group 3 with 6 mem
                    groups[2] = new string[6][];
                    {
                        groups[2][0] = new string[] { "G301", "hhhhj", "task1", "task2" };
                        groups[2][1] = new string[] { "G302", "jhkh", "task1", "task2", "taskt3" };
                        groups[2][2] = new string[] { "G303", "jhkh", "task1", "task2", "taskt3", "taskX" };
                        groups[2][3] = new string[] { "G304", "jhkh", "task1", "task2", "taskt3" };
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
                    Console.WriteLine("1. Nhap thong tin nhan vien.");
                    Console.WriteLine("2. In tat ca thong tin.");
                    Console.WriteLine("3. In thong tin biet ID.");
                    Console.WriteLine("4. In thong tin nguoi nhieu Task nhat.");
                    Console.WriteLine("0. Exist");
                    Console.Write("Ban muon thuc hien tac vu nao?  ");
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
                            Console.WriteLine("Nhap thong tin nhan vien.");
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

        }
    }

}
