using System;
using System.IO;
public class MainClass
{
    public static void Main()
    {
        byte[] buf2 = new byte[] { 97, 112, 112, 108, 101, 115, 97, 117, 99, 101 };
        FileStream s = new FileStream("C:\\TEST\\Foo.txt", FileMode.Open);
        Console.WriteLine("Length: {0}, Position: {1}", s.Length, s.Position);
        if (s.CanSeek)
        {
            s.Seek(13, SeekOrigin.Begin);
            Console.WriteLine(
                "Position: {0}", s.Position);
            s.Write(buf2, 0, buf2.Length);
        }
    }
}