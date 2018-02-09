using System;
using System.IO;
using System.Security.Permissions;

[assembly: PermissionSetAttribute(SecurityAction.RequestMinimum, Name = "FullTrust")]

class MainClass
{
    public static void Main()
    {
        FileStream fsOut = File.Create(@"c:\\TEST\\test.txt");
        StreamWriter sw = new StreamWriter(fsOut);
        sw.WriteLine("str");
        sw.Flush();
        sw.Close();
    }
}