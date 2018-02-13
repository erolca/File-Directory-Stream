using System;
using System.IO;

//Determines whether the specified file exists.

/// <summary> 15.1.4. File.Exists
/// The Exists method should not be used for path validation, this method merely checks if the file specified in path exists. Passing an invalid path to
///Exists returns false. To check whether the path contains any invalid characters, you can call the GetInvalidPathChars method to retrieve the characters
///that are invalid for the file system.You can also create a regular expression to test the whether the path is valid for your environment.For examples
///of acceptable paths, see File.
///To check if a directory exists, see Directory.Exists.
///
///Be aware that another process can potentially do something with the file in between the time you call the Exists method and perform another
///operation on the file, such as Delete.
///
///The path parameter is permitted to specify relative or absolute path information. Relative path information is interpreted as relative to the current
///working directory. To obtain the current working directory, see GetCurrentDirectory.
///
///
///If path describes a directory, this method returns false. Trailing spaces are removed from the path parameter before determining if the file exists.
///
///The Exists method returns false if any error occurs while trying to determine if the specified file exists. This can occur in situations that raise
///exceptions such as passing a file name with invalid characters or too many characters, a failing or missing disk, or if the caller does not have permission to read
///the file.
/// </summary>
/// 





static class MainClass
{
    static void Main(string[] args)
    {

        Console.WriteLine(File.Exists("c:\\test.txt"));
        string curFile = @"c:\test\test.txt";
        Console.WriteLine(File.Exists(curFile) ? "File exists." : "File does not exist.");
    }
}