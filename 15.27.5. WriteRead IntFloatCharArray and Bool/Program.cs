using System;
using System.IO;


//15.27.5.	Write/Read int, float, char array and bool to a binary file using BinaryWriter


public class MainClass
{
    public static int Main(string[] args)
    {
        Console.WriteLine("***** Creating a file and writing binary data *****");
        FileStream myFStream = new FileStream("temp.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

        BinaryWriter binWrit = new BinaryWriter(myFStream);
        binWrit.Write("Hello as binary info...");

        int myInt = 9;
        float myFloat = 9.8F;
        bool myBool = false;
        char[] myCharArray = { 'H', 'e', 'l', 'l', 'o' };

        binWrit.Write(myInt);
        binWrit.Write(myFloat);
        binWrit.Write(myBool);
        binWrit.Write(myCharArray);

        binWrit.BaseStream.Position = 0;

        Console.WriteLine("Reading binary data...");
        BinaryReader binRead = new BinaryReader(myFStream);
        int temp = 0;
        while (binRead.PeekChar() != -1)
        {
            Console.Write(binRead.ReadByte());
            temp = temp + 1;
            if (temp == 5)
            {
                temp = 0;
                Console.WriteLine();
            }
        }

        binWrit.Close();
        binRead.Close();
        myFStream.Close();

        return 0;
    }
}
//***** Creating a file and writing binary data *****
//Reading binary data...
//2372101108108
//111329711532
//9810511097114
//12132105110102
//1114646469
//000205204
//2865072101
//108108111