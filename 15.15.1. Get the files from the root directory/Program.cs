using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        string[] aFiles = Directory.GetFiles("c:\\");

        foreach (string s in aFiles)
            Console.WriteLine(s);
    }

}
//c:\AUTOEXEC.BAT
//c:\boot.ini
//c:\CONFIG.SYS
//c:\hiberfil.sys
//c:\initest.ini
//c:\IO.SYS
//c:\MSDOS.SYS
//c:\myfile.txt
//c:\NTDETECT.COM
//c:\ntldr
//c:\pagefile.sys
//c:\records.bin
//c:\Test.txt
//c:\test.xml
//c:\Testing.txt
//c:\xmlWriterTest.xml