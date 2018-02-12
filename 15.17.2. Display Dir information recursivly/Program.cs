using System;
using System.IO;

public class Dir
{
    DirectoryInfo dirInfo = null;
    [STAThread]
    static void Main(string[] args)
    {
        Dir app = new Dir(Directory.GetCurrentDirectory());
    }

    public Dir(string path)
    {
        dirInfo = new DirectoryInfo(path);
    }
    public void ShowDirInfo()
    {
        Console.WriteLine("Path: {0}", dirInfo.FullName);
        Console.WriteLine("Root: {0}", dirInfo.Root.ToString());
        if (dirInfo.Parent != null) Console.WriteLine("Parent Dir: {0}", dirInfo.Parent.FullName);
        else Console.WriteLine("Parent Dir: None");
        Console.WriteLine("Attributes: {0}", dirInfo.Attributes.ToString());
        Console.WriteLine("Creation Time: {0}", dirInfo.CreationTime.ToString());
        Console.WriteLine("Last Access Time: {0}", dirInfo.LastAccessTime.ToString());
        Console.WriteLine("Last Write Time: {0}", dirInfo.LastWriteTime.ToString());

        Console.WriteLine("Num Subdirectories: {0}", dirInfo.GetDirectories().Length);
        foreach (DirectoryInfo subDir in dirInfo.GetDirectories())
            Console.WriteLine("\t{0}", subDir.Name);

        Console.WriteLine("Num Files: {0}", dirInfo.GetFiles().Length);
        foreach (FileInfo file in dirInfo.GetFiles())
            Console.WriteLine("\t{0}", file.Name);

    }

    public void Show()
    {
        Enumerate(dirInfo);
    }

    private void Enumerate(DirectoryInfo diStart)
    {
        foreach (FileSystemInfo diNext in diStart.GetFileSystemInfos())
        {
            if (diNext.GetType() == typeof(DirectoryInfo))
            {
                Console.WriteLine("< " + diNext.Name + ">");
                Enumerate((DirectoryInfo)diNext);
            }
            else
            {
                Console.WriteLine(diNext.Name);
            }
        }
    }
}