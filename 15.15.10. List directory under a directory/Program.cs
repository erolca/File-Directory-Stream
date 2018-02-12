using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        DirectoryInfo MyRoot = new DirectoryInfo(@"c:\TEST");

        DirectoryInfo[] MySub = MyRoot.GetDirectories();
        foreach (DirectoryInfo D in MySub)
        {
            Console.WriteLine(D.Name);

        }

    }
}