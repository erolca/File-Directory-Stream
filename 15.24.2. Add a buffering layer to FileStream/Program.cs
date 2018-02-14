using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        FileStream inStream = File.OpenRead("c:\\TEST\\textfile.txt");
        FileStream outStream = File.OpenWrite("c:\\TEST\\textfile.txt" + ".bak");


        BufferedStream bufInStream = new BufferedStream(inStream);
        BufferedStream bufOutStream = new BufferedStream(outStream);

        byte[] buf = new byte[1024];
        int bytesRead;

        while ((bytesRead = bufInStream.Read(buf, 0, 1024)) > 0)
            bufOutStream.Write(buf, 0, bytesRead);

        bufOutStream.Flush();
        bufOutStream.Close();
        bufInStream.Close();
        outStream.Close();
        inStream.Close();
    }
}
