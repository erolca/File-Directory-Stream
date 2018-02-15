using System.Net;
using System;
using System.Collections;
using System.IO;
using System.IO.IsolatedStorage;
using System.Security.Policy;

class QueryIsolatedStorage
{
    public static void Main()
    {
        IsolatedStorageFile isfs = IsolatedStorageFile.GetStore(IsolatedStorageScope.User |
                     IsolatedStorageScope.Assembly,
                     null,
                     null);
        IEnumerator e = IsolatedStorageFile.GetEnumerator(IsolatedStorageScope.User);
        while (e.MoveNext())
        {
            IsolatedStorageFile isf = (IsolatedStorageFile)e.Current;
            Url assemblyUrl = (Url)isf.AssemblyIdentity;
            Console.WriteLine("Assembly:" + assemblyUrl.Value);
            string[] files = isf.GetFileNames("*");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}