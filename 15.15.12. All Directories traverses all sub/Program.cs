using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        DirectoryInfo root = new DirectoryInfo(@"C:\Program Files\");

        DirectoryInfo[] dirs = root.GetDirectories("*", SearchOption.TopDirectoryOnly);
        Console.WriteLine("{0} subdirectories:", root.FullName);
        foreach (DirectoryInfo subDir in dirs)
        {
            Console.WriteLine("    {0}", subDir.Name);
        }

    }
}
//C:\Program Files\ subdirectories:
//Adobe
//AMD
//ATI Technologies
//Common Files
//ComPlus Applications
//CONEXANT