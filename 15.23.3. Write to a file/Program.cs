using System;
using System.IO;

class MainClass
{
    public static void Main(string[] args)
    {
        FileStream fout;

        // open output file 
        try
        {
            fout = new FileStream("C:\\TEST\\test.txt", FileMode.Create);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "\nError Opening Output File");
            return;
        }

        // Write the alphabet to the file. 
        try
        {
            for (char c = 'A'; c <= 'Z'; c++)
                fout.WriteByte((byte)c);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "File Error");
        }

        fout.Close();
    }
}