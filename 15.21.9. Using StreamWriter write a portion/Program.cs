using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        StreamWriter MyStreamWriter = new StreamWriter(@"c:\TEST\Testing.txt");

        char[] MyCharArray = new char[100];

        for (int i = 0; i < 99; i++)
        {
            MyCharArray[i] = (char)i;
        }

        MyStreamWriter.Write(MyCharArray, 25, 30);


        MyStreamWriter.Close();
    }
}