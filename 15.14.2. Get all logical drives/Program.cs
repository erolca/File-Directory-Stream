using System;
using System.IO;

class MaionClass
{
    public static void Main(String[] args)
    {
        string[] drives = Directory.GetLogicalDrives();
        Console.WriteLine("Here are your drives:");
        foreach (string s in drives)
        {
            Console.WriteLine("--> {0}", s);
        }

    }
}
//Here are your drives:
//--> C:\
//--> D:\