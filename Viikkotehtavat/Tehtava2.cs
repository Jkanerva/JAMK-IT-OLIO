using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program2
    {
        static void Main(string[] args)
        {
            //Tee ohjelma, jossa annetaan oppilaalle koulunumero seuraavan taulukon mukaan (pistemäärä kysytään ja ohjelma tulostaa numeron)
            int pisteet = 0;
            Console.WriteLine("Anna pistemaara ");
            string retval = Console.ReadLine();
            pisteet = int.Parse(Console.ReadLine());

            if (pisteet > 9)
            {
                Console.WriteLine("numero 5");
            }
            else if (pisteet > 7)
            {
                Console.WriteLine("numero 4");
            }
            else if (pisteet > 5)
            {
                Console.WriteLine("numero 3");
            }
            else if (pisteet > 3)
            {
                Console.WriteLine("numero 2");
            }
            else if (pisteet > 1)
            {
                Console.WriteLine("numero 1");
            }
            else
            {
                Console.WriteLine("numero 0");
            }
        }
    }
}