using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Runtime.Serialization;


    class Program
    {
        static void Main(string[] args)
        {
        }
    }


[Serializable]
class EncryptableDocument : ISerializable
{
    public EncryptableDocument() { }

    enum Field
    {
        Title,
        Data
    }
    public string Title;
    public string Data;

    public static string Encrypt(string data)
    {
        string encryptedData = data;
        return encryptedData;
    }

    public static string Decrypt(string encryptedData)
    {
        string data = encryptedData;
        return data;
    }

    public void GetObjectData(SerializationInfo info, StreamingContext context)
    {
        info.AddValue(Field.Title.ToString(), Title);
        info.AddValue(Field.Data.ToString(), Encrypt(Data));
    }

    public EncryptableDocument(SerializationInfo info, StreamingContext context)
    {
        Title = info.GetString(Field.Title.ToString());
        Data = Decrypt(info.GetString(Field.Data.ToString()));
    }
}
