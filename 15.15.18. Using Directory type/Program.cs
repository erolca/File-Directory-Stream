using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        string[] drives = Directory.GetLogicalDrives();
        foreach (string s in drives)
            Console.WriteLine("--> {0} ", s);

        try
        {
            Directory.Delete(string.Format(@"{0}\MyFolder", Environment.CurrentDirectory));
            Directory.Delete(string.Format(@"{0}\MyFolder2", Environment.CurrentDirectory), true);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}