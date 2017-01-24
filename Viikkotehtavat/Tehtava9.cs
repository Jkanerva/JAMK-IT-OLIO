using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program9
    {
        static void Main(string[] args)
        {
            int numero;
            int summa = 0;
            bool tulos;
            do
            {
                Console.WriteLine("Anna luku ");
                string line = Console.ReadLine();
                tulos = Int32.TryParse(line, out numero);
                if (tulos)
                {
                    summa += numero;
                }
            } while (tulos && numero != 0) ;
                Console.WriteLine("Annetun luvun summa on {0} ", summa);
                Console.ReadLine();
        }
    }
}
