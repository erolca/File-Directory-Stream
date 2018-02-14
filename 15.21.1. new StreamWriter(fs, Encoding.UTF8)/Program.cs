using System;
using System.IO;
using System.Text;

class MainClass
{
    static void Main()
    {
        using (FileStream fs = new FileStream("c:\\TEST\\testfile.txt", FileMode.Create))
        {
            using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
            {
                w.WriteLine(124.23M);
                w.WriteLine("Test string");
                w.WriteLine('!');
            }
        }
        Console.WriteLine("Press Enter to read the information.");
        Console.ReadLine();
        using (FileStream fs = new FileStream("c:\\TEST\\testfile.txt", FileMode.Open))
        {
            using (StreamReader r = new StreamReader(fs, Encoding.UTF8))
            {
                Console.WriteLine(Decimal.Parse(r.ReadLine()));
                Console.WriteLine(r.ReadLine());
                Console.WriteLine(Char.Parse(r.ReadLine()));
            }
        }
    }
}