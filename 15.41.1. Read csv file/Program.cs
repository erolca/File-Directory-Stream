using System;
using System.IO;

//15.41.1.	Read csv file and create object from it


class ReadingFiles
{
    public static void Main()
    {
        String file_name = "C:\\TEST\\Customers.csv";
        StreamReader sr = new StreamReader(file_name);
        String line;
        while ((line = sr.ReadLine()) != null)
        {
            String[] tokens = line.Split(',');
            Customer c = new Customer();
            c.CustomerName = tokens[0];
            c.Street = tokens[1];
            c.City = tokens[2];
            c.AccountNo = tokens[3];
            Console.WriteLine(c);
        }
        sr.Close();
    }
}
class Customer
{
    public String CustomerName;
    public String Street;
    public String City;
    public String AccountNo;
    public Customer()
    {
    }
    public override String ToString()
    {
        return CustomerName + "\n"
              + Street + "," + City + "\n"
              + "\tAcc #:" + AccountNo + "\n\n";
    }
}