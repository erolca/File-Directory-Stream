using System;
using System.IO;


//15.8.2.	Get FileInfo: file size, file attribute list


class MainClass
{
    public static void Main(string[] args)
    {
        FileInfo file = new FileInfo("c:\\TEST\\test.txt");

        Console.WriteLine("Checking file: " + file.Name);
        Console.WriteLine("File exists: " + file.Exists.ToString());

        if (file.Exists)
        {
            Console.Write("File size (bytes): ");
            Console.WriteLine(file.Length.ToString());
            Console.Write("File attribute list: ");
            Console.WriteLine(file.Attributes.ToString());
        }

    }
}
//Checking file: test.txt
//File exists: True
//File size(bytes) : 0
//File attribute list: Archivet