using System;
using System.IO;


class MainClass
{
    public static void Main()
    {
        StreamWriter Writer;
        Writer = File.CreateText("C:\\TEST\\TestResults.log");
        Writer.WriteLine("Test Results for Test Run XYZ; " + DateTime.Now);
        if (File.Exists("fileName"))
        {
            Writer.WriteLine("File Exists: Test Passed");
        }
        else
        {
            Writer.WriteLine("File Exists: Test Failed");
        }
        Writer.WriteLine("Test Completed for Test Run XYZ; " + DateTime.Now);
        Writer.Close();
    }
}