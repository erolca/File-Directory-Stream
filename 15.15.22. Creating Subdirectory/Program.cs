using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


//15.15.22.	Creating Subdirectory and Manipulating File


class Tester
{
    public static void Main()
    {
        ExploreDirectory(new DirectoryInfo("c:\\"));
    }
    private static void ExploreDirectory(DirectoryInfo dir)
    {
        string newDirectory = "newTest";
        DirectoryInfo newSubDir = dir.CreateSubdirectory(newDirectory);
        FileInfo[] filesInDir = dir.GetFiles();
        foreach (FileInfo file in filesInDir)
        {
            string fullName = newSubDir.FullName + "\\" + file.Name;
            file.CopyTo(fullName);
            Console.WriteLine(file.FullName);
        }
        filesInDir = newSubDir.GetFiles();
        int counter = 0;
        foreach (FileInfo file in filesInDir)
        {
            string fullName = file.FullName;
            file.MoveTo(fullName + ".bak");
            Console.WriteLine("{0} renamed to {1}", fullName, file.FullName);
        }
        newSubDir.Delete(true);
    }
}