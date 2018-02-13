using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        StreamReader MyStreamReader = new StreamReader(@"c:\TEST\Testing.txt");

        for (int i = 0; i < 99; i++)
        {
            int ch = MyStreamReader.Read();
            Console.WriteLine(ch);

        }

        MyStreamReader.Close();
    }
}