using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Security;
using System.Security.AccessControl;
using System.Security.Policy;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;

public class MainClass
{
    public static void Main()
    {
        FileSecurity acl = File.GetAccessControl(@"C:\Windows\");
        AuthorizationRuleCollection rules = acl.GetAccessRules(true, true, typeof(NTAccount));
        foreach (AuthorizationRule rule in rules)
        {
            Console.WriteLine(rule.IdentityReference);
            FileSystemAccessRule accessRule = rule as FileSystemAccessRule;
            if (accessRule != null)
                Console.WriteLine("  ...{0}", accessRule.FileSystemRights);
        }
    }
}
//NT AUTHORITY\SYSTEM
//  ...FullControl
//BUILTIN\Administrators
//  ...FullControl
//BUILTIN\Users
//  ...ReadAndExecute, Synchronize