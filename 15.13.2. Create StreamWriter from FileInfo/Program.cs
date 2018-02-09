using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileInfo MyFile = new FileInfo(@"c:\TEST\Testing.txt");
        StreamWriter MyStreamWriter = MyFile.CreateText();
        MyStreamWriter.Write("a string");
        MyStreamWriter.Close();

    }
}