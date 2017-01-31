using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat2
{
    class Program3
    {
        static void Main(string[] args)
        {
            // TV
            TV tv = new TV();
            tv.Merkki = "Samsung";
            tv.IsOpen = false;
            Console.WriteLine(tv.ToString());

            // tv auki
            tv.IsOpen = true;
            tv.Kanava = 4;
            tv.Ääni = 10;
            Console.WriteLine(tv.ToString());

            // tv kiinni
            tv.IsOpen = false;
            Console.WriteLine(tv.ToString());
        }
    }
}
