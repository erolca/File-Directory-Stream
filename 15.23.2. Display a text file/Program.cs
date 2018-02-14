using System;
using System.IO;

class MainClass
{
    public static void Main(string[] args)
    {
        int i;
        FileStream fin;

        try
        {
            fin = new FileStream("c:\\TEST\\test.txt", FileMode.Open);
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
            return;
        }
        catch (IndexOutOfRangeException exc)
        {
            Console.WriteLine(exc.Message + "\nUsage: ShowFile File");
            return;
        }

        // read bytes until EOF is encountered 
        do
        {
            try
            {
                i = fin.ReadByte();
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            if (i != -1) Console.Write((char)i);
        } while (i != -1);

        fin.Close();
    }
}