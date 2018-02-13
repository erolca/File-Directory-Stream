using System;
using System.IO;


//15.19.10.	Reset internal position for a FileStream


public class MainClass
{
    public static int Main(string[] args)
    {
        FileInfo f = new FileInfo(@"C:\TEST\test.txt");
        FileStream s = f.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);

        for (int i = 0; i < 256; i++)
        {
            s.WriteByte((byte)i);
        }

        // Reset internal position.
        s.Position = 0;

        for (int i = 0; i < 256; i++)
        {
            Console.Write(s.ReadByte());
        }
        s.Close();
        f.Delete();

        return 0;
    }
}