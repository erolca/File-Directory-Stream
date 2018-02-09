using System;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Collections.Generic;
using System.Text;


class Program
{
    [FileIOPermission(SecurityAction.Demand, AllLocalFiles = FileIOPermissionAccess.Write)]
    static void Main(string[] args)
    {
        FileStream fs = new FileStream("myfile.txt", FileMode.Create);
        fs.WriteByte(65);
        fs.Close();
    }
}