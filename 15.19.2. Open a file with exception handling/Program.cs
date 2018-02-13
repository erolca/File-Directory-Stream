using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
            FileStream fin;

            try
            {
                fin = new FileStream("c:\\TEST\\test.dat", FileMode.Open);
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc.Message);
                return;
            }
            catch
            {
                Console.WriteLine("Cannot open file.");
                return;
            }



        }
    }

