using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        StreamReader MyStreamReader = new StreamReader(@"c:\Test.txt");

        string str = MyStreamReader.ReadLine();
        Console.WriteLine(str);

        MyStreamReader.Close();
    }
}