using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Program4
    {
        static void Main(string[] args)
        {
            // Pyora
            Pyora pyora = new Pyora();
            pyora.Nimi = "Nishiki";
            pyora.Malli = "maasto";
            pyora.VuosiMalli = 2014;
            pyora.Vari = "musta";
            pyora.Vaihteet = false;
            Console.WriteLine(pyora.ToString());

            // Vene
            Vene vene = new Vene();
            vene.Nimi = "Sini";
            vene.Malli = "S43";
            vene.VuosiMalli = 1965;
            vene.Vari = "Valkoinen";
            vene.IstuinPaikat = 4;
            Console.WriteLine(vene.ToString());
        }
    }
}
