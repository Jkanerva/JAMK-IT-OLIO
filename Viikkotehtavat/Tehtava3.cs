using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program3
    {
        static void Main(string[] args)
        {
            int numerot = 3;
            double summa = 0;
            for (int i = 1; i <= numerot; i++)
            {
                Console.WriteLine("Anna kolme numeroa ");
                string line = Console.ReadLine();
                int numero;
                bool tulos = Int32.TryParse(line, out numero);
                if (tulos)
                {
                    summa += numero;
                }
                else
                {
                    Console.WriteLine("Et antanut numeroa ");
                    return;
                }
            }
            Console.WriteLine("summa = " + summa);
            Console.WriteLine("keskiarvo = {0:F2}", (summa / numerot));
            Console.ReadLine();
        }
    }
}
