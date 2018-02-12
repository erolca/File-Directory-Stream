using System;
using System.IO;

static class MainClass
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo("c:\\TEST");
        FileInfo[] files = dir.GetFiles("*.gif");

        // Display the name of all the files.
        foreach (FileInfo file in files)
        {
            Console.Write("Name: " + file.Name + "  ");
            Console.WriteLine("Size: " + file.Length.ToString());
        }

    }
}