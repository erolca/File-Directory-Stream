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
        using (Stream s = new FileStream("c:\\TEST\\test.txt", FileMode.Open))
        {
            s.Seek(8, SeekOrigin.Current);
            Console.WriteLine(s.ReadByte());
            s.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(s.ReadByte());
            s.Seek(-1, SeekOrigin.End);
            Console.WriteLine(s.ReadByte());
        }
    }
}