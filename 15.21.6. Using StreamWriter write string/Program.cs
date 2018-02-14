using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        StreamWriter MyStreamWriter = new StreamWriter(@"c:\TEST\\TestFile.txt");


        string MyString = "Hello World";

        MyStreamWriter.Write(MyString);

        MyStreamWriter.Close();
    }
}