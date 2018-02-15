using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        StreamReader sr = new StreamReader("test.txt");

        using (sr)
        {
            Console.WriteLine(sr.ReadLine());
            sr.Close();
        }

    }
}
//124.23