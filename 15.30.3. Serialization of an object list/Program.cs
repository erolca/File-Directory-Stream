using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

[Serializable]
public class MyElement
{
    public MyElement(string name)
    {
        this.name = name;
        this.cacheValue = 15;
    }
    public override string ToString()
    {
        return (String.Format("{0}: {1}", name, cacheValue));
    }
    string name;

    [NonSerialized]
    int cacheValue;
}

[Serializable]
public class MyElementList
{
    public void Add(MyElement my)
    {
        row.Add(my);
    }

    public override string ToString()
    {
        string temp = null;
        foreach (MyElement my in row)
            temp += my.ToString() + "\n";
        return (temp);
    }

    ArrayList row = new ArrayList();
}

class MainClass
{
    public static void Main()
    {
        MyElementList row = new MyElementList();
        row.Add(new MyElement("Gumby"));
        row.Add(new MyElement("Pokey"));

        Console.WriteLine("Initial value");
        Console.WriteLine("{0}", row);

        // write to binary, read it back
        Stream streamWrite = File.Create("MyElementList.bin");
        BinaryFormatter binaryWrite = new BinaryFormatter();
        binaryWrite.Serialize(streamWrite, row);
        streamWrite.Close();

        Stream streamRead = File.OpenRead("MyElementList.bin");
        BinaryFormatter binaryRead = new BinaryFormatter();
        MyElementList rowBinary = (MyElementList)binaryRead.Deserialize(streamRead);
        streamRead.Close();

        Console.WriteLine("Values after binary serialization");
        Console.WriteLine("{0}", rowBinary);

    }
}
//Initial value
//Gumby: 15
//Pokey: 15

//Values after binary serialization
//Gumby: 0
//Pokey: 0