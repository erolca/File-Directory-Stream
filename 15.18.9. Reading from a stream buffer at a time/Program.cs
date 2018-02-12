using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

public class MainClass
{
    public static void Main()
    {
        using (Stream s = new FileStream("c:\\TEST\\test.txt", FileMode.Open))
        {
            int readCount;
            byte[] buffer = new byte[4096];
            while ((readCount = s.Read(buffer, 0, buffer.Length)) != 0)
            {
                for (int i = 0; i < readCount; i++)
                {
                    Console.Write("{0} ", buffer[i]);
                }
            }
        }
    }
}