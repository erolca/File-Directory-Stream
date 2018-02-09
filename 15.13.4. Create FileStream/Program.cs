using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {

        FileInfo MyFiles = new FileInfo(@"c:\TEST\Testing.txt");
        FileStream MyFileStream1 = MyFiles.OpenRead();
        int MyBytes = MyFileStream1.ReadByte();
        MyFileStream1.Close();
    }
}