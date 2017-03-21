using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Program2
    {
        static void Main(string[] args)
        {
            Vahvistin vahvistin = new Vahvistin();
            bool tulos;
            do
            {
                Console.WriteLine("Anna volyymi väliltä (0-100) > ");
                string line = Console.ReadLine();
                int volyymi = 0;
                tulos = int.TryParse(line, out volyymi);
                if (tulos)
                {
                    vahvistin.Volyymi = volyymi;
                }
            } while (tulos);
        }
    }
}
