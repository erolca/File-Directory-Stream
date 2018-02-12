using System;
using System.IO;


//	15.15.9.	Use DirectoryInfo to create sub directory

public class MainClass
{
    static void Main(string[] args)
    {
        DirectoryInfo MyRoot = new DirectoryInfo(@"c:\TEST");
        MyRoot.CreateSubdirectory("MyFolder");
    }
}