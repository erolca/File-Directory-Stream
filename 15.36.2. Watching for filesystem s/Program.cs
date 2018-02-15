using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;


//15.36.2.	Watching for filesystem updates synchronous

public class MainClass
{
    public static void Main()
    {
        FileSystemWatcher watcher = new FileSystemWatcher(@"c:\", "*.*");
        // only rename event
        WaitForChangedResult result = watcher.WaitForChanged(WatcherChangeTypes.Changed | WatcherChangeTypes.Renamed);

        switch (result.ChangeType)
        {
            case WatcherChangeTypes.Changed:
                Console.WriteLine("{0}: File '{1}' was changed", DateTime.Now, result.Name);
                break;
            case WatcherChangeTypes.Renamed:
                Console.WriteLine("{0}: File '{1}' was renamed to '{2}'", DateTime.Now, result.OldName, result.Name);
                break;
        }
    }
}