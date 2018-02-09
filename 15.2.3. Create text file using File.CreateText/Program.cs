using System;
using System.IO;


//UTF-8 olarak kodlanmış metin yazmak için bir dosyayı açar veya oluşturur.
//Creates or opens a file for writing UTF-8 encoded text.

class MainClass
{
    static void Main(string[] args)
    {
       

        StreamWriter MyStream = null;
        string MyString = "Hello World";

        try
        {
            MyStream = File.CreateText("C:\\Test\\15.2.3.txt");
            MyStream.Write(MyString);
        }
        catch (IOException e)
        {
            Console.WriteLine(e);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        finally
        {
            if (MyStream != null)
                MyStream.Close();
        }



        string path = @"c:\test\MyTest.txt";
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }

    }
}