using System;
using System.Security;
using System.Security.Permissions;


public class MainClass
{
    public static void Main()
    {
        NamedPermissionSet ps = new NamedPermissionSet("SamplePermissionSet", PermissionState.None);
        ps.AddPermission(new FileIOPermission(FileIOPermissionAccess.AllAccess, @"C:\test\"));
        ps.AddPermission(new ReflectionPermission(PermissionState.Unrestricted));
        ps.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));

        Console.WriteLine(ps.ToXml().ToString());
    }
}