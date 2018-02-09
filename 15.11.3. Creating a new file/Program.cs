
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;


public class MainClass
{
    public static void Main()
    {
        string fileName = "c:\\TEST\\test.txt";
        FileSecurity acl = new FileSecurity();
        acl.AddAccessRule(new FileSystemAccessRule(WindowsIdentity.GetCurrent().Name,
            FileSystemRights.CreateFiles | FileSystemRights.Modify | FileSystemRights.Delete,
            AccessControlType.Allow));
        using (FileStream file = File.Open(fileName, FileMode.OpenOrCreate))
        {

        }
    }
}