using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Person
{
    public Person()
    {
    }

    public int Age { get; set; }
    public int WeightInPounds { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        Serialize();
        DeSerialize();
    }
    public static void Serialize()
    {
        Person me = new Person();
        me.Age = 40;
        me.WeightInPounds = 200;
        Stream s = File.Open("Me.dat", FileMode.Create);
        BinaryFormatter bf = new BinaryFormatter();
        bf.Serialize(s, me);
        s.Close();
    }

    public static void DeSerialize()
    {
        Stream s = File.Open("Me.dat", FileMode.Open);
        BinaryFormatter bf = new BinaryFormatter();
        object o = bf.Deserialize(s);
        Person p = o as Person;
        s.Close();
    }
}