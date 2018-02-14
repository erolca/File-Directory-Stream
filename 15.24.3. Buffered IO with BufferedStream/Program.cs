using System;
using System.IO;

class Tester
{


    public static void Main()
    {
        int SizeBuff = 1024;
        Stream inputStream = File.OpenRead("folder3.cs");
        Stream outputStream = File.OpenWrite("folder3.bak");
        BufferedStream bufferedInput = new BufferedStream(inputStream);
        BufferedStream bufferedOutput = new BufferedStream(outputStream);
        byte[] buffer = new Byte[SizeBuff];
        int bytesRead;

        while ((bytesRead =
        bufferedInput.Read(buffer, 0, SizeBuff)) > 0)
        {
            bufferedOutput.Write(buffer, 0, bytesRead);
        }
        bufferedOutput.Flush();
        bufferedInput.Close();
        bufferedOutput.Close();
    }
}