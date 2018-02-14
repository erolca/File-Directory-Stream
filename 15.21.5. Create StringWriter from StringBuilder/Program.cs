using System;
using System.IO;
using System.Text;

class MainClass
{
    public static void Main()
    {
        StringBuilder sb = new StringBuilder();

        StringWriter sw = new StringWriter(sb);

        sw.Write("This is a test of the StringWriter class");
        sw.Close();

        StringReader sr = new StringReader(sb.ToString());

        string EntireString;

        EntireString = sr.ReadToEnd();
        Console.WriteLine(EntireString);

        sr.Close();
    }
}
//This is a test of the StringWriter class