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


//15.9.3.FileStream is opened for FileAccess.ReadWrite FileShare.Read and has had its entire contents truncated (due to FileMode.Truncate)


public class MainClass
{
    public static void Main()
    {
        using (FileStream fs3 = File.Open("c:\\test.txt", FileMode.Truncate, FileAccess.ReadWrite, FileShare.Read))
        {

        }

    }
}