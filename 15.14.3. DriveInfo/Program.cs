using System;
using System.IO;


//15.14.3.	DriveInfo: name, type, format and available free space

static class MainClass
{
    static void Main(string[] args)
    {
        FileInfo file = new FileInfo("c:\\test.txt");

        // Display drive information.
        DriveInfo drv = new DriveInfo(file.FullName);

        Console.Write("Drive: ");
        Console.WriteLine(drv.Name);

        if (drv.IsReady)
        {
            Console.Write("Drive type: ");
            Console.WriteLine(drv.DriveType.ToString());
            Console.Write("Drive format: ");
            Console.WriteLine(drv.DriveFormat.ToString());
            Console.Write("Drive free space: ");
            Console.WriteLine(drv.AvailableFreeSpace.ToString());
        }

    }
}
//Drive: c:\
//Drive type: Fixed
//Drive format: NTFS
//Drive free space: 33105936384