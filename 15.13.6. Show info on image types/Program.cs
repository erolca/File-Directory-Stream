using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\Windows\Web\Wallpaper");
        FileInfo[] imageFiles = dir.GetFiles("*.jpg");
        Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
        foreach (FileInfo f in imageFiles)
        {
            Console.WriteLine("File name: {0}", f.Name);
            Console.WriteLine("File size: {0}", f.Length);
            Console.WriteLine("Creation: {0}", f.CreationTime);
            Console.WriteLine("Attributes: {0}", f.Attributes);
        }
    }
}