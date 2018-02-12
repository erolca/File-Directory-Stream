using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


//15.29.1.	Use BinaryFormatter to Serialize an object to file

[Serializable]
class Employee
{
    private int Number;
    private string FirstName;
    private string LastName;

    public void WriteEmployee()
    {
        Console.WriteLine("Number: " + this.Number);
        Console.WriteLine("FirstName: " + this.FirstName);
        Console.WriteLine("LastName: " + this.LastName);
    }

    public Employee(int newNumber, string newFirstName, string LastName)
    {
        this.Number = newNumber;
        this.FirstName = newFirstName;
        this.LastName = LastName;
    }
}

class MainClass
{
    public static void Main()
    {
        Employee emp = new Employee(1, "X", "F");
        emp.WriteEmployee();

        FileStream serializeStream = new FileStream("c:\\TEST\\test.dat", FileMode.Create);

        BinaryFormatter bf = new BinaryFormatter();

        bf.Serialize(serializeStream, emp);
        serializeStream.Flush();
        serializeStream.Close();

        FileStream retrieveStream = new FileStream("c:\\TEST\\test.dat", FileMode.Open);
        Employee NewEmployee = (Employee)bf.Deserialize(retrieveStream);
        NewEmployee.WriteEmployee();
    }
}
//Number: 1
//FirstName: X
//LastName: F
//Number: 1
//FirstName: X
//LastName: F