using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Radio
    {
        private bool paalla;
        private float taajuus;
        private int volyymi;

        public bool Paalla
        {
            get { return paalla; }
            set { paalla = value; }
        }
        public float Taajuus
        {
            get { return taajuus; }
            set
            {
                if (value >= 2000 && value <= 26000)
                {
                    taajuus = value;
                }
            }
        }
        public int Volyymi
        {
            get { return volyymi; }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    volyymi = value;
                }
            }
        }
        public override string ToString()
        {
            return "Päällä: " + paalla + ". Taajuus: " + Taajuus + ". Volyymi: " + Volyymi;
        }
    }
}
