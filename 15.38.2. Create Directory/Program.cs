using System;
using System.IO;
using System.IO.IsolatedStorage;


//15.38.2.	Create Directory in your Isolated Storage File

static class MainClass
{
    static void Main()
    {
        using (IsolatedStorageFile store = IsolatedStorageFile.GetUserStoreForAssembly())
        {
            store.CreateDirectory("MyFolder");

            Console.WriteLine("Current size: " + store.CurrentSize.ToString());
            Console.WriteLine("Scope: " + store.Scope.ToString());
        }
    }
}
//Current size: 2048
//Scope: User, Assembly