using System;
using System.IO;

class MaionClass
{
    public static void Main(String[] args)
    {
        try
        {
            Directory.Delete(@"C:\WinNT\MyFoo");
            Directory.Delete(@"C:\WinNT\MyBar", true);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}