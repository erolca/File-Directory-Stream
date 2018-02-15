using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>();
        products.Add(new Product(1, "A", 10.0, "A."));
        products.Add(new Product(2, "B", 25.0, "B."));
        products.Add(new Product(4, "C", 12.0, "C."));
        IFormatter serializer = new BinaryFormatter();
        FileStream saveFile = new FileStream("Products.bin", FileMode.Create, FileAccess.Write);
        serializer.Serialize(saveFile, products);
        saveFile.Close();
        FileStream loadFile = new FileStream("Products.bin", FileMode.Open, FileAccess.Read);
        List<Product> savedProducts = serializer.Deserialize(loadFile) as List<Product>;
        loadFile.Close();
    }
}
[Serializable]
public class Product
{
    public long Id;
    public string Name;
    public double Price;

    [NonSerialized]
    string Notes;

    public Product(long id, string name, double price, string notes)
    {
        Id = id;
        Name = name;
        Price = price;
        Notes = notes;
    }

    public override string ToString()
    {
        return string.Format("{0}: {1} (${2:F2}) {3}", Id, Name, Price, Notes);
    }
}
