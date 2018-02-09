using System;
using System.IO;


//15.8.1.	Get FileInfo: file name, file exists, creation time, last write time, last access time


class MainClass
{
    public static void Main(string[] args)
    {
        FileInfo file = new FileInfo("c:\\TEST\\test.txt");

        Console.WriteLine("Checking file: " + file.Name);
        Console.WriteLine("File exists: " + file.Exists.ToString());

        if (file.Exists)
        {
            Console.Write("File created: ");
            Console.WriteLine(file.CreationTime.ToString());
            Console.Write("File last updated: ");
            Console.WriteLine(file.LastWriteTime.ToString());
            Console.Write("File last accessed: ");
            Console.WriteLine(file.LastAccessTime.ToString());
        }

    }
}
//Checking file: test.txt
//File exists: True
//File created: 27.11.2017 13:31:35
//File last updated: 9.2.2018 12:07:14
//File last accessed: 27.11.2017 13:31:35











