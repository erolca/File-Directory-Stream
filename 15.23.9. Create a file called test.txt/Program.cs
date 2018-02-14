using System;
using System.IO;

class Program
{
    static void Main()
    {
        using (Stream s = new FileStream("test.txt", FileMode.Create))
        {
            Console.WriteLine(s.CanRead);       // true
            Console.WriteLine(s.CanWrite);      // true
            Console.WriteLine(s.CanSeek);       // true

            s.WriteByte(101);
            s.WriteByte(102);
            byte[] block = { 1, 2, 3, 4, 5 };
            s.Write(block, 0, block.Length);     // Write block of 5 bytes

            Console.WriteLine(s.Length);         // 7
            Console.WriteLine(s.Position);       // 7
            s.Position = 0;                       // Move back to the start

            Console.WriteLine(s.ReadByte());     // 101
            Console.WriteLine(s.ReadByte());     // 102

            Console.WriteLine(s.Read(block, 0, block.Length));   // 5

            Console.WriteLine(s.Read(block, 0, block.Length));   // 0
        }
    }
}