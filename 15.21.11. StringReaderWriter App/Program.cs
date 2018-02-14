using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        using (StringWriter strWriter = new StringWriter())
        {
            strWriter.WriteLine("A");
            Console.WriteLine(strWriter);
            StringBuilder sb = strWriter.GetStringBuilder();
            sb.Insert(0, "Hey!! ");
            Console.WriteLine("-> {0}", sb.ToString());
            sb.Remove(0, "Hey!! ".Length);
            Console.WriteLine("-> {0}", sb.ToString());
            using (StringReader strReader = new StringReader(strWriter.ToString()))
            {
                string input = null;
                while ((input = strReader.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
            }
        }
    }
}