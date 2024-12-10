﻿using System;
using System.IO;

namespace CSLT.Session9
{
    internal class FileEx
    {
        public static void Main()
        {
            string path = @"D:\Test.txt";
            //q2(path);
            //q1(path);
            q4(path);
        }
        /// <summary>
        /// 1. To create a blank file on the disk.
        /// </summary>
        public static void q1(string path)
        {
			FileStream fs = new FileStream(path, FileMode.Create);
	    }
        /// <summary>
        /// 2. to remove a file from the disk.
        /// </summary>
        public static void q2(string path)
        {
            File.Delete(path);
        }
        /// <summary>
        /// 3. to create a file and add some text.
        /// </summary>
        public static void q3(string path, string content)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Read);
            StreamWriter sth = new StreamWriter(fs);
            sth.WriteLine("Life is just a dream (not my dream...)");
            sth.WriteLine(content);
            sth.Close();
        }
        /// <summary>
        /// 4. create a text file and read it.
        /// </summary>
        public static void q4(string path)
        {
			FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);
			StreamWriter sth = new StreamWriter(fs);
			string st = "";
			Random rnd = new Random();
			for (int i = 0; i < 1000; i++)
			{
				st += rnd.Next(500) + ",";
			}
			sth.WriteLine(st); sth.Close();
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadToEnd();
		}
        /// <summary>
        /// 5. to create a file and write an array of strings to the file.
        /// </summary>
        public static void q5()
        {

        }
        /// <summary>
        /// 6. to append some text to an existing file.
        /// </summary>
        public static void q6()
        {

        }
        /// <summary>
        /// 7. to create and copy the file to another name and display the content.
        /// </summary>
        public static void q7()
        {

        }
        /// <summary>
        /// 8. create a file and move it into the same directory with another name.
        /// </summary>
        public static void q8()
        {

        }
        /// <summary>
        /// 9. read the first line of a file.
        /// </summary>
        public static void q9()
        {

        }
        /// <summary>
        /// 10. to create and read the last line of a file.
        /// </summary>
        public static void q10()
        {

        }
        /// <summary>
        /// 11. create and read the last n lines of a file.
        /// </summary>
        public static void q11()
        {

        }
        /// <summary>
        /// 12. to read a specific line from a file.
        /// </summary>
        public static void q12()
        {

        }
        /// <summary>
        /// 13. to count the number of lines in a file.
        /// </summary>
        public static void q13()
        {

        }
        /// <summary>
        /// 14. To print the structure of specific folder (include files)
        /// </summary>
        public static void q14()
        {

        }
        /// <summary>
        /// 15. Read a text file, then statistic the appearance of characters and numbers.
        /// </summary>
        public static void q15()
        {

        }
    }
}
