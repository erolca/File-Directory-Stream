using System;
using System.Windows.Forms;
using System.IO;

//15.1.2.	File: GetCreationTime and GetLastAccessTime

class MainClass
{
    [STAThread]
    public static void Main()
    {
        OpenFileDialog dlgOpen = new OpenFileDialog();
        if (dlgOpen.ShowDialog() == DialogResult.OK)
        {
            string s = dlgOpen.FileName;
            Console.WriteLine("Filename " + s);
            Console.WriteLine(" Created at " + File.GetCreationTime(s));
            Console.WriteLine(" Accessed at " + File.GetLastAccessTime(s));
           // Console.WriteLine("Path" +Path.GetTempFileName());
        }

    }

}

//Filename C:\xxxxx\xxxxx\xxx\xxxx.xx
// Created at 27.1.2018 09:39:28
// Accessed at 27.1.2018 09:39:28