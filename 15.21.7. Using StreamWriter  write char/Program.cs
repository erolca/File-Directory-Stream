using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        StreamWriter MyStreamWriter = new StreamWriter(@"c:\TEST\Testing.txt");

        //Writes single characters to a stream
        char MyChar = 'A';

        MyStreamWriter.Write(MyChar);

        MyStreamWriter.Close();
    }
}