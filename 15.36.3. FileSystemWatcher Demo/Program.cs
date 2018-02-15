using System;
using System.IO;

public class MainClass
{
    public static void Main(string[] args)
    {
        FileSystemWatcher watcher = new FileSystemWatcher();
        watcher.Path = @"c:\Test";
        watcher.NotifyFilter = NotifyFilters.LastAccess |
                                NotifyFilters.LastWrite |
                                NotifyFilters.FileName |
                                NotifyFilters.DirectoryName;
        watcher.Filter = "*.txt";
        watcher.Changed += new FileSystemEventHandler(OnChanged);
        watcher.Created += new FileSystemEventHandler(OnChanged);
        watcher.Deleted += new FileSystemEventHandler(OnChanged);
        watcher.Renamed += new RenamedEventHandler(OnRenamed);
        watcher.EnableRaisingEvents = true;

    }

    public static void OnChanged(object source, FileSystemEventArgs e)
    {
        Console.WriteLine("Event Fired");
    }
    public static void OnRenamed(object source, RenamedEventArgs e)
    {
        Console.WriteLine("Event Fired");
    }

}