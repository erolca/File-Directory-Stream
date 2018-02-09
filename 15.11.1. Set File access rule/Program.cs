using System;
using System.IO;
using System.Security.AccessControl;

static class MainClass
{
    static void Main(string[] args)
    {
        FileStream stream = null;
        string fileName = "c:\\TEST\\test.txt";

        // Deny 'Everyone' access to the file
        FileSecurity fSecurity = File.GetAccessControl(fileName);
        fSecurity.ResetAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.Read, AccessControlType.Deny));
        File.SetAccessControl(fileName, fSecurity);

        // Attempt to access file.
        try
        {
            stream = new FileStream(fileName, FileMode.Create);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception thrown: ");
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            stream.Close();
            stream.Dispose();
        }
    }
}