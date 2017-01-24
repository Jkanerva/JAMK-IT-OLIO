using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat
{
    class Program10
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 33, 44, 55, 68, 77, 96, 100 };
            for (int i=0;i<array.Length;i++)
            {
                if (array[i] % 2 == 0) Console.WriteLine("HEP! {0} numero oli {1} ", i, array[1]);
            }
            Console.ReadLine();
        }
    }
}
