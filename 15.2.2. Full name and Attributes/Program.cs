using System;
using System.IO;


//15.2.2.	Create a file and get its creation time, full name and Attributes

public class MainClass
{
    public static int Main(string[] args)
    {
        FileInfo f = new FileInfo(@"C:\\Test\15.2.2.txt");
        FileStream fs = f.Create();

        Console.WriteLine("Creation: {0}", f.CreationTime);
        Console.WriteLine("Full name: {0}", f.FullName);
        Console.WriteLine("Full atts: {0}", f.Attributes.ToString());

     

      
        Console.WriteLine("Dosya Tipi                   : " + f.Attributes);

        Console.WriteLine("Oluşturulma Tarihi           : " + f.CreationTime.ToString());
    
        Console.WriteLine("Bulunduğu Klasör             : " + f.DirectoryName);
        
        Console.WriteLine("Uzantısı                     : " + f.Extension);
        
        Console.WriteLine("Dosya Yolu                   : " + f.FullName);
        
        Console.WriteLine("Salt Okunur Mu               :" + f.IsReadOnly);
       
        Console.WriteLine("Dosyaya son erişim tarihi    :" + f.LastAccessTime.ToString());
        
        Console.WriteLine("En son değişiklik zamanı     :" + f.LastWriteTime.ToString());
        
        Console.WriteLine("Dosya Adı                    :" + f.Name);


        fs.Close();
        f.Delete();

        return 0;
    }
}

//Creation: 9.2.2018 12:18:00
//Full name: C:\Test\15.2.2.txt
//Full atts: Archive