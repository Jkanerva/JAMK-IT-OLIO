using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi3
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Dice, yhden testiheiton arvo on " + Dice.Throw());

            Console.Write(" Kuinka monta kertaa haluat heittää dice : ");
            string line = Console.ReadLine();
            int times = int.Parse(line);

            double sum = 0;
            int value;
            int[] values = new int[7];
            for (int i = 1; i <= times; i++)
            {
                value = Dice.Throw();
                sum += value;
                values[value]++;
            }

            Console.WriteLine();
            Console.WriteLine("Dice on heittänyt {0} kertaa", times);
            Console.WriteLine("- Keskiarvo on {0}", sum / times);
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine("- {0} luku on {1}", i, values[i]);
            }
        }
    }
}
