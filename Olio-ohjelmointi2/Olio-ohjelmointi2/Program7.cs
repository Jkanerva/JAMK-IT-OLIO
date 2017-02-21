using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Program7
    {
        static void Main(string[] args)
        {
            // CD
            CD cd = new CD();
            cd.Artist = "Popeda";
            cd.Name = "Ukkometso";
            cd.Genre = "Rock";

            cd.AddSong(new Song { Name = "Elän itselleni", LengthInSeconds = 428 });
            cd.AddSong(new Song { Name = "Mä elän vieläkin", LengthInSeconds = 303 });
            cd.AddSong(new Song { Name = "Kellot Lyö", LengthInSeconds = 359 });

            Console.WriteLine(cd.ToString());
            Console.WriteLine();
        }
    }
}
