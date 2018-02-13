using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        FileStream aFile = new FileStream("Log.txt", FileMode.Open);
        StreamReader sr = new StreamReader(aFile);
        string strLine = sr.ReadLine();

        while (strLine != null)
        {
            Console.WriteLine(strLine);
            strLine = sr.ReadLine();
        }
        sr.Close();
    }
}