using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        FileStream outStream = File.Create("c:\\TEST\\Test.txt");
        StreamWriter sw = new StreamWriter(outStream);

        sw.WriteLine("This is a test of the StreamWriter class");

        sw.Flush();
        sw.Close();

        StreamReader sr = new StreamReader("c:\\TEST\\Test.txt");

        string FirstLine;

        FirstLine = sr.ReadLine();
        Console.WriteLine(FirstLine);

        sr.Close();
    }
}