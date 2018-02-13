using System;
using System.IO;

public class MainClass
{

 
    static void Main(string[] args)
    {
        FileStream MyFileStream1;
        FileInfo f = new FileInfo(@"C:\TEST\test.txt");

        if (!File.Exists(@"c:\TEST\Testing.txt"))
        {
            MyFileStream1 = new FileStream(@"c:\TEST\Testing.txt", FileMode.Create);
        }
        else
        {
            MyFileStream1 = new FileStream(@"c:\TEST\Testing.txt", FileMode.Open);
        // MyFileStream1 = f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
        }
          

        int NumberOfBytesToWrite = 256;
        byte[] MyWriteByteArray = new Byte[NumberOfBytesToWrite];

        for (int i = 0; i < 256; i++)
        {
            MyWriteByteArray[i] = (byte)i;
            i++;
        }

        MyFileStream1.Write(MyWriteByteArray, 0, NumberOfBytesToWrite);

        MyFileStream1.Close();
    }
}