using System;
using System.IO;
using System.Text;

class MainClass
{
    public static void Main()
    {
        FileStream f;
        char ch;

        try
        {
            f = new FileStream("c:\\TEST\\random.dat", FileMode.Create);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }

        // Write the alphabet.      
        for (int i = 0; i < 26; i++)
        {
            try
            {
                f.WriteByte((byte)('A' + i));
            }
            catch (IOException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
        }

        try
        {
            f.Seek(0, SeekOrigin.Begin); // seek to first byte 
            ch = (char)f.ReadByte();
            Console.WriteLine("First value is " + ch);

            f.Seek(1, SeekOrigin.Begin); // seek to second byte 
            ch = (char)f.ReadByte();
            Console.WriteLine("Second value is " + ch);

            f.Seek(4, SeekOrigin.Begin); // seek to 5th byte 
            ch = (char)f.ReadByte();
            Console.WriteLine("Fifth value is " + ch);

            Console.WriteLine();

        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message);
        }

        Console.WriteLine();
        f.Close();


        //*//
        string path = @"c:\TEST\random.dat";

        // Delete the file if it exists.
        if (File.Exists(path))
        {
            File.Delete(path);
        }

        //Create the file.
        using (FileStream fs = File.Create(path))
        {
            AddText(fs, "This is some text");
            AddText(fs, "This is some more text,");
            AddText(fs, "\r\nand this is on a new line");
            AddText(fs, "\r\n\r\nThe following is a subset of characters:\r\n");

            for (int i = 1; i < 120; i++)
            {
                AddText(fs, Convert.ToChar(i).ToString());

            }
        }

        //Open the stream and read it back.
        using (FileStream fs = File.OpenRead(path))
        {
            byte[] b = new byte[1024];
            UTF8Encoding temp = new UTF8Encoding(true);
            while (fs.Read(b, 0, b.Length) > 0)
            {
                Console.WriteLine(temp.GetString(b));
            }
        }
    }

    private static void AddText(FileStream fs, string value)
    {
        byte[] info = new UTF8Encoding(true).GetBytes(value);
        fs.Write(info, 0, info.Length);
    }


}
//First value is A
//Second value is B
//Fifth value is E