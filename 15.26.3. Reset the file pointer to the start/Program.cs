using System;
using System.IO;

static class MainClass
{
    static void Main()
    {
        // Create a new file and writer.
        using (FileStream fs = new FileStream("test.bin", FileMode.Create))
        {
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                // Write a decimal, two strings, and a char.
                w.Write(124.23M);
                w.Write("Test string");
                w.Write("Test string 2");
                w.Write('!');
            }
        }

        using (FileStream fs = new FileStream("test.bin", FileMode.Open))
        {
            using (StreamReader sr = new StreamReader(fs))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    Console.WriteLine(br.ReadDecimal());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadChar());
                }

                // Read the data and convert it to the appropriate data type.
                fs.Position = 0;
                using (BinaryReader br = new BinaryReader(fs))
                {
                    Console.WriteLine(br.ReadDecimal());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadString());
                    Console.WriteLine(br.ReadChar());
                }

            }
        }
    }
}
//124.23
//Test string
//Test string 2
//!

//Unhandled Exception: System.ObjectDisposedException: Cannot access a closed file.
//   at System.IO.__Error.FileNotOpen()
//   at System.IO.FileStream.Seek(Int64 offset, SeekOrigin origin)
//   at System.IO.FileStream.set_Position(Int64 value)
//   at MainClass.Main()