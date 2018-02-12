using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        DirectoryInfo dir = new DirectoryInfo(@"C:\Windows");

        // Dump directory information.
        Console.WriteLine("***** Directory Info *****");
        Console.WriteLine("FullName: {0}", dir.FullName);
        Console.WriteLine("Name: {0}", dir.Name);
        Console.WriteLine("Parent: {0}", dir.Parent);
        Console.WriteLine("Creation: {0}", dir.CreationTime);
        Console.WriteLine("Attributes: {0}", dir.Attributes);
        Console.WriteLine("Root: {0}", dir.Root);

    }
}