using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtäviä
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"D:\Temp\nimet.txt");
            System.Console.WriteLine("Contents of nimet.txt = {0}", text);

            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}

