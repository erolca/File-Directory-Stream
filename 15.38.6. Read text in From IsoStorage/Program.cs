using System;
using System.IO.IsolatedStorage;
using System.IO;

class MainClass
{
    static void Main(string[] args)
    {
        using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
        {
            using (IsolatedStorageFileStream isStream = new IsolatedStorageFileStream("MyData.txt", FileMode.Open, FileAccess.Read, store))
            {
                using (StreamReader sr = new StreamReader(isStream))
                {
                    string allTheData = sr.ReadToEnd();
                    Console.WriteLine(allTheData);
                }
            }
        }


    }
}