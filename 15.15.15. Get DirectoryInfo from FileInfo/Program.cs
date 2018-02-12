using System;
using System.IO;



//15.15.15.	Get DirectoryInfo from FileInfo: name, parent directory name, directory exists


class MainClass
{
    public static void Main(string[] args)
    {
        FileInfo file = new FileInfo("c:\\test.txt");

        // Display directory information.
        DirectoryInfo dir = file.Directory;

        Console.WriteLine("Checking directory: " + dir.Name);
        Console.WriteLine("In directory: " + dir.Parent.Name);
        Console.Write("Directory exists: ");
        Console.WriteLine(dir.Exists.ToString());

    }
}