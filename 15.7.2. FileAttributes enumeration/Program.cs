using System;
using System.Windows.Forms;
using System.IO;

class MainClass
{
    public static void DecipherAttributes(FileAttributes f)
    {
        if ((f & FileAttributes.Archive) == FileAttributes.Archive)
            Console.WriteLine("Archive");
        if ((f & FileAttributes.Compressed) == FileAttributes.Compressed)
            Console.WriteLine("Compressed");
        if ((f & FileAttributes.Device) == FileAttributes.Device)
            Console.WriteLine("Device");
        if ((f & FileAttributes.Directory) == FileAttributes.Directory)
            Console.WriteLine("Directory");
        if ((f & FileAttributes.Encrypted) == FileAttributes.Encrypted)
            Console.WriteLine("Encrypted");
        if ((f & FileAttributes.Hidden) == FileAttributes.Hidden)
            Console.WriteLine("Hidden");
        if ((f & FileAttributes.NotContentIndexed) == FileAttributes.NotContentIndexed)
            Console.WriteLine("NotContentIndexed");
        if ((f & FileAttributes.Offline) == FileAttributes.Offline)
            Console.WriteLine("Offline");
        if ((f & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            Console.WriteLine("ReadOnly");
        if ((f & FileAttributes.ReparsePoint) == FileAttributes.ReparsePoint)
            Console.WriteLine("ReparsePoint");
        if ((f & FileAttributes.SparseFile) == FileAttributes.SparseFile)
            Console.WriteLine("SparseFile");
        if ((f & FileAttributes.System) == FileAttributes.System)
            Console.WriteLine("System");
        if ((f & FileAttributes.Temporary) == FileAttributes.Temporary)
            Console.WriteLine("Temporary");
    }

    [STAThread]
    public static void Main()
    {
        OpenFileDialog dlgOpen = new OpenFileDialog();
        if (dlgOpen.ShowDialog() == DialogResult.OK)
        {
            FileAttributes f = File.GetAttributes(dlgOpen.FileName);
            Console.WriteLine("Filename " + dlgOpen.FileName + " has attributes:");
            DecipherAttributes(f);
        }
    }
}