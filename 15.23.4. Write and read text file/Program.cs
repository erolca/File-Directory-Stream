using System;
using System.IO;

public class MainClass
{
    public static int Main(string[] args)
    {
        FileInfo f = new FileInfo("C:\\TEST\\testfile.txt");

        StreamWriter writer = f.CreateText();
        writer.WriteLine("string 1");
        writer.WriteLine("string 2");

        for (int i = 0; i < 10; i++)
        {
            writer.Write(i + " ");
        }
        writer.Write(writer.NewLine);

        writer.Close();

        // Now read it all back in.
        StreamReader sr = File.OpenText("C:\\TEST\\testfile.txt");

        string input = null;
        while ((input = sr.ReadLine()) != null)
        {
            Console.WriteLine(input);
        }

        return 0;
    }
}
//string 1
//string 2
//0 1 2 3 4 5 6 7 8 9