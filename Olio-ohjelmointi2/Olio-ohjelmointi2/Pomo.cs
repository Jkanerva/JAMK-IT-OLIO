using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Pomo : Tyontekija
    {
        public string Auto { get; set; }
        public double Bonus { get; set; }

        public Pomo()
        {

        }

        public Pomo(string nimi, string ammatti, double palkka) 
            : base(nimi, ammatti, palkka)
        {

        }

        public override string ToString()
        {
            return base.ToString() + " Auto: " + Auto + " Bonus: " + Bonus;
        }
    }
}
