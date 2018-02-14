using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        FileStream aFile = new FileStream("C:\\TEST\\Log.txt", FileMode.OpenOrCreate);
        StreamWriter sw = new StreamWriter(aFile);
        bool truth = true;
        sw.WriteLine("Hello to you.");
        sw.WriteLine("It is now {0} and things are looking good.", DateTime.Now.ToLongDateString());
        sw.Write("More than that,");
        sw.Write(" it's {0} that C# is fun.", truth);
        sw.Close();
    }
}