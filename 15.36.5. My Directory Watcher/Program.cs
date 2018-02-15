using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        FileSystemWatcher watcher = new FileSystemWatcher();
        watcher.Path = "C:\\";
        watcher.NotifyFilter = NotifyFilters.LastAccess
          | NotifyFilters.LastWrite
          | NotifyFilters.FileName
          | NotifyFilters.DirectoryName;
        watcher.Filter = "*.txt";
        watcher.Changed += new FileSystemEventHandler(OnChanged);
        watcher.Created += new FileSystemEventHandler(OnChanged);
        watcher.Deleted += new FileSystemEventHandler(OnChanged);
        watcher.Renamed += new RenamedEventHandler(OnRenamed);
        watcher.EnableRaisingEvents = true;
        Console.Read();
    }
    static void OnChanged(object source, FileSystemEventArgs e)
    {
        Console.WriteLine("File: {0} {1}!", e.FullPath, e.ChangeType);
    }
    static void OnRenamed(object source, RenamedEventArgs e)
    {
        Console.WriteLine("File: {0} renamed to\n{1}", e.OldFullPath, e.FullPath);
    }
}