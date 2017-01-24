using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program13
    {
        static void Main(string[] args)
        {
            int[] pisteet = new int[5];
            for (int i = 0; i < pisteet.Length; i++)
            {
                Console.WriteLine("Anna pisteet {0} ", (i + 1));
                string line = Console.ReadLine();
                int piste;
                bool tulos = Int32.TryParse(line, out piste);
                if (tulos)
                {
                    pisteet[i] = piste;
                }
                else
                {
                    Console.WriteLine("Et antanut lukua ");
                }
            }
            Array.Sort(pisteet);
            int summa = pisteet[1] + pisteet[2] + pisteet[3];
            Console.WriteLine("summa on " + summa);
            Console.ReadLine();
        }
    }
}
