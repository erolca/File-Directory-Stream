using System;
using System.IO;
using System.Security.Permissions;

[assembly: FileIOPermissionAttribute(SecurityAction.RequestMinimum, All = @"c:\\TEST\\temp")]

class MainClass
{
    public static void Main()
    {
        FileStream fsOut = File.Create(@"c:\\test\\test.txt");
        StreamWriter sw = new StreamWriter(fsOut);
        sw.WriteLine("str");
        sw.Flush();
        sw.Close();
    }
}