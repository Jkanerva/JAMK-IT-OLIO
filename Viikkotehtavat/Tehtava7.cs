using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anna vuosi ");
            string line = Console.ReadLine();
            int vuosi;
            bool tulos = Int32.TryParse(line, out vuosi);
            if (tulos)
            {
                if ((vuosi % 4 == 0 && vuosi % 100 != 0) || vuosi % 400 == 0)
                {
                    Console.WriteLine("Vuosi on karkausvuosi ");
                }
                else
                {
                    Console.WriteLine("Vuosi ei ole karkausvuosi ");
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
