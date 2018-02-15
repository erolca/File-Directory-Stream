using System;
using System.IO;
using System.IO.IsolatedStorage;

static class MainClass
{
    static void Main()
    {
        using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
        {
            store.CreateDirectory("MyFolder");

            using (Stream fs = new IsolatedStorageFileStream("MyFile.txt", FileMode.Create, store))
            {
                StreamWriter w = new StreamWriter(fs);

                w.WriteLine("Test");
                w.Flush();
            }
        }
    }
}