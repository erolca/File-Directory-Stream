using System;
using System.IO;

static class MainClass
{
    static void Main(string[] args)
    {
        foreach (DriveInfo drive in DriveInfo.GetDrives())
        {
            try
            {
                Console.WriteLine(
                    "{0} - {1} KB",
                    drive.RootDirectory,
                    drive.AvailableFreeSpace / 1024
                    );
            }
            catch (IOException)
            {
                Console.WriteLine(drive);
            }
        }
    }
}
//C:\ - 32330000 KB
//D:\