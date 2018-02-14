using System;
using System.IO;

using System.Text;

public class MainClass
{
    public static int Main(string[] args)
    {
        // Get a StringWriter and write some stuff.
        StringWriter writer = new StringWriter();
        writer.WriteLine("string 1");

        for (int i = 0; i < 10; i++)
        {
            writer.Write(i + " ");
        }
        writer.Write(writer.NewLine);

        writer.Close();

        Console.WriteLine("Contents:\n{0}", writer);

        StringBuilder str = writer.GetStringBuilder();
        string allOfTheData = str.ToString();
        Console.WriteLine("-> StringBuilder says:\n{0}", allOfTheData);

        str.Insert(20, "INSERTED STUFF");
        allOfTheData = str.ToString();
        Console.WriteLine("-> New StringBuilder says:\n{0}", allOfTheData);

        StringReader sr = new StringReader(writer.ToString());

        string input = null;
        while ((input = sr.ReadLine()) != null)
        {
            Console.WriteLine(input);
        }

        sr.Close();
        return 0;
    }
}
//Contents:
//string 1
//0 1 2 3 4 5 6 7 8 9

//-> StringBuilder says:
//string 1
//0 1 2 3 4 5 6 7 8 9

//-> New StringBuilder says:
//string 1
//0 1 2 3 4 INSERTED STUFF5 6 7 8 9

//string 1
//0 1 2 3 4 INSERTED STUFF5 6 7 8 9