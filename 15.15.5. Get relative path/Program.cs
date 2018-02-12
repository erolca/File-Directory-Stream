using System;
using System.IO;



//Path.GetFullPath 
//Mutlak yolu için belirtilen yol dizesini döndürür.

static class MainClass
{
    static void Main()
    {
        Console.WriteLine("The relative path 'file.txt' " + Path.GetFullPath("file.txt"));


        string fileName = "test.txt";
        string path1 = @"mydir";
        string path2 = @"\Test";
        string fullPath;

        fullPath = Path.GetFullPath(path1);
        Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            path1, fullPath);

        fullPath = Path.GetFullPath(fileName);
        Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            fileName, fullPath);

        fullPath = Path.GetFullPath(path2);
        Console.WriteLine("GetFullPath('{0}') returns '{1}'",
            path2, fullPath);

    }
}
//c:\file.txt