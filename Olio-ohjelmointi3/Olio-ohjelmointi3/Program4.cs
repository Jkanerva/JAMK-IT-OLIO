using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi3
{
    class Program4
    {
        static void Main(string[] args)
        {
            List<Elio> rekisteri = new List<Elio>();

            rekisteri.Add(new Fish("Ahven"));
            rekisteri.Add(new Fish("Kuha"));
            rekisteri.Add(new Fish("Hauki"));
            rekisteri.Add(new Fisher("Matti", "046043023"));
            rekisteri.Add(new Place("Jyväskylä"));

            Console.WriteLine("rekisteri:");
            foreach (Product Elio in rekisteri)
            {
                Console.WriteLine(Elio.ToString());
            }
        }
    }
}
