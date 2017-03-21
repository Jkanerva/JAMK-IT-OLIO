using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Pyora : Ajoneuvo
    {
        public bool Vaihteet { get; set; }
        public override string ToString()
        {
            return base.ToString() + " Vaihteet:" + Vaihteet;
        }
    }
}
