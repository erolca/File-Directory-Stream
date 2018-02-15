using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        using (Stream s = new FileStream("test.txt", FileMode.Open))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            do
            {
                IAsyncResult ar = s.BeginRead(buffer, 0, buffer.Length, null, null);
                bytesRead = s.EndRead(ar);

            }
            while (bytesRead == buffer.Length);
        }
    }
}