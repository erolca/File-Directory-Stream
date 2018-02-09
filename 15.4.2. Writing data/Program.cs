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
using System.Threading;


//15.4.2.	Writing data: copying from one stream to another


public class MainClass
{
    public static void Main()
    {
        using (Stream from = new FileStream("c:\\TEST\\test.txt", FileMode.Open))
        using (Stream to = new FileStream("c:\\TEST\\test2.txt", FileMode.OpenOrCreate))
        {
            int readCount;
            byte[] buffer = new byte[1024];
            while ((readCount = from.Read(buffer, 0, 1024)) != 0)
            {
                to.Write(buffer, 0, readCount);
            }
        }
    }
}