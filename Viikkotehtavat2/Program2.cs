using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat2
{
    class Program2
    {
        static void Main(string[] args)
        {
            // Pesukone
            Pesukone pesukone = new Pesukone();
            pesukone.Merkki = "Samsung";
            pesukone.PyörintäNopeus = 2000;
            Console.WriteLine(pesukone.ToString());
            Console.ReadLine();
        }
    }
}
