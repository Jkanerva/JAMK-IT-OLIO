using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Ajoneuvo
    {
        public string Nimi { get; set; }
        public string Malli { get; set; }
        public int VuosiMalli { get; set; }
        public string Vari { get; set; }

        public override string ToString()
        {
            return "Nimi: " + Nimi + " Malli: " + Malli + " VuosiMalli: " + VuosiMalli + " Vari: " + Vari;
        }
    }
}
