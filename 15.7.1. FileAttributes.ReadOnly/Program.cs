using System;
using System.IO;

static class MainClass
{
    static void Main()
    {
        FileInfo file = new FileInfo("data.txt");

        Console.WriteLine(file.Attributes.ToString());

        // This test fails, because other attributes are set.
        if (file.Attributes == FileAttributes.ReadOnly)
        {
            Console.WriteLine("File is read-only (faulty test).");
        }

        if ((file.Attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
        {
            Console.WriteLine("File is read-only (correct test).");
        }
    }
}
//Archive, NotContentIndexed