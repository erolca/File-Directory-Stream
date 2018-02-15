using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        byte[] storage = new byte[255];

        MemoryStream memstrm = new MemoryStream(storage);

        StreamWriter memwtr = new StreamWriter(memstrm);
        StreamReader memrdr = new StreamReader(memstrm);

        for (int i = 0; i < 10; i++)
            memwtr.WriteLine("byte [" + i + "]: " + i);

        memwtr.WriteLine(".");

        memwtr.Flush();

        Console.WriteLine("Reading from storage directly: ");

        foreach (char ch in storage)
        {
            if (ch == '.') break;
            Console.Write(ch);
        }

        Console.WriteLine("\nReading through memrdr: ");

        memstrm.Seek(0, SeekOrigin.Begin); // reset file pointer  

        string str = memrdr.ReadLine();
        while (str != null)
        {
            Console.WriteLine(str);
            str = memrdr.ReadLine();
            if (str.CompareTo(".") == 0) break;
        }
    }
}
//Reading from storage directly:
//byte[0]: 0
//byte[1]: 1
//byte[2]: 2
//byte[3]: 3
//byte[4]: 4
//byte[5]: 5
//byte[6]: 6
//byte[7]: 7
//byte[8]: 8
//byte[9]: 9

//Reading through memrdr:
//byte[0]: 0
//byte[1]: 1
//byte[2]: 2
//byte[3]: 3
//byte[4]: 4
//byte[5]: 5
//byte[6]: 6
//byte[7]: 7
//byte[8]: 8
//byte[9]: 9