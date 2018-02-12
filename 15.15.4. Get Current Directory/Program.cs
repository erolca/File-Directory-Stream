using System;
using System.IO;


/*
 Directory.GetCurrentDirectory Yöntemi ()
 Uygulamanın geçerli çalışma dizini alır.

Environment.CurrentDirectory Özelliği
Alır veya geçerli çalışma dizinine tam olarak nitelenmiş yolunu ayarlar.
         
*/
static class MainClass
{
    static void Main()
    {
        Console.WriteLine("Using: " + Directory.GetCurrentDirectory());




        //
        try
        {
            // Get the current directory.
            string path = Directory.GetCurrentDirectory();
            string target = @"c:\TEST";
            Console.WriteLine("The current directory is {0}", path);
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }

            // Change the current directory.
            Environment.CurrentDirectory = (target);
            if (path.Equals(Directory.GetCurrentDirectory()))
            {
                Console.WriteLine("You are in the temp directory.");
            }
            else
            {
                Console.WriteLine("You are not in the temp directory.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        }
    }
}
//Using: c:\users\documents\visual studio 2017\Projects\File Directory Stream\15.15.4. Get Current Directory\bin\Debug
