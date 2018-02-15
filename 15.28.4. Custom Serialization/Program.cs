using System.Runtime.Serialization.Formatters.Soap;
using System.IO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

[Serializable]
class StringData : ISerializable
{
    public string dataItemOne = "First";
    public string dataItemTwo = "data";

    public StringData() { }
    protected StringData(SerializationInfo si, StreamingContext ctx)
    {
        dataItemOne = si.GetString("First").ToLower();
        dataItemTwo = si.GetString("data").ToLower();
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext ctx)
    {
        info.AddValue("First", dataItemOne.ToUpper());
        info.AddValue("data", dataItemTwo.ToUpper());
    }
}
[Serializable]
class MoreData
{
    public string dataItemOne = "block";
    public string dataItemTwo = "data";

    [OnSerializing]
    private void OnSerializing(StreamingContext context)
    {
        dataItemOne = dataItemOne.ToUpper();
        dataItemTwo = dataItemTwo.ToUpper();
    }

    [OnDeserialized]
    private void OnDeserialized(StreamingContext context)
    {
        dataItemOne = dataItemOne.ToLower();
        dataItemTwo = dataItemTwo.ToLower();
    }
}
class Program
{
    static void Main(string[] args)
    {
        MoreData myData = new MoreData();
        SoapFormatter soapFormat = new SoapFormatter();
        using (Stream fStream = new FileStream("MyData.soap", FileMode.Create, FileAccess.Write, FileShare.None))
        {
            soapFormat.Serialize(fStream, myData);
        }
    }
}