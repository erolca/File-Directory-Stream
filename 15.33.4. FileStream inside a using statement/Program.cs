﻿using System;
using System.IO;
using System.Text;

public class MainClass
{
    static void Main()
    {
        using (FileStream fs = File.Open("log.txt", FileMode.Append, FileAccess.Write, FileShare.None))
        {
            Byte[] msg = new UTF8Encoding(true).GetBytes("string \n");
            fs.Write(msg, 0, msg.Length);
        }
    }
}