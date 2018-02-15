using System;
using System.Diagnostics;


//15.37.2.	FileVersionInfo: Version, Description, Original Filename, Legal Copyright, InternalName


static class MainClass
{
    static void Main(string[] args)
    {

        FileVersionInfo info = FileVersionInfo.GetVersionInfo("c:\\test.txt");

        // Display version information.
        Console.WriteLine("Checking File: " + info.FileName);
        Console.WriteLine("File Version: " + info.FileVersion);
        Console.WriteLine("File Description: " + info.FileDescription);
        Console.WriteLine("Original Filename: " + info.OriginalFilename);
        Console.WriteLine("Legal Copyright: " + info.LegalCopyright);
        Console.WriteLine("InternalName: " + info.InternalName);

    }
}
//Checking File: c:\test.txt
//File Version:
//File Description:
//Original Filename:
//Legal Copyright:
//InternalName: