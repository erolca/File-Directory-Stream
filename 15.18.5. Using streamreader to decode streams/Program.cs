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

public class MainClass
{
    public static void Main()
    {
        Stream s = new FileStream("c:\\TEST\\test.txt", FileMode.Open);
        using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
        {
            int readCount;
            char[] buffer = new char[1024];
            while ((readCount = sr.Read(buffer, 0, 1024)) != 0)
            {
                for (int i = 0; i < readCount; i++)
                {
                    Console.Write("{0} ", buffer[i]);
                }
            }
        }
    }
}