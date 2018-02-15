using System;
using System.IO;

class MainClass
{

    public static void SaveMemoryStream(MemoryStream ms, string FileName)
    {
        FileStream outStream = File.OpenWrite(FileName);
        ms.WriteTo(outStream);
        outStream.Flush();
        outStream.Close();
    }

    public static void Main()
    {
        FileStream inStream = File.OpenRead("c:\\TEST\\text.txt");
        MemoryStream storeStream = new MemoryStream();

        storeStream.SetLength(inStream.Length);
        inStream.Read(storeStream.GetBuffer(), 0, (int)inStream.Length);

        storeStream.Flush();
        inStream.Close();

        SaveMemoryStream(storeStream, "C:\\TEST\\text.txt" + ".bak");
        storeStream.Close();
    }
}