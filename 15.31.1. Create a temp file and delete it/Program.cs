using System;
using System.IO;

static class MainClass
{
    static void Main()
    {
        string tempFile = Path.GetTempFileName();

        Console.WriteLine("Using " + tempFile);

        using (FileStream fs = new FileStream(tempFile, FileMode.Open))
        {
            // (Write some data.)
        }

        File.Delete(tempFile);

    }
}