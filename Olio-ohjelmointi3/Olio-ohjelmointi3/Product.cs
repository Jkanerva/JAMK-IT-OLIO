using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi3
{
    class Product
    {
        public string Nimi { get; set; }
        public double Hinta { get; set; }
        
        public override string ToString()
        {
            return Nimi + "- product : " + Nimi + " "+Hinta+" e";
        }
    }
}
