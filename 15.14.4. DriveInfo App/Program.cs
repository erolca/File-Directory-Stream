using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        DriveInfo[] myDrives = DriveInfo.GetDrives();
        foreach (DriveInfo d in myDrives)
        {
            Console.WriteLine("Name: {0}", d.Name);
            Console.WriteLine("Type: {0}", d.DriveType);
            if (d.IsReady)
            {
                Console.WriteLine("Free space: {0}", d.TotalFreeSpace);
                Console.WriteLine("Format: {0}", d.DriveFormat);
                Console.WriteLine("Label: {0}", d.VolumeLabel);
            }
        }
    }
}

//Name: C:\
//Type: Fixed
//Free space: 123850268672
//Format: NTFS
//Label:
//Name: D:\
//Type: Fixed
//Free space: 209964027904
//Format: NTFS
//Label: Yeni Birim
//Name: E:\
//Type: CDRom