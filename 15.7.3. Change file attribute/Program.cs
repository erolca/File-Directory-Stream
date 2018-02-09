using System;
using System.IO;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        if (args[1] == "+r")
        {
            File.SetAttributes(args[0], File.GetAttributes(args[0]) | FileAttributes.ReadOnly);
        }
        else if (args[1] == "-r")
        {
            File.SetAttributes(args[0], File.GetAttributes(args[0]) & (~FileAttributes.ReadOnly));
        }
    }
}