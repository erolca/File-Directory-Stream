using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class MainClass
{
    static void Main(string[] args)
    {
        string[] lines = new string[10];
        for (int i = 0; i < 10; i++)
        {
            lines[i] = String.Format("This is line number {0}", i);
        }

        File.WriteAllLines(@"c:\test\test.txt", lines);

        foreach (string line in File.ReadAllLines(@"c:\test\test.txt"))
        {
            Console.WriteLine(line);
        }
    }
}
//This is line number 0
//This is line number 1
//This is line number 2
//This is line number 3
//This is line number 4
//This is line number 5
//This is line number 6
//This is line number 7
//This is line number 8
//This is line number 9