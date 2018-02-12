using System;
using System.IO;
using System.Text;



//	15.18.6.	Using streamreader to read entire lines at a time


public class MainClass
{
    public static void Main()
    {
        Stream s = new FileStream("c:\\TEST\\test.txt", FileMode.Open);
        using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
    }
}