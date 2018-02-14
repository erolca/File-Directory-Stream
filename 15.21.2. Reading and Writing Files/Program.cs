using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        FileStream f = new FileStream("c:\\TEST\\output.txt", FileMode.Create);
        StreamWriter s = new StreamWriter(f);

        s.WriteLine("{0} {1}", "test", 55);
        s.Close();
        f.Close();
    }
}