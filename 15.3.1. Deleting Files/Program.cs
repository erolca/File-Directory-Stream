using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileInfo MyFile = new FileInfo(@"c:\Test\Testing.txt");

        MyFile.Create();
        MyFile.Delete();
    }
}