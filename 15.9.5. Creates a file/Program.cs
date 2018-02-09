using System;
using System.IO;


//	15.9.5.	Creates a file with read-write access that allows others to read


public class MainClass
{
    static void Main(string[] args)
    {
        FileStream MyFileStream1 = new FileStream(@"c:\TEST\Testing.txt", FileMode.Create);


        int MyBytes = MyFileStream1.ReadByte();

        MyFileStream1.Close();
    }
}