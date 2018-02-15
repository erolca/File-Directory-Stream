using System;
using System.IO;

class MainClass
{
    static void Main()
    {
        using (TextWriter tw1 = File.CreateText("test.txt"))
        {
            tw1.WriteLine("test");
            using (TextWriter tw2 = File.CreateText("test2.txt"))
                tw2.WriteLine("test1");
        }

        using (TextReader tr = File.OpenText("test.txt"))
        {
            string str;

            while (null != (str = tr.ReadLine()))
                Console.WriteLine(str);

            using (TextReader tr2 = File.OpenText("test2.txt"))
                while (null != (str = tr2.ReadLine()))
                    Console.WriteLine(str);
        }
    }
}
//test
//test1