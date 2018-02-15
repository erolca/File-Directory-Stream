using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        FileStream outStream = File.Create("BinaryTest.dat");

        BinaryWriter bw = new BinaryWriter(outStream);

        bw.Write((int)3);
        bw.Write((decimal)4.5);
        string s = "Test String";
        bw.Write(s);

        bw.Flush();
        bw.Close();

        FileStream inStream = File.OpenRead("BinaryTest.dat");

        BinaryReader br = new BinaryReader(inStream);

        int i = br.ReadInt32();
        decimal d = br.ReadDecimal();
        string s2 = br.ReadString();

        Console.WriteLine(i);
        Console.WriteLine(d);
        Console.WriteLine(s2);

        br.Close();
    }
}
//3
//4.5
//Test String