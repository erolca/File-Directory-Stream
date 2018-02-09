﻿using System;
using System.IO;

class MainClass
{


    static void SimpleFileCopy()
    {
        string fileName = "test.txt";
        string sourcePath = @"C:\TEST\TestFolder";
        string targetPath = @"C:\TEST\TestFolder\SubDir";

        // Use Path class to manipulate file and directory paths.
        string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
        string destFile = System.IO.Path.Combine(targetPath, fileName);

        // To copy a folder's contents to a new location:
        // Create a new target folder, if necessary.
        if (!System.IO.Directory.Exists(targetPath))
        {
            System.IO.Directory.CreateDirectory(targetPath);
        }

        // To copy a file to another location and 
        // overwrite the destination file if it already exists.
        System.IO.File.Copy(sourceFile, destFile, true);

        // To copy all the files in one directory to another directory.
        // Get the files in the source folder. (To recursively iterate through
        // all subfolders under the current directory, see
        // "How to: Iterate Through a Directory Tree.")
        // Note: Check for target path was performed previously
        //       in this code example.
        if (System.IO.Directory.Exists(sourcePath))
        {
            string[] files = System.IO.Directory.GetFiles(sourcePath);

            // Copy the files and overwrite destination files if they already exist.
            foreach (string s in files)
            {
                // Use static Path methods to extract only the file name from the path.
                fileName = System.IO.Path.GetFileName(s);
                destFile = System.IO.Path.Combine(targetPath, fileName);
                System.IO.File.Copy(s, destFile, true);
            }
        }
        else
        {
            Console.WriteLine("Source path does not exist!");
        }

        // Keep console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
    public static void Main(string[] args)
    {
        int i;
        FileStream fin;
        FileStream fout;

        try
        {
            fin = new FileStream("c:\\TEST\\inputFile.txt", FileMode.Open);
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message + "\nInput File Not Found");
            return;
        }

        try
        {
            fout = new FileStream("c:\\TEST\\outputFile.txt", FileMode.Create);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "\nError Opening Output File");
            return;
        }

        try
        {
            do
            {
                i = fin.ReadByte();
                if (i != -1)
                    fout.WriteByte((byte)i);
            } while (i != -1);
        }
        catch (IOException exc)
        {
            Console.WriteLine(exc.Message + "File Error");
        }

        fin.Close();
        fout.Close();




        //


        SimpleFileCopy();
    }
}