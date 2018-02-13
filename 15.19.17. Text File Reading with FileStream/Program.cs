using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        byte[] byData = new byte[200];
        char[] charData = new Char[200];

        FileStream aFile = new FileStream("c.\\TEST\\Program.cs", FileMode.Open);
        aFile.Seek(113, SeekOrigin.Begin);
        aFile.Read(byData, 0, 200);

        Decoder d = Encoding.UTF8.GetDecoder();
        d.GetChars(byData, 0, byData.Length, charData, 0);
        Console.WriteLine(charData);
    }
}