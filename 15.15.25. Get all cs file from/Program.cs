using System;
using System.IO;
//15.15.25.	Get all cs file from current directory, display its creation time, length, name


class Dir
{
    public static void Main()
    {
        FileInfo[] files = new DirectoryInfo(Environment.CurrentDirectory).GetFiles("*.cs");
        foreach (FileInfo file in files)
        {
            Console.WriteLine("{0}\t{1}\t\t{2}",
              file.CreationTime, file.Length, file.Name);
        }
    }
}