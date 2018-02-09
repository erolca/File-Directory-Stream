using System;
using System.IO;

public class MainClass
{
    public static void Main()
    {
        FileInfo MyFile = new FileInfo(@"c:\Test\TestCreatFile.txt");

        MyFile.Create();
    }
}