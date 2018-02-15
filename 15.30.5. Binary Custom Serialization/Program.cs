using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class MyClass : ISerializable
{
    public string MyStringValue;
    public int MyIntValue;

    public MyClass(string s, int i)
    {
        MyStringValue = s;
        MyIntValue = i;
    }

    public void GetObjectData(SerializationInfo si, StreamingContext ctx)
    {
        Console.WriteLine("[GetObjectData] Context State: {0}", ctx.State.ToString());

        si.AddValue("MyStringValue", MyStringValue.ToUpper());
        si.AddValue("MyIntValue", MyIntValue);
    }

    private MyClass(SerializationInfo si, StreamingContext ctx)
    {
        Console.WriteLine("[ctor] Context State: {0}", ctx.State.ToString());
        MyStringValue = si.GetString("MyStringValue");
        MyIntValue = si.GetInt32("MyIntValue");
    }
}

public class MainClass
{
    public static int Main(string[] args)
    {
        MyClass myAuto = new MyClass("Sid", 50);
        Stream myStream = File.Create("MyData.dat");

        BinaryFormatter myBinaryFormat = new BinaryFormatter();
        myBinaryFormat.Serialize(myStream, myAuto);
        myStream.Close();

        myStream = File.OpenRead("MyData.dat");
        MyClass carFromDisk = (MyClass)myBinaryFormat.Deserialize(myStream);
        Console.WriteLine("{0} is alive!\n", carFromDisk.MyStringValue);
        myStream.Close();
        return 0;
    }
}
//[GetObjectData] Context State: All
//[ctor] Context State: All
//SID is alive!