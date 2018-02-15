using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// C# defines two binary stream classes that can be used to read and write binary data directly.
/// BinaryReader.
/// BinaryWriter.
/// A BinaryReader is a wrapper around a byte stream that handles the reading of binary data.
/// 
/// Method Description
/// int Read()  Returns an integer representation of the next available character.Returns -1 when the end of the file is encountered.
/// int Read(byte[] buf, int offset, int num)  Attempts to read up to num bytes into buf starting at buf[offset],
/// returning the number of bytes successfully read.
/// int Read(char[] buf, int offset, int num) Attempts to read up to num characters into buf starting at buf[offset],
/// returning the number of characters successfully read.
/// 
/// Commonly Used Input Methods Defined by BinaryReader
/// 
/// Method  Description
/// bool ReadBoolean() Reads a bool.
/// byte ReadByte() Reads a byte.
/// sbyte ReadSByte() Reads an sbyte
/// byte[] ReadBytes(int num) Reads num bytes and returns them as an array.
/// char ReadChar() Reads a char.
/// char[] ReadChar(int num) Reads num characteds and returns them as an array
/// double ReadDouble() Reads a double
/// float ReadSingle() Reads a float
/// short ReadInt16() Reads a short
/// int ReadInt32() Reads an int
/// long ReadInt64() Reads a long
/// ushort ReadUInt16() Reads a ushort
/// uint ReadUInt32() Reads a uint
/// ulong ReadUInt64() Reads a ulong
/// string ReadString() Reads a string that has been written using a BinaryWriter.
/// 
/// 
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

