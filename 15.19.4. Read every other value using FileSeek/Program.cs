using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        FileStream f;
        char ch;

        try
        {
            f = new FileStream("C:\\TEST\\random.dat", FileMode.Create);
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
            Console.WriteLine("Here is every other value: ");
            for (int i = 0; i < 26; i += 2)
            {
                f.Seek(i, SeekOrigin.Begin); // seek to ith double 
                ch = (char)f.ReadByte();
                Console.Write(ch + " ");
            }


        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message);
        }

        Console.WriteLine();
        f.Close();
    }
}
//Here is every other value:
//A C E G I K M O Q S U W Y