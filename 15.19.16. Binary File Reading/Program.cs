using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

//15.19.16.	Binary File Reading through FileStream

public class MainClass
{
    public static void Main()
    {
        int nCols = 16;
        FileStream inStream = new FileStream("c:\\TEST\\a.txt", FileMode.Open, FileAccess.Read);
        long nBytesToRead = inStream.Length;
        if (nBytesToRead > 65536 / 4)
            nBytesToRead = 65536 / 4;
        int nLines = (int)(nBytesToRead / nCols) + 1;
        string[] lines = new string[nLines];
        int nBytesRead = 0;
        for (int i = 0; i < nLines; i++)
        {
            StringBuilder nextLine = new StringBuilder();
            nextLine.Capacity = 4 * nCols;
            for (int j = 0; j < nCols; j++)
            {
                int nextByte = inStream.ReadByte();
                nBytesRead++;
                if (nextByte < 0 || nBytesRead > 65536)
                    break;
                char nextChar = (char)nextByte;
                if (nextChar < 16)
                    nextLine.Append(" x0" + string.Format("{0,1:X}", (int)nextChar));
                else if
                    (char.IsLetterOrDigit(nextChar) || char.IsPunctuation(nextChar))
                    nextLine.Append("  " + nextChar + " ");
                else
                    nextLine.Append(" x" + string.Format("{0,2:X}", (int)nextChar));
            }
        }
        inStream.Close();


    }
}