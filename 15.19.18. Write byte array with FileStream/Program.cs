using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileStream aFile = new FileStream("c:\\TEST\\Temp.txt", FileMode.Create);
        char[] charData = "this is a test.".ToCharArray();
        byte[] byData = new byte[charData.Length];
        Encoder e = Encoding.UTF8.GetEncoder();
        e.GetBytes(charData, 0, charData.Length, byData, 0, true);

        // Move file pointer to beginning of file.
        aFile.Seek(0, SeekOrigin.Begin);
        aFile.Write(byData, 0, byData.Length);
    }
}