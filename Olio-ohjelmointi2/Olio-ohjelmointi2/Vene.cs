using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Vene : Ajoneuvo
    {
        public int IstuinPaikat { get; set; }
        public override string ToString()
        {
            return base.ToString() + " IstuinPaikat:" + IstuinPaikat;
        }
    }
}
