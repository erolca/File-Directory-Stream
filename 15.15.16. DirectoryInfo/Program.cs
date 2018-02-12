using System;
using System.IO;


//	15.15.16.	DirectoryInfo: creation time, last write time, last access time


class MainClass
{
    public static void Main(string[] args)
    {
        FileInfo file = new FileInfo("c:\\TEST\\test.txt");
        // Display directory information.
        DirectoryInfo dir = file.Directory;

        if (dir.Exists)
        {
            Console.Write("Directory created: ");
            Console.WriteLine(dir.CreationTime.ToString());
            Console.Write("Directory last updated: ");
            Console.WriteLine(dir.LastWriteTime.ToString());
            Console.Write("Directory last accessed: ");
            Console.WriteLine(dir.LastAccessTime.ToString());
        }

    }
}
//Directory created: 27/08/2006 3:07:02 PM
//Directory last updated: 25/03/2007 2:04:08 PM
//Directory last accessed: 25/03/2007 2:11:11 PM