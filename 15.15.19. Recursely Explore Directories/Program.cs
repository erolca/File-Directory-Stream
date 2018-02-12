using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

class Tester
{
    public static void Main()
    {
        ExploreDirectory(new DirectoryInfo("c:\\TEST"));
    }
    private static void ExploreDirectory(DirectoryInfo dir)
    {
        Console.WriteLine("[{0}] {1} \n", dir.Name, dir.LastAccessTime);
        DirectoryInfo[] directories = dir.GetDirectories();

        foreach (DirectoryInfo newDir in directories)
        {
            ExploreDirectory(newDir);
        }
    }
}