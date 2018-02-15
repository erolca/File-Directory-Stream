using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


//15.33.6.	Using statement to deal with multiple resources


class MainClass
{
    static void Main()
    {
        using (TextWriter tw1 = File.CreateText("test.txt"),
                          tw2 = File.CreateText("test2.txt"))
        {
            tw1.WriteLine("test");
            tw2.WriteLine("test1");
        }

        using (TextReader tr1 = File.OpenText("test.txt"),
                          tr2 = File.OpenText("test2.txt"))
        {
            string str;
            while (null != (str = tr1.ReadLine()))
                Console.WriteLine(str);

            while (null != (str = tr2.ReadLine()))
                Console.WriteLine(str);
        }
    }
}
//test
//test1