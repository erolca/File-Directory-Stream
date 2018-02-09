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

//15.9.1.	FileStream is opened for FileAccess.ReadWrite (default) and FileShare.None (default)

public class MainClass
{
    public static void Main()
    {
        using (FileStream fs1 = File.Open("c:\\TEST\\test.txt", FileMode.Open))
        {

        }

    }
}