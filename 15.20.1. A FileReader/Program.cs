using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        FileStream fin;
        string s;

        try
        {
            fin = new FileStream("c:\\TEST\\test.txt", FileMode.Open);
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message + "Cannot open file.");
            return;
        }

        StreamReader fstr_in = new StreamReader(fin);

        // Read the file line-by-line. 
        while ((s = fstr_in.ReadLine()) != null)
        {
            Console.WriteLine(s);
        }

        fstr_in.Close();
    }
}
//asdfasdf