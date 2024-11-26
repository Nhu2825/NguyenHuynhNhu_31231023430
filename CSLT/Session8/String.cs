using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session8
{
    internal class String
    {
        public static void Main()
        {
            Console.Write("Nhap chuoi gi do: "); string s = Console.ReadLine(); //nhập 
            Console.WriteLine(s); //in
            Console.WriteLine($"Chuoi co {countwords(s)} tu.");
            InNguoc(s);
            Console.Write("Nhap noi dung can tim: "); string sub = Console.ReadLine();
            if (s.IndexOf(sub) < 0) Console.WriteLine($"'{sub}' khong ton tai.");
            else Console.WriteLine($"Trong chuoi co '{sub}'.");
            checkSub(s, sub);
            Console.WriteLine($"Chuoi co {countSub(s, sub)} chuoi '{sub}'.");
            Console.Write("Nhap chuoi can chen"); string chen = Console.ReadLine();
            Console.WriteLine($"Chuoi da chen: " + ChenVaoDau(s, chen) + Environment.NewLine);
            char nhap;
            do
            {
                Console.Write("Nhap mot ky tu duy nhat: ");
                bool check = char.TryParse(Console.ReadLine(), out nhap);
                if (!check)
                {
                    Console.WriteLine("Vui long nhap cho dung!");
                }
                else
                    break;
            }
            while (true);//yêu cầu nhập đúng kiểu
            checkAlphanbet(nhap);
            demChu_So_Symbol(s);
            countVowelCount(s);
            Console.ReadKey();
        }
        /// <summary>
        ///  to find the length of a string without using a library function
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        static int lengthofString(string s)
        {
            int count = 0;
            foreach (int c in s)
            {
                count++;
            }
            return count;
        }
        /// <summary>
        /// in rời từng ký tự
        /// </summary>
        /// <param name="s"></param>
        static void InKyTuDaTach(string s)
        {
            foreach (char c in s)
            {
                Console.WriteLine(c);
            }
        }
        /// <summary>
        ///  to print individual characters of the string in reverse order.
        /// </summary>
        /// <param name="s"></param>
        static void InNguoc(string s)
        {
            for (int i = s.Length; i > 0; i--)
            {
                Console.Write(s[i - 1]);
            }
            Console.WriteLine();
        }
        /// <summary>
        ///  to count the total number of words in a string.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int countwords(string s)
        {
            int count = 0;
            //bỏ khoảng trắng thừa trong chuỗi
            s = s.Trim();//bỏ khoảng trắng thừa ở đầu và cuối
            while (s.IndexOf("  ") != -1)
            {
                s = s.Replace("  ", " ");
            }
            foreach (char c in s)
            {
                if (c == ' ') { count++; }
            }
            return count + 1;
        }
        /// <summary>
        /// to compare two strings without using a string library functions
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        static int SoSanhDoLon(string s1, string s2)
        {
            int min_len = lengthofString(s1) < lengthofString(s2) ? lengthofString(s1) : lengthofString(s2);
            for (int i = 0; i < min_len; i++)
            {
                if (s1[i] > s2[i])
                { return 1; }
                if (s1[i] < s2[i]) { return -1; }
            }
            return lengthofString(s1)>lengthofString(s2)? 1 : lengthofString(s1)<lengthofString(s2)? -1 : 0;
        }
        /// <summary>
        ///  to count the number of alphabets, digits and special characters in a string.
        /// </summary>
        /// <param name="s"></param>
        static void demChu_So_Symbol(string s)
        {
            int chu = 0;
            int so = 0;
            int symbol = 0;
            for (int i=0; i<s.Length; i++)
            {
                if ((int)s.ToUpper()[i] <= 90 && (int)s.ToUpper()[i] >= 65 )
                {
                    chu++;
                }
                else if ((int)s[i]>=48 && (int)s[i]<=57)
                {
                    so++;
                }
                else { symbol++; }
            }
            Console.WriteLine($"Chuoi co {chu} chu, {so} so va {symbol} ky tu khac ");   
        }
        /// <summary>
        ///  to count the number of vowels or consonants in a string.
        /// </summary>
        /// <param name="s"></param>
        static void countVowelCount(string s)
        {
            int vowel = 0;
            int consonants = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if ((int)s.ToUpper()[i] <= 90 && (int)s.ToUpper()[i] >= 65)
                {
                    if ("euoaiEUOAI".Contains(s[i]))
                    { vowel++; }  
                    else { consonants++; }
                }
            }
            Console.WriteLine($"Chuoi co {vowel} chu la nguyen am va {consonants} chu la phu am.");
        }
        /// <summary>
        ///  to find the number of times a substring appears in a given string
        /// </summary>
        /// <param name="s"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        static int countSub(string s, string sub)
        {
            int count = 0;
            while(true)
            {
                int pos = s.IndexOf(sub);
                if (pos == -1) break;
                s = s.Substring(pos + sub.Length);
                count++;
            }    
            return count;
        }
        static int countSub2(string s, string sub)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == sub[0])
                {
                    int ok = 0;
                    for (int j = 1; j < sub.Length; j++)
                    {
                        if (s[i + j] == sub[j])
                        {
                            ok++;
                        }
                    }
                    if (ok == sub.Length - 1) count++;
                }
            }
            return count;
        }
        /// <summary>
        /// to check whether a character is an alphabet and not and if so, check for the case
        /// </summary>
        /// <param name="x"></param>
        static void checkAlphanbet(char x)
        {
            if ((int)x <= 90 && (int)x >= 65 || (int)x >= 97 && (int)x <= 122)
            {
                Console.WriteLine($"'{x}' la chu cai.");
            }
            else if ((int)x >= 48 && (int)x <= 57)
            {
                Console.WriteLine($"'{x}' la so.");
            }
            else { Console.WriteLine($"'{x}' la symbol."); }
        }
        /// <summary>
        ///  to check whether a given substring is present in the given string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="sub"></param>
        static void checkSub(string  s, string sub)
        {
            //if (s.Contains(sub)) Console.WriteLine($"Chuoi co chua {sub}.");
            //else
            //{
            //    Console.WriteLine($"Chuoi khong chua {sub}.");
            //}
            bool check = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == sub[0])
                {
                    int ok = 0;
                    for (int j = 1; j < sub.Length; j++)
                    {
                        if (s[i + j] == sub[j])
                        {
                            ok++;
                        }
                    }
                    if (ok == sub.Length - 1) check=true;
                }
            }               
            if (check) Console.WriteLine($"Ton tai '{sub}' trong chuoi.");
            else Console.WriteLine($"Trong chuoi khong co '{sub}'.");
        }
        /// <summary>
        /// to insert a substring before the first occurrence of a string.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="sub"></param>
        /// <returns></returns>
        static string ChenVaoDau(string s, string sub)
        {
            string s1 = s;
            s = sub+" "+s1;
            return s;
        }
    }
}

    