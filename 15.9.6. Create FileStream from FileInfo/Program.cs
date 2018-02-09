using System;
using System.IO;


//15.9.6.	Create FileStream from FileInfo with file mode, file access and file sharing


public class MainClass
{
    static void Main(string[] args)
    {

        FileInfo MyFiles = new FileInfo(@"c:\TEST\Testing.txt");
        FileStream MyFileStream1 = MyFiles.Open(FileMode.Append, FileAccess.Read, FileShare.None);

        int MyBytes = MyFileStream1.ReadByte();

        MyFileStream1.Close();
    }
}