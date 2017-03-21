using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi3
{
    class Program3
    {
        static void Main(string[] args)
        {
            List<Product> tuotteet = new List<Product>();

            tuotteet.Add(new Product { Nimi = "Maito", Hinta = 1.00 });
            tuotteet.Add(new Product { Nimi = "Makkara", Hinta = 1.25 });
            tuotteet.Add(new Product { Nimi = "Olut", Hinta = 1.50 });
            tuotteet.Add(new Product { Nimi = "Juusto", Hinta = 3.50 });

            Console.WriteLine("Tuotteet kokoelma:");
            foreach (Product product in tuotteet)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
