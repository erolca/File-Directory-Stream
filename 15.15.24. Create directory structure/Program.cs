using System;
using System.IO.IsolatedStorage;
using System.IO;

class MainClass
{
    static void Main(string[] args)
    {
        using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
        {
            store.CreateDirectory(@"TEST\XmlData");
            store.CreateDirectory("TEST\\BinaryData");
            store.CreateDirectory("TEST/TextData");
        }
    }
}