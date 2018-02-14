using System;
using System.IO;

class MainClass
{
    public static void Main(string[] args)
    {
        try
        {
            StreamReader sr = File.OpenText("c:\\boot.ini");
            string strLine;
            while (null != (strLine = sr.ReadLine()))
            {
                Console.WriteLine(strLine);
            }
            sr.Close();
        }
        catch (FileNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
//[boot loader]
//timeout=30
//default=multi(0)disk(0)rdisk(0)partition(1)\WINDOWS
//[operating systems]
//multi(0)disk(0)rdisk(0)partition(1)\WINDOWS="Microsoft Windows XP Home Edition" /noexecute=optin /fa
//stdetect