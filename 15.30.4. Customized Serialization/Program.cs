using System;
using System.IO;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Employee : ISerializable
{
    public string name;
    public int age;
    public string address;

    public Employee(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }

    private Employee(SerializationInfo info, StreamingContext context)
    {
        name = info.GetString("Name");
        age = info.GetInt32("Age");
        address = info.GetString("Address");
    }

    public void GetObjectData(SerializationInfo inf, StreamingContext con)
    {
        // Always serialize the Employee's name and age.
        inf.AddValue("Name", name);
        inf.AddValue("Age", age);
        inf.AddValue("Address", address);
    }

    public override string ToString()
    {
        StringBuilder str = new StringBuilder();

        str.AppendFormat("Name: {0}\r\n", name);
        str.AppendFormat("Age: {0}\r\n", age);
        str.AppendFormat("Address: {0}\r\n", address);

        return str.ToString();
    }
}

public class MainClass
{
    public static void Main(string[] args)
    {
        Employee anEmployee = new Employee("Employee", 6, "London");

        Stream str = File.Create("anEmployee.bin");
        BinaryFormatter bf = new BinaryFormatter();
        bf.Context = new StreamingContext(StreamingContextStates.CrossAppDomain);
        bf.Serialize(str, anEmployee);
        str.Close();

        str = File.OpenRead("anEmployee.bin");
        bf = new BinaryFormatter();
        anEmployee = (Employee)bf.Deserialize(str);
        str.Close();
        Console.WriteLine(anEmployee);
    }
}
//Name: Employee
//Age: 6
//Address: London