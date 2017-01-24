using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program12
    {
        static void Main(string[] args)
        {
            int[] numerot = new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Anna luku ");
                string line = Console.ReadLine();
                int numero;
                bool tulos = Int32.TryParse(line, out numero);
                if (tulos)
                {
                    numerot[i] = numero;
                }
                else
                {
                    Console.WriteLine("Et antanut lukua");
                }
            }
            Console.WriteLine("Kokonaispisteet ovat ");
            for (int i = numerot.Length - 1; i >= 0; i--)
            { 
                Console.WriteLine(numerot[i]);
                if (i > 0) Console.WriteLine(",");
            }
                Console.ReadLine();
        }
    }
}
