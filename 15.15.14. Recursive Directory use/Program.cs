using System;
using System.IO;

class MainClass
{
    public static void ShowDirectory(DirectoryInfo di, int intLevel)
    {
        string strPad = new String(' ', 2 * intLevel);
        Console.WriteLine(strPad + di.Name);

        foreach (DirectoryInfo diChild in di.GetDirectories())
            ShowDirectory(diChild, intLevel + 1);
    }

    public static void Main()
    {
        DirectoryInfo di = new DirectoryInfo("c:\\");
        ShowDirectory(di, 0);
    }
}
