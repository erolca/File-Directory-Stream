using System;
using System.IO;
using System.Windows.Forms;



//15.36.1.	Use FileSystemWatcher to detect file changes


static class MainClass
{
    static void Main()
    {
        using (FileSystemWatcher watch = new FileSystemWatcher())
        {
            watch.Path = Application.StartupPath;
            watch.Filter = "*.*";
            watch.IncludeSubdirectories = true;

            watch.Created += new FileSystemEventHandler(OnCreatedOrDeleted);
            watch.Deleted += new FileSystemEventHandler(OnCreatedOrDeleted);
            watch.EnableRaisingEvents = true;

            if (File.Exists("test.bin"))
            {
                File.Delete("test.bin");
            }

            using (FileStream fs = new FileStream("test.bin", FileMode.Create))
            {
            }
        }
    }

    private static void OnCreatedOrDeleted(object sender, FileSystemEventArgs e)
    {
        Console.WriteLine("\tNOTIFICATION: " + e.FullPath + "' was " + e.ChangeType.ToString());
    }
}
//NOTIFICATION: C:\Java_Dev\WEB\dev\CSharp\test.bin' was Deleted