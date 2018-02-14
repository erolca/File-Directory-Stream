using System;
using System.IO;

public class MainClass
{
    public static int Main(string[] args)
    {

        FileStream dumpFile = new FileStream("c:\\TEST\\Dump.dat", FileMode.Create, FileAccess.ReadWrite);
        BufferedStream myFileBuffer = new BufferedStream(dumpFile);

        byte[] str = { 127, 0x77, 0x4, 0x0, 0x0, 0x16 };
        myFileBuffer.Write(str, 0, str.Length);

        // add changes to file.
        myFileBuffer.Close();  // Flushes.
        dumpFile.Close();  // Flushes.

        return 0;
    }
}