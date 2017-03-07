using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Olio_ohjelmointi3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write
            string line;
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Public\WriteLines2.txt"))
            {
                do
                {
                    Console.Write("Give a text line (enter ends) : ");
                    line = Console.ReadLine();
                    if (line.Length != 0) sw.WriteLine(line);
                } while (line.Length != 0);
            }

            //Read
            using (StreamReader sr = new StreamReader(@"C:\Users\Public\WriteLines2.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
