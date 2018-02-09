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


//15.9.2.	FileStream is opened for FileAccess.Write FileShare.None (default) and is positioned at the end (because of FileMode.Append)

public class MainClass
{
    public static void Main()
    {
        using (FileStream fs2 = File.Open("c:\\test.txt", FileMode.Append, FileAccess.Write))
        {

        }

    }
}