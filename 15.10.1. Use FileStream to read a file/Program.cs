using System;
using System.Windows.Forms;
using System.IO;


//15.10.1.	Use FileStream to read a file by byte array


class MainClass
{
    public static void Main()
    {
        FileStream inStream = File.OpenRead("C:\\TEST\\test.txt");
        FileStream outStream = File.OpenWrite("C:\\TEST\\test.txt" + ".bak");
        byte[] buf = new byte[4096];
        int bytesRead;

        while ((bytesRead = inStream.Read(buf, 0, 4096)) > 0)
            outStream.Write(buf, 0, bytesRead);

        outStream.Flush();
        outStream.Close();
        inStream.Close();

    }
}