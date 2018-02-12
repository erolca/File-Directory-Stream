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
            int read;
            while ((read = s.ReadByte()) != -1)
            {
                Console.Write("{0} ", (char)read);
            }
        }
    }
}