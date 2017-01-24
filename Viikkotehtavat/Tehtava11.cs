using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program11
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Anna luku ");
            string line = Console.ReadLine();
            bool tulos = Int32.TryParse(line, out numero);
            if (tulos)
            {
                int stars = 1;
                for (int i = 0; i < numero; i++)
                {
                    for (int k = 0; i < numero; i++)
                    { 
                        Console.Write("*");
                    }
                    stars++;
                    Console.WriteLine();
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
