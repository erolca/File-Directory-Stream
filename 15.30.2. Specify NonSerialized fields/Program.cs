using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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

class MainClass
{
    public static void Main()
    {
        MyElement ele = new MyElement("name");

        Console.WriteLine("Initial value");
        Console.WriteLine("{0}", ele);

        // write to binary, read it back
        Stream streamWrite = File.Create("MyElement.bin");
        BinaryFormatter binaryWrite = new BinaryFormatter();
        binaryWrite.Serialize(streamWrite, ele);
        streamWrite.Close();

        Stream streamRead = File.OpenRead("MyElement.bin");
        BinaryFormatter binaryRead = new BinaryFormatter();
        MyElement element = (MyElement)binaryRead.Deserialize(streamRead);
        streamRead.Close();

        Console.WriteLine("Values after binary serialization");
        Console.WriteLine("{0}", element);

    }
}
//Initial value
//name: 15
//Values after binary serialization
//name: 0