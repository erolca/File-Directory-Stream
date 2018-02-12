using System;
using System.IO;

public class MainClass
{
    static void Main(string[] args)
    {
        DirectoryInfo MyRoot = new DirectoryInfo(@"c:\TEST");
        FileInfo[] MyFiles = MyRoot.GetFiles();
        foreach (FileInfo F in MyFiles)
        {
            Console.WriteLine(F.Name);
        }

    }
}
//Testing.txt