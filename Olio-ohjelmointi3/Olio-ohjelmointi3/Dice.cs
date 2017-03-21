using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi3
{
    class Dice
    {
        private static readonly Random staticRand = new Random();

        public static int Throw()
        {
            return staticRand.Next(6) + 1;
        }
    }
}
