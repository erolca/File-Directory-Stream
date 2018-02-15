using System;
using System.Diagnostics;


//15.37.1.	FileVersionInfo: Product Name, Product Version, Company Name


static class MainClass
{
    static void Main(string[] args)
    {

        FileVersionInfo info = FileVersionInfo.GetVersionInfo("c:\\test.txt");

        // Display version information.
        Console.WriteLine("Checking File: " + info.FileName);
        Console.WriteLine("Product Name: " + info.ProductName);
        Console.WriteLine("Product Version: " + info.ProductVersion);
        Console.WriteLine("Company Name: " + info.CompanyName);

    }
}
//Checking File: c:\test.txt
//Product Name:
//Product Version:
//Company Name: