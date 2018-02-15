using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Permissions;

[assembly: IsolatedStorageFilePermission(SecurityAction.RequestMinimum, UsageAllowed = IsolatedStorageContainment.AssemblyIsolationByUser)]
public class MainClass
{
    public static void Main()
    {
        using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
        {
            using (IsolatedStorageFileStream isStream = new IsolatedStorageFileStream("MyData.txt", FileMode.OpenOrCreate, store))
            {
                using (StreamWriter sw = new StreamWriter(isStream))
                {
                    sw.WriteLine("This is my data.");
                    sw.WriteLine("Cool, huh?");
                }
            }
        }
    }
}