using System;
using System.IO;


//15.20.8.	StreamReader: ReadToEnd()


public class MainClass
{
    static void Main(string[] args)
    {
        StreamReader MyStreamReader = new StreamReader(@"c:\TEST\Testing.txt");

        string str = MyStreamReader.ReadToEnd();
        Console.WriteLine(str);

        MyStreamReader.Close();
    }
}