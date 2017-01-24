using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program15
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Anna luku ");
            string line = Console.ReadLine();
            bool tulos = Int32.TryParse(line, out numero);
            int puu = numero - 2;
            int juuri = numero - puu;
            if (tulos)
            {
                if (numero < 4)
                {
                    Console.WriteLine("Liian pieni puu ");
                    Console.ReadLine();
                    return;
                } else if (numero > 40)
                {
                    Console.WriteLine("Liian iso puu ");
                    Console.ReadLine();
                    return;
                }
                for (int i = 0; i < puu; i++)
                {
                    int spacesLength = puu - i;
                    for (int space = 0; space <= spacesLength; space++)
                    {
                        Console.Write(" ");
                    }
                    for (int tähti = 0; tähti <= i * 2; tähti++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < juuri; i++)
                {
                    for (int space = 0; space <= puu; space++)
                    {
                        Console.Write(" ");
                    }
                    Console.WriteLine("*");
                }
            }
            else
            {
                Console.WriteLine("Et antanut lukua ");
            }
            Console.ReadLine();
        }
    }
}
