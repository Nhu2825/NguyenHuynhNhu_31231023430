using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TestBin
    {
        static void Main()
        {
            string path = "data.bin";
            write(path, 100);
            read(path);
        }
        static void write(string path, int N)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryWriter binaryWriter = new BinaryWriter(fs, Encoding.UTF8);

            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                binaryWriter.Write(rnd.Next(100));
            }
            binaryWriter.Close();
        }
        static void read(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fs);
            int val;

            while (binaryReader.BaseStream.Position != binaryReader.BaseStream.Length)
            {
                val = binaryReader.ReadInt32();

                Console.Write(val + " ");
            }
            binaryReader.Close();
        }
    }
}

