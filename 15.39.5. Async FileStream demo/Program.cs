using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("logfile.txt", FileMode.Append, FileAccess.Write, FileShare.None, 4096, true);
        string msg = "this is a test";
        byte[] buffer = Encoding.ASCII.GetBytes(msg);
        fs.BeginWrite(buffer, 0, buffer.Length, new AsyncCallback(WriteDone), fs);
    }

    private static void WriteDone(IAsyncResult ar)
    {
        Stream s = (Stream)ar.AsyncState;
        s.EndWrite(ar);
        s.Close();
    }
}