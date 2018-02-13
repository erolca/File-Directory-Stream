using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileStream MyFileStream = new FileStream(@"c:\TEST\Testing.txt", FileMode.Open, FileAccess.Read, FileShare.None);

        StreamReader MyStreamReader = new StreamReader(MyFileStream);


        for (int i = 0; i < 99; i++)
        {
            int ch = MyStreamReader.Read();
            Console.WriteLine(ch);

        }

        MyStreamReader.Close();
    }
}