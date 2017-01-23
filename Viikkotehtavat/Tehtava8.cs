using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program8
    {
        static void Main(string[] args)
        {
            int numero;
            int numerot = 3;
            int suurin = 0;
            for (int i = 1; i <= numerot; i++)
            {
                Console.WriteLine("Anna numero: ");
                string line = Console.ReadLine();
                bool tulos = Int32.TryParse(line, out numero);
                if (tulos)
                {
                    if (i == 1) suurin = numero;
                    else if (numero > suurin) suurin = numero;
                }
                else
                {
                    Console.WriteLine("Et antanut numeroa ");
                }
            }
            Console.WriteLine("Isoin numero on " + suurin);
            Console.ReadLine();
        }
    }
}
