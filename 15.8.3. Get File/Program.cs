using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class MainClass
{
    static void Main(string[] args)
    {
        string[] files = Directory.GetFiles(@"c:\");
        foreach (string filename in files)
        {
            FileInfo file = new FileInfo(filename);
            Console.WriteLine("{0} created on {1}, and is a {2} file",
                file.Name, file.CreationTime,
                file.Extension);
        }
    }
}
//bootmgr created on 22.8.2013 18:44:03, and is a file
//BOOTNXT created on 22.8.2013 18:44:04, and is a file
//hiberfil.sys created on 21.4.2017 13:43:29, and is a.sys file
//pagefile.sys created on 21.4.2017 10:49:49, and is a.sys file
//swapfile.sys created on 21.4.2017 10:49:49, and is a.sys file