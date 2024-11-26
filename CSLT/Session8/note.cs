using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.Session8
{
    internal class note
    {
        public static void Main()
        {
            Console.WriteLine("nhap gi do: ");
            string s = Console.ReadLine();
           
            Console.WriteLine(countwords(s));
        }
        public static void strings()
        {
            //string s = "con cho sua gau gau" + "con meo sua nhu con cho";
            //int pos = s.IndexOf("gau gau");
            //Console.WriteLine(pos);
            //s = s.Replace("sua nhu con cho", "keu meo meo");
            //Console.WriteLine(s);
            string s2 = "hello babe";
            for (int i = 0; i < s2.Length; i++)
            {
                Console.WriteLine(s2[i]);
            }
            foreach (char c in s2)
            {
                Console.WriteLine(c);
            }
            int leng = 0;
            foreach (char c in s2)
            {
                leng++;
            }
            Console.WriteLine(leng);
            Console.WriteLine(s2.Length);
                          
        }
        public static int countwords(string s)
        {
            int count = 0;
            //bỏ khoảng trắng thừa trong chuỗi
            s = s.Trim();//bỏ khoảng trắng thừa ở đầu và cuối
            while (s.IndexOf("  ")!=-1)
            {
                s = s.Replace("  ", " ");
            }
            foreach (char c in s)
            {
                if (c == ' ') { count++; }
            }
            return count+1;
        }
    }
}
