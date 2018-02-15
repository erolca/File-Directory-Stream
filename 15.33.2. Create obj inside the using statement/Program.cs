using System;
using System.IO;

class MainClass
{
    public static void Main()
    {

        using (StreamReader sr2 = new StreamReader("test.txt"))
        {
            Console.WriteLine(sr2.ReadLine());
            sr2.Close();
        }

    }
}
//124.23