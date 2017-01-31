using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat2
{
    class TV
    {
        public string Merkki { get; set; }
        private bool isOpen;
        public bool IsOpen
        {
            get
            {
                return isOpen;
            }
            set
            {
                isOpen = value;
                if (value == false)
                {
                    Kanava = 0;
                    Ääni = 0;
                }
            }
        }
        public int Kanava { get; set; }
        public int Ääni { get; set; }
        public override string ToString()
        {
            return " Merkki " + Merkki + " Kanava " + Kanava + " Ääni " + Ääni;
        } 
    }
}
