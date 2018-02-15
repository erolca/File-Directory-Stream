using System;
using System.IO;


//15.27.3.	Write decimal, strings and char to a file using the BinaryWriter


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
                Console.WriteLine(sr.ReadToEnd());
                Console.WriteLine();

            }
        }
    }
}
//Test string 2! Test string