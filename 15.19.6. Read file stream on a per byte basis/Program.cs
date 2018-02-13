using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileStream MyFileStream1 = new FileStream(@"c:\TEST\Testing.txt", FileMode.Create);


        int MyBytes = MyFileStream1.ReadByte();

        MyFileStream1.Close();
    }
}