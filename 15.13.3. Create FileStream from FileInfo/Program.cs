using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {

        FileInfo MyFiles = new FileInfo(@"c:\TEST\Testing.txt");
        FileStream MyFileStream1 = MyFiles.OpenWrite();

        byte MyWriteByte = 100;

        MyFileStream1.WriteByte(MyWriteByte);

        MyFileStream1.Close();
    }
}