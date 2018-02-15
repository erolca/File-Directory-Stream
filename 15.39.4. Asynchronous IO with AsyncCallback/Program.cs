using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class MainClass
{
    static Stream inputStream;
    static AsyncCallback myCallBack;
    static byte[] buffer;
    static int BufferSize = 256;
    public static void Main()
    {
        inputStream = File.OpenRead("AskTim.txt");
        buffer = new byte[BufferSize];
        myCallBack = new AsyncCallback(OnCompletedRead);
        inputStream.BeginRead(
           buffer,             // holds the results
           0,                  // offset
           buffer.Length,      // (BufferSize)
           myCallBack,         // call back delegate
           null);             // local state object
    }
    static void OnCompletedRead(IAsyncResult asyncResult)
    {
        int bytesRead = inputStream.EndRead(asyncResult);
        if (bytesRead > 0)
        {
            String s = Encoding.ASCII.GetString(buffer, 0, bytesRead);
            Console.WriteLine(s);
            inputStream.BeginRead(buffer, 0, buffer.Length, myCallBack, null);
        }
    }
}