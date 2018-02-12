using System;
using System.IO;

static class MainClass
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo("c:\\a");
        Console.WriteLine("Total size: " + CalculateDirectorySize(dir, true).ToString() + " bytes.");

    }

    static long CalculateDirectorySize(DirectoryInfo directory, bool includeSubdirectories)
    {
        long totalSize = 0;

        // Examine all contained files.
        FileInfo[] files = directory.GetFiles();
        foreach (FileInfo file in files)
        {
            totalSize += file.Length;
        }

        // Examine all contained directories.
        if (includeSubdirectories)
        {
            DirectoryInfo[] dirs = directory.GetDirectories();
            foreach (DirectoryInfo dir in dirs)
            {
                totalSize += CalculateDirectorySize(dir, true);
            }
        }

        return totalSize;
    }
}