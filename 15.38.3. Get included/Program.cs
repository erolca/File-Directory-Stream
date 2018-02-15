using System;
using System.IO;
using System.IO.IsolatedStorage;

static class MainClass
{
    static void Main()
    {
        using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
        {
            Console.WriteLine("Contained files include:");
            string[] files = store.GetFileNames("*.*");

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
//Contained files include:
//MyFile.txt