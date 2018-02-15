using System;
using System.IO.IsolatedStorage;
using System.IO;

class MainClass
{
    static void Main(string[] args)
    {
        using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
        {
            using (IsolatedStorageFileStream isStream = new IsolatedStorageFileStream("MyData.txt", FileMode.OpenOrCreate, store))
            {
                using (StreamWriter sw = new StreamWriter(isStream))
                {
                    sw.WriteLine("data.");
                    sw.WriteLine("Cool?");
                }
            }
        }


    }
}