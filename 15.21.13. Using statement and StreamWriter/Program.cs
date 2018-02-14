using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.Permissions;

[assembly: IsolatedStorageFilePermission(SecurityAction.RequestMinimum, UsageAllowed = IsolatedStorageContainment.AssemblyIsolationByUser)]

public class MainClass
{
    public static void Main()
    {
        using (StreamWriter sw = new StreamWriter(@"C:\TEST\MyData.txt"))
        {
            sw.WriteLine("This is my data.");
            sw.WriteLine("Cool, huh?");
        }
    }
}