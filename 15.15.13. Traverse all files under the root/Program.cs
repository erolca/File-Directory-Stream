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
        FileInfo[] files = root.GetFiles();
        Console.WriteLine("files:");
        foreach (FileInfo file in files)
        {
            Console.WriteLine("    {0} ({1} bytes)", file.Name, file.Length);
        }

    }
}
//C:\Program Files\ subdirectories:
//files:
//    desktop.ini(174 bytes)