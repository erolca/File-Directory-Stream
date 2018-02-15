using System;
using System.IO;
using System.Security.Cryptography;

class MainClass
{
    public static void Main()
    {
        FileStream fsOut = File.Create(@"c:\encrypted.txt");

        TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();

        CryptoStream cs = new CryptoStream(fsOut, tdes.CreateEncryptor(), CryptoStreamMode.Write);

        StreamWriter sw = new StreamWriter(cs);

        sw.WriteLine("str");
        sw.Flush();
        sw.Close();

        FileStream fsKeyOut = File.Create(@"c:\encrypted.key");

        BinaryWriter bw = new BinaryWriter(fsKeyOut);

        bw.Write(tdes.Key);
        bw.Write(tdes.IV);

        bw.Flush();
        bw.Close();
    }
}