using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program14
    {
        static void Main(string[] args)
        {
            int[] arvosanat = new int[6];
            int numero;
            bool tulos;
            Console.WriteLine("Anna oppilaiden arvosanat 0 - 5 ");
            do
            {
                Console.Write("Anna arvosana :");
                string line = Console.ReadLine();
                tulos = Int32.TryParse(line, out numero);
                if (tulos)
                {
                    switch (numero)
                    {
                        case 0: arvosanat[0]++; break;
                        case 1: arvosanat[1]++; break;
                        case 2: arvosanat[2]++; break;
                        case 3: arvosanat[3]++; break;
                        case 4: arvosanat[4]++; break;
                        case 5: arvosanat[5]++; break;
                    }
                }
            } while (tulos);
            Console.WriteLine("Arvosanat ");
            for (int i = 0; i < arvosanat.Length; i++)
            {
                Console.WriteLine(i + ":");
                for (int k = 0; k < arvosanat[i]; k++) Console.Write("*");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
