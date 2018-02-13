using System;
using System.IO;


//15.20.2.	Use StreamReader to read a line from a text file


class MainClass
{
    public static void Main(string[] args)
    {

        string filename = "c:\\TEST\\file.txt";

        FileStream f = new FileStream(filename, FileMode.Open);
        StreamReader stream = new StreamReader(f);

        string line;
        line = stream.ReadLine();    // header line
        Console.WriteLine(line);

    }
}