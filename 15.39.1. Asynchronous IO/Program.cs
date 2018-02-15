using System;
using System.IO;
using System.Windows.Forms;

class MainClass
{
    private static FileStream inStream;

    static void OnComplete(IAsyncResult asyncResult)
    {
        int bytesRead = inStream.EndRead(asyncResult);
        Console.Write(bytesRead);
    }

    public static void Main()
    {
        inStream = new FileStream("text.txt", FileMode.Open, FileAccess.Read, FileShare.None, 2048, true);

        AsyncCallback acb = new AsyncCallback(OnComplete);

        byte[] buf = new byte[50];

        inStream.BeginRead(buf, 0, 50, acb, null);

        for (int i = 0; i < 10; i++)
            Console.WriteLine(i);

        Console.WriteLine("Press Enter to exit");
        int resp = Console.Read();
    }
}