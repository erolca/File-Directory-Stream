using System;
using System.IO;

class Class1
{
    [STAThread]
    static void Main(string[] args)
    {
        FileStream fsSrc = File.OpenRead("s.txt");
        BinaryReader rdr = new BinaryReader(fsSrc);

        FileStream fsDest = File.Open("d.txt", FileMode.Create);

        MemoryStream memStream = new MemoryStream();

        int curChar = 0;

        while ((curChar = rdr.Read()) != -1)
        {
            memStream.WriteByte(Convert.ToByte(curChar));
        }

        for (int i = 0; i < memStream.Length / 2; ++i)
        {
            byte tempTop, tempBottom;
            memStream.Seek(i, SeekOrigin.Begin);
            tempTop = (byte)memStream.ReadByte();

            memStream.Seek(-i - 1, SeekOrigin.End);
            tempBottom = (byte)memStream.ReadByte();

            memStream.Seek(-1, SeekOrigin.Current);
            memStream.WriteByte(tempTop);

            memStream.Seek(i, SeekOrigin.Begin);
            memStream.WriteByte(tempBottom);
        }

        memStream.Seek(0, SeekOrigin.Begin);

        byte[] memBytes = memStream.ToArray();

        BinaryWriter bw = new BinaryWriter(fsDest);
        bw.Write(memBytes);

        bw.Close();
        rdr.Close();
    }
}