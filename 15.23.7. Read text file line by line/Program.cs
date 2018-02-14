using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        FileStream outStream = File.Create("c:\\TEST\\Testfile.txt");
        StreamWriter sw = new StreamWriter(outStream);

        sw.WriteLine("This is a test of the StreamWriter class");

        sw.Flush();
        sw.Close();

        StreamReader sr = new StreamReader("c:\\TEST\\Testfile.txt");

        string FirstLine;

        FirstLine = sr.ReadLine();
        Console.WriteLine(FirstLine);

        sr.Close();
    }
}