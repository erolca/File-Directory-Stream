using System;
using System.Diagnostics;


//15.37.3.	FileVersionInfo: IsDebug, IsPatched, IsPreRelease, IsPrivateBuild, IsSpecialBuild


static class MainClass
{
    static void Main(string[] args)
    {

        FileVersionInfo info = FileVersionInfo.GetVersionInfo("c:\\test.txt");

        // Display version information.
        Console.WriteLine("Checking File: " + info.FileName);
        Console.WriteLine("IsDebug: " + info.IsDebug);
        Console.WriteLine("IsPatched: " + info.IsPatched);
        Console.WriteLine("IsPreRelease: " + info.IsPreRelease);
        Console.WriteLine("IsPrivateBuild: " + info.IsPrivateBuild);
        Console.WriteLine("IsSpecialBuild: " + info.IsSpecialBuild);
    }
}
//Checking File: c:\test.txt
//IsDebug: False
//IsPatched: False
//IsPreRelease: False
//IsPrivateBuild: False
//IsSpecialBuild: False