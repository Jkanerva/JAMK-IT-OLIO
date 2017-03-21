using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Program3
    {
        static void Main(string[] args)
        {
            // Tyontekija
            Tyontekija tyontekija = new Tyontekija();
            tyontekija.Nimi = "Jarkko";
            tyontekija.Ammatti = "Hitsaaja";
            tyontekija.Palkka = 2000;
            Console.WriteLine(tyontekija.ToString());

            // Pomo
            Pomo pomo = new Pomo();
            pomo.Nimi = "Markku";
            pomo.Ammatti = "Hitsaaja";
            pomo.Palkka = 3000;
            pomo.Auto = "BMW";
            pomo.Bonus = 1500;
            Console.WriteLine(pomo.ToString());
        }
    }
}
