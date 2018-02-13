using System;
using System.IO;

class MainClass
{
    public static void Main()
    {
        StringWriter strwtr = new StringWriter();

        for (int i = 0; i < 10; i++)
            strwtr.WriteLine("This is i: " + i);

        StringReader strrdr = new StringReader(strwtr.ToString());

        string str = strrdr.ReadLine();
        while (str != null)
        {
            str = strrdr.ReadLine();
            Console.WriteLine(str);
        }

    }
}
//This is i: 1
//This is i: 2
//This is i: 3
//This is i: 4
//This is i: 5
//This is i: 6
//This is i: 7
//This is i: 8
//This is i: 9