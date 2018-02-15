using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        BinaryWriter dataOut;
        BinaryReader dataIn;

        int i = 10;
        double d = 1.56;
        bool b = true;

        try
        {
            dataOut = new BinaryWriter(new FileStream("testdata", FileMode.Create));
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "\nCannot open file.");
            return;
        }

        try
        {
            Console.WriteLine("Writing " + i);
            dataOut.Write(i);

            Console.WriteLine("Writing " + d);
            dataOut.Write(d);

            Console.WriteLine("Writing " + b);
            dataOut.Write(b);

            Console.WriteLine("Writing " + 12.2 * 7.4);
            dataOut.Write(12.2 * 7.4);

        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "\nWrite error.");
        }

        dataOut.Close();

        Console.WriteLine();

        try
        {
            dataIn = new BinaryReader(new FileStream("testdata", FileMode.Open));
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message + "\nCannot open file.");
            return;
        }

        try
        {
            i = dataIn.ReadInt32();
            Console.WriteLine("Reading " + i);

            d = dataIn.ReadDouble();
            Console.WriteLine("Reading " + d);

            b = dataIn.ReadBoolean();
            Console.WriteLine("Reading " + b);

            d = dataIn.ReadDouble();
            Console.WriteLine("Reading " + d);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "Read error.");
        }

        dataIn.Close();
    }
}
//Writing 10
//Writing 1.56
//Writing True
//Writing 90.28

//Reading 10
//Reading 1.56
//Reading True
//Reading 90.28