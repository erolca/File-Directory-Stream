using System;
using System.IO;

//15.9.4.	Use FileStream with StreamWriter to provide a greater degree of control in how you open the file


public class MainClass
{
    static void Main(string[] args)
    {
        FileStream MyFileStream = new FileStream(@"c:\TEST\Testing.txt", FileMode.CreateNew, FileAccess.Write, FileShare.None);

        StreamWriter MyStreamWriter = new StreamWriter(MyFileStream);

        MyStreamWriter.Write("a string");

        MyFileStream.Close();
        MyStreamWriter.Close();

    }
}