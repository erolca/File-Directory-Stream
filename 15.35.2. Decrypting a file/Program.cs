using System;
using System.IO;
using System.Security.Cryptography;

class MainClass
{
    public static void Main()
    {
        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

        FileStream fsKeyIn = File.OpenRead(@"c:\encrypted.key");

        BinaryReader br = new BinaryReader(fsKeyIn);

        tdes.Key = br.ReadBytes(24);
        tdes.IV = br.ReadBytes(8);

        FileStream fsIn = File.OpenRead(@"c:\encrypted.txt");

        CryptoStream cs = new CryptoStream(fsIn, tdes.CreateDecryptor(), CryptoStreamMode.Read);

        StreamReader sr = new StreamReader(cs);

        Console.WriteLine(sr.ReadToEnd());
        sr.Close();
    }
}
//str