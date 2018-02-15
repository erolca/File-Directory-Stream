using System;
using System.IO;
using System.IO.IsolatedStorage;
class UseIsolatedStorage
{
    public static void Main()
    {
        IsolatedStorageFileStream file = new IsolatedStorageFileStream("MyApp.preferences", FileMode.Create);
        StreamWriter sw = new StreamWriter(file);
        sw.WriteLine("UserType=Analyst");
        sw.WriteLine("UserModer=Advanced");
        sw.Close();
        file.Close();

        file = new IsolatedStorageFileStream("MyApp.preferences", FileMode.Open);
        StreamReader reader = new StreamReader(file);
        String prefs = reader.ReadToEnd();
        Console.WriteLine(prefs);
        file.Close();
    }
}