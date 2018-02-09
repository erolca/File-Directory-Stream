using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileInfo MyFile = new FileInfo(@"c:\TEST\Testing.txt");

        MyFile.Create();
        MyFile.CopyTo(@"c:\TEST\Testing.txt");

        //or
        MyFile.CopyTo(@"c:\TEST\Testing.txt", true);
    }
}