using System;
using System.Windows.Forms;
using System.IO;

//15.19.13.	Use FileStream to read a file byte by byte

class MainClass
{
    public static void Main()
    {
        OpenFileDialog dlgOpen = new OpenFileDialog();
        dlgOpen.Title = "Select file to back up";

        if (dlgOpen.ShowDialog() == DialogResult.OK)
        {
            FileStream inStream = File.OpenRead(dlgOpen.FileName);
            FileStream outStream = File.OpenWrite(dlgOpen.FileName + ".bak");
            int b;

            while ((b = inStream.ReadByte()) > -1)
                outStream.WriteByte((byte)b);

            outStream.Flush();
            outStream.Close();
            inStream.Close();
        }
    }
}