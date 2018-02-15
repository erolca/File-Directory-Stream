using System;
using System.IO;
using System.Text;


//	15.20.5.	Read decimal, string and char from a file using FileStream and StreamReader

static class MainClass
{
    static void Main()
    {
        // Create a new file.
        using (FileStream fs = new FileStream("test.txt", FileMode.Create))
        {
            using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
            {
                // Write a decimal, string, and char.
                w.WriteLine(124.23M);
                w.WriteLine("Test string");
                w.WriteLine('A');
            }
        }


        // Open the file in read-only mode.
        using (FileStream fs = new FileStream("test.txt", FileMode.Open))
        {
            using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
            {
                // Read the data and convert it to the appropriate data type.
                Console.WriteLine(Decimal.Parse(r.ReadLine()));
                Console.WriteLine(r.ReadLine());
                Console.WriteLine(Char.Parse(r.ReadLine()));
            }
        }

    }
}
//124.23
//Test string
//A