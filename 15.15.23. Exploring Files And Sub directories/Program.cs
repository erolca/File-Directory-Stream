using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Tester
{
    static int dirCounter = 1;
    static int fileCounter = 0;

    public static void Main()
    {
        ExploreDirectory(new DirectoryInfo("c:\\"));
    }
    static void ExploreDirectory(DirectoryInfo dir)
    {
        FileInfo[] filesInDir = dir.GetFiles();
        foreach (FileInfo file in filesInDir)
        {
            Console.WriteLine("{0} [{1}] Size: {2} bytes",
               file.Name,
               file.LastWriteTime,
               file.Length);

            fileCounter++;
        }
        DirectoryInfo[] directories = dir.GetDirectories();
        foreach (DirectoryInfo newDir in directories)
        {
            dirCounter++;  // increment the counter
            ExploreDirectory(newDir);
        }
    }
}