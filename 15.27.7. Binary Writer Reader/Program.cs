using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileInfo f = new FileInfo("BinFile.dat");
        using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
        {
            double aDouble = 1234.67;
            int anInt = 34567;
            string aString = "A, B, C";
            bw.Write(aDouble);
            bw.Write(anInt);
            bw.Write(aString);
        }
        using (BinaryReader br = new BinaryReader(f.OpenRead()))
        {
            Console.WriteLine(br.ReadDouble());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadString());
        }
    }
}