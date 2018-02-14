using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


class Program
{
    static void Main(string[] args)
    {
        using (StreamWriter writer = new StreamWriter("C:\\TEST\\reminders.txt"))
        {
            writer.WriteLine("A");
            writer.WriteLine("B");
            writer.WriteLine("C");
            for (int i = 0; i < 10; i++)
                writer.Write(i + " ");
            writer.Write(writer.NewLine);
        }
        using (StreamReader sr = new StreamReader("c:\\TEST\\reminders.txt"))
        {
            string input = null;
            while ((input = sr.ReadLine()) != null)
            {
                Console.WriteLine(input);
            }
        }
    }
}