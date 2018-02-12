using System;
using System.IO;
using System.Collections;

//15.15.26.	Use the GetFiles method to return file names from a user-specified location.,

public class RecursiveFileProcessor
{
    public static void Main(string[] args)
    {
        String path = "c:\\";
        if (File.Exists(path))
        {
            ProcessFile(path);
        }
        else if (Directory.Exists(path))
        {
            ProcessDirectory(path);
        }
        else
        {
            Console.WriteLine("{0} is not a valid file or directory.", path);
        }
    }
    public static void ProcessDirectory(string targetDirectory)
    {
        string[] fileEntries = Directory.GetFiles(targetDirectory);
        foreach (string fileName in fileEntries)
            ProcessFile(fileName);

        string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
        foreach (string subdirectory in subdirectoryEntries)
            ProcessDirectory(subdirectory);
    }

    public static void ProcessFile(string path)
    {
        Console.WriteLine("Processed file '{0}'.", path);
    }
}