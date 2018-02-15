using System;
using System.IO; //using DIRECTIVE, not using statement

class MainClass
{
    static void Main()
    {
        using (TextWriter tw = File.CreateText("test.txt"))// using statement 
        {
            tw.WriteLine("string");
        }

        using (TextReader tr = File.OpenText("test.txt"))
        {
            string str;
            while (null != (str = tr.ReadLine()))
                Console.WriteLine(str);
        }
    }
}
//string