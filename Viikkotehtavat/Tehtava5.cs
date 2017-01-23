using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna sekunnit ");
            string line = Console.ReadLine();
            int sekunnit;
            bool tulos = Int32.TryParse(line, out sekunnit);
            if (tulos)
            {
                int tunti = sekunnit / 3600;
                int minuutti = sekunnit / 60 - tunti * 60;
                int sekuntti = sekunnit % 60;
                Console.WriteLine(tunti + " tuntia " + minuutti + " minuuttia " + sekuntti + " sekunttia ");
            }
            else
            {
                Console.WriteLine("Et antanut numeroa!");
            }
            Console.ReadLine();
        }
    }
}
