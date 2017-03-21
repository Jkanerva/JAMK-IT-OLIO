using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Program5
    {
        static void Main(string[] args)
        {
            // Radio 1
            Radio radio = new Radio();
            radio.Volyymi = 100;
            radio.Taajuus = 2000;
            radio.Paalla = true;
            Console.WriteLine(radio.ToString());

            // Radio 2
            Radio radio2 = new Radio();
            radio2.Volyymi = 75;
            radio2.Taajuus = 5000;
            radio2.Paalla = true;
            Console.WriteLine(radio2.ToString());
        }
    }
}
