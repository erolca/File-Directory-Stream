using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        FileInfo MyFile = new FileInfo(@"c:\Testing.txt");

        MyFile.Create();
        MyFile.MoveTo(@"c:\MyFolder\Moved Testing.txt");
        MyFile.MoveTo(@"C:\MyFolderNew");
    }
}