using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
//Opens a text file, reads all lines of the file into a string array, and then closes the file.


/// <summary>
/// This method opens a file, reads each line of the file, then adds each line as an element of a string array. It then closes the file. A line is defined as a 
/// sequence of characters followed by a carriage return ('\r'), a line feed ('\n'), or a carriage return immediately followed by a line feed. The resulting
/// string does not contain the terminating carriage return and/or line feed.
/// 
/// This method attempts to automatically detect the encoding of a file based on the presence of byte order marks.Encoding formats UTF-8 and UTF-32 
/// (both big-endian and little-endian) can be detected.
/// </summary>
/// 

class MainClass
{
    static void Main(string[] args)
    {
        StreamWriter writer = new StreamWriter(@"c:\test\test.txt");
        for (int i = 0; i < 5; i++)
        {
            writer.Write(i.ToString()+"-");
        }
        writer.Flush();
        writer.Close();

        foreach (string line in File.ReadAllLines(@"c:\test\test.txt"))
        {
            Console.WriteLine(line);
        }


        // example-2
        string path = @"c:\test\test.txt";

        // This text is added only once to the file.
        if (!File.Exists(path))
        {
            // Create a file to write to.
            string[] createText = { "Hello", "And", "Welcome" };
            File.WriteAllLines(path, createText);
        }

        // This text is always added, making the file longer over time
        // if it is not deleted.
        string appendText = "This is extra text" + Environment.NewLine;
        File.AppendAllText(path, appendText);

        // Open the file to read from.
        string[] readText = File.ReadAllLines(path);
        foreach (string s in readText)
        {
            Console.WriteLine(s);
        }
    }
}
//0-1-2-3-4-