using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat2
{
    class Pesukone
    {
        public string Merkki { get; set; }
        public int PyörintäNopeus { get; set; }
        public Pesukone()
        {

        }
        public Pesukone(string merkki)
        {
            Merkki = merkki;
        }
        public override string ToString()
        {
            return " Merkki: " + Merkki + " PyörintäNopeus: " + PyörintäNopeus;
        }
    }
}
