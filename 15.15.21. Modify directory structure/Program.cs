using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(".");

        // Create \MyFolder off initial directory.
        dir.CreateSubdirectory("TEST");

        // Capture returned DirectoryInfo object.
        DirectoryInfo myDataFolder = dir.CreateSubdirectory(@"TEST2\Data");

        // Prints path to ..\MyFolder2\Data.
        Console.WriteLine("New Folder is: {0}", myDataFolder);
    }
}