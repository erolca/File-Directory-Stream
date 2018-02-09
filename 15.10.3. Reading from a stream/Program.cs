using System;
using System.IO;


public class MainClass
{
    public static void Main()
    {
        using (Stream s = new FileStream("c:\\test.txt", FileMode.Open))
        {
            int read;
            while ((read = s.ReadByte()) != -1)
            {
                Console.Write("{0} ", read);
            }
        }
    }
}