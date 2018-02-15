using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Text;

public class Tester
{
    public static void Main()
    {
        Tester app = new Tester();
        app.Run();
    }

    private void Run()
    {
        IsolatedStorageFileStream configFile = new IsolatedStorageFileStream("Tester.cfg", FileMode.Open);
        StreamReader reader = new StreamReader(configFile);
        string theEntry;
        do
        {
            theEntry = reader.ReadLine();
            Console.WriteLine(theEntry);
        } while (theEntry != null);

        reader.Close();
        configFile.Close();
    }
}