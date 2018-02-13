using System;
/// <summary> 15.19.1.	The FileMode and FileAccess
/// 
/// Value	Description
/// FileMode.Append append to the end of file.
/// FileMode.Create create a new output file.Any preexisting file by the same name will be destroyed.
/// FileMode.CreateNew create a new output file.The file must not already exist.
/// FileMode.Open open a preexisting file.
/// FileMode.OpenOrCreate open a file if it exists, or create the file if it does not already exist.
/// FileMode.Truncate open a preexisting file, but reduce its length to zero.
/// 
/// If you want to restrict access to just reading or just writing, use this constructor:
/// FileStream(string filename, FileMode mode, FileAccess how)
/// 1-'how' determines how the file can be accessed.
/// 2-'how' must be one of:
/// 3-FileAccess.Read
/// 4-FileAccess.Write 
/// 5-FileAccess.ReadWrite
///
/// </summary>
public class Class1
{
	public Class1()
	{
	}
}
