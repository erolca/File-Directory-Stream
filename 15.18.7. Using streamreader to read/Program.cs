using System;
using System.IO;
using System.Text;


//15.18.7.	Using streamreader to read the entire stream at once


public class MainClass
{
    public static void Main()
    {

        Stream s = new FileStream("c:\\TEST\\test.txt", FileMode.Open);
        using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
        {
            Console.WriteLine(sr.ReadToEnd());
        }
    }
}