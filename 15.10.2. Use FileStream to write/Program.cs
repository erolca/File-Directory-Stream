using System;
using System.IO;

//15.10.2.	Use FileStream to write a file by byte array

class MainClass
{
    public static void Main()
    {
        FileStream inStream = File.OpenRead("C:\\test.txt");
        FileStream outStream = File.OpenWrite("C:\\test.txt" + ".bak");
        byte[] buf = new byte[4096];
        int bytesRead;

        while ((bytesRead = inStream.Read(buf, 0, 4096)) > 0)
            outStream.Write(buf, 0, bytesRead);

        outStream.Flush();
        outStream.Close();
        inStream.Close();

    }
}