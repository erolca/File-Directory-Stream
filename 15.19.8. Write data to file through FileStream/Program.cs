using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileStream MyFileStream1 = new FileStream(@"c:\TEST\Testing.txt", FileMode.Create);

        byte MyWriteByte = 100;

        MyFileStream1.WriteByte(MyWriteByte);

        MyFileStream1.Close();
    }
}