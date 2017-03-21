using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi3
{
    class Fish
    {
        public string Nimi { get; set; }
        public double Pituus { get; set; }
        public double Paino { get; set; }

        public Fish(string nimi, double pituus, double paino)
        {
            Nimi = nimi;
            Pituus = pituus;
            Paino = paino;
        }

        public override string ToString()
        {
            return Nimi + ", " + Pituus + ", " + Paino;
        }
    }
}
