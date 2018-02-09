using System;
using System.Windows.Forms;
using System.IO;

//15.1.3.	Create the FileInfo class from the file selected in the OpenFileDialog
//Provides instance methods for the creation, copying, deletion, moving, and opening of files, 
//and aids in the creation of FileStream objects. This class cannot be inherited.

class MainClass
{

    [STAThread]
    public static void Main()
    {
        OpenFileDialog dlgOpen = new OpenFileDialog();
        if (dlgOpen.ShowDialog() == DialogResult.OK)
        {
            FileInfo fi = new FileInfo(dlgOpen.FileName);
            Console.WriteLine("Filename " + fi.FullName);
            Console.WriteLine(" Created at " + fi.CreationTime);
            Console.WriteLine(" Accessed at " + fi.LastAccessTime);
        }
    }
}