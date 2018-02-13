using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileStream MyFileStream1 = new FileStream(@"c:\TEST\Testing.txt", FileMode.Create);

        int NumberOfBytes = 200;
        byte[] MyByteArray = new Byte[NumberOfBytes];
        int BytesRead = MyFileStream1.Read(MyByteArray, 0, NumberOfBytes);

        MyFileStream1.Close();
    }
}