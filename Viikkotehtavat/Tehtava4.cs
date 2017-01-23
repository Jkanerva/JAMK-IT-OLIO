using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minka ikainen olet? ");
            String line = Console.ReadLine();
            int ika;
            bool tulos = Int32.TryParse(line, out ika);
            if (tulos)
            {
                if (ika < 17) Console.WriteLine("Olet ala-ikainen ");
                else if (ika >= 18 && ika <= 65) Console.WriteLine("Olet taysi-ikainen ");
                else Console.WriteLine("Olet seniori ");
            } else
            {
                Console.WriteLine("Et antanut numeroa ");
            }
            Console.ReadLine();
        }
    }
}
