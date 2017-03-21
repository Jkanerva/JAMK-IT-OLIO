using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Tyontekija
    {
        public string Nimi { get; set; }
        public string Ammatti { get; set; }
        public double Palkka { get; set; }

        public Tyontekija()
        {

        }
        public Tyontekija(string nimi, string ammatti, double palkka)
        {
            Nimi = nimi;
            Ammatti = ammatti;
            Palkka = palkka;
        }
        public override string ToString()
        {
            return " nimi: " + Nimi + " . Ammatti: " + " . Palkka : " + Palkka;
        }
    }
}
