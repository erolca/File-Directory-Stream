using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

class Program
{
    static void SaveCompressedFile(string filename, string data)
    {
        FileStream fileStream = new FileStream(filename, FileMode.Create, FileAccess.Write);
        GZipStream compressionStream = new GZipStream(fileStream, CompressionMode.Compress);
        StreamWriter writer = new StreamWriter(compressionStream);
        writer.Write(data);
        writer.Close();
    }

    static string LoadCompressedFile(string filename)
    {
        FileStream fileStream = new FileStream(filename, FileMode.Open, FileAccess.Read);
        GZipStream compressionStream = new GZipStream(fileStream, CompressionMode.Decompress);
        StreamReader reader = new StreamReader(compressionStream);
        string data = reader.ReadToEnd();
        reader.Close();
        return data;
    }

    static void Main(string[] args)
    {
        string filename = "compressedFile.txt";
        string sourceString = "asdf";
        SaveCompressedFile(filename, sourceString);
        FileInfo compressedFileData = new FileInfo(filename);
        string recoveredString = LoadCompressedFile(filename);
        recoveredString = recoveredString.Substring(0, recoveredString.Length / 100);
    }
}