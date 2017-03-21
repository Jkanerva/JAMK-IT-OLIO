using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Vahvistin
    {
        const int maxvol = 100, minvol = 0;
        private int volyymi;
        public int Volyymi
        {
            get
            {
                return volyymi;
            }
            set
            {
                if (value > maxvol)
                {
                    Console.WriteLine("Liikaa volyymia -> Vahvistin on säädetty maksimiin : " + maxvol);
                    volyymi = maxvol;
                }
                else if (value < minvol)
                {
                    Console.WriteLine("Liian alhainen volyymi -> Vahvistin on säädetty minimiin : " + minvol);
                    volyymi = minvol;
                }
                else
                {
                    Console.WriteLine(" Vahvistin on säädetty alueelle : " + value);
                    volyymi = value;
                }
            }
        }
    }
}
