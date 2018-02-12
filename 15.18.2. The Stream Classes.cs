using System;

/// <summary>
/// System.IO.Stream represents a byte stream
/// System.IO.Stream is a base class for all other stream classes.
/// System.IO.Stream is abstract.
/// Some of the Methods Defined by Stream
/// 
/// Method  Description
/// void Close()    Closes the stream.
/// 
/// void Flush()    Flush the stream.
/// int ReadByte()  Returns an integer representation of a byte of input.Returns -1 if no byte is available.
/// int Read(byte[] buf, int offset, int numBytes)  Attempts to read up to numBytes bytes into buf starting at
/// buf[offset], returning the number of bytes successfully read.
/// long Seek(long offset, SeekOrigin origin) Sets the current position in the stream to the specified offset from the specified origin.
/// void WriteByte(byte b) Writes a single byte to an output stream.
/// void Write(byte[] buf, int offset, int numBytes) Writes a subrange of numBytes bytes from the array buf, beginning at buf[offset].
/// 
/// The Properties Defined by Stream
/// Method  Description
/// 
/// bool CanRead    can be read or not. (read-only)
/// bool CanSeek    supports position requests or not. (read-only)
/// bool CanWrite   can be written or not. (read-only)
/// long Length the length of the stream. (read-only)
/// long Position   the current position of the stream. (read/write)

/// </summary>
/// 
public class Class1
{
	public Class1()
	{
	}
}
