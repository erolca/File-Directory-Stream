using System;
using System.IO;

class Tester
{
    public static void Main()
    {
        FileInfo theSourceFile = new FileInfo("test.cs");
        StreamReader reader = theSourceFile.OpenText();
        StreamWriter writer = new StreamWriter("test.bak", false);
        string text;
        do
        {
            text = reader.ReadLine();
            writer.WriteLine(text);
            Console.WriteLine(text);
        } while (text != null);
        reader.Close();
        writer.Close();
    }
}