﻿using System;
using System.IO;

public sealed class MainClass
{
    static void Main()
    {
        using (StreamWriter sw = new StreamWriter("Output.txt"))
        {
            sw.WriteLine("This is a test of the emergency dispose mechanism");
        }
    }
}