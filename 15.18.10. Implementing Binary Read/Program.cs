using System;
using System.IO;


class Tester
{
    public static void Main()
    {
        int SizeBuff = 1024;
        Stream inputStream = File.OpenRead("c:\\TEST\\test.txt");
        Stream outputStream = File.OpenWrite("c:\\TEST\\test.bak");
        byte[] buffer = new Byte[SizeBuff];
        int bytesRead;
        while ((bytesRead =
        inputStream.Read(buffer, 0, SizeBuff)) > 0)
        {
            outputStream.Write(buffer, 0, bytesRead);
        }
        inputStream.Close();
        outputStream.Close();
    }
}