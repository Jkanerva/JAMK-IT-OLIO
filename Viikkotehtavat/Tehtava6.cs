using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna matka ");
            double kulutus = 7.02;
            double hinta = 1.595;
            string line = Console.ReadLine();
            double matka;
            bool tulos = Double.TryParse(line, out matka);
            if (tulos)
            {
                double bensiini = matka / 100 * kulutus;
                double kustannus = bensiini * hinta;
                Console.WriteLine("Bensan kulutus on {0:F2} litraa.", bensiini);
                Console.WriteLine("Kustantaa {0:F2} euroa.", kustannus);
            }
            else
            {
                Console.WriteLine("Et antanut lukua");
            }
            Console.ReadLine();
        }
    }
}
