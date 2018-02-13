using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (FileStream fStream = File.Open(@"C:\TEST\myMessage.dat", FileMode.Create))
        {
            string msg = "Hello!";
            byte[] msgAsByteArray = Encoding.Default.GetBytes(msg);
            fStream.Write(msgAsByteArray, 0, msgAsByteArray.Length);
            fStream.Position = 0;

            byte[] bytesFromFile = new byte[msgAsByteArray.Length];
            for (int i = 0; i < msgAsByteArray.Length; i++)
            {
                bytesFromFile[i] = (byte)fStream.ReadByte();
                Console.Write(bytesFromFile[i]);
            }
            Console.WriteLine(Encoding.Default.GetString(bytesFromFile));
        }
    }
}