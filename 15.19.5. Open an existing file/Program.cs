using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileInfo MyFile = new FileInfo(@"c:\TEST\Testing.txt");
        FileStream MyStream;

        MyStream = MyFile.Open(FileMode.Open, FileAccess.Read, FileShare.None);
    }
}