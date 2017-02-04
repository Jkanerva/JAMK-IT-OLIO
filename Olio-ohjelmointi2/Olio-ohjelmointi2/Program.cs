using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Program
    {
        static void Main(string[] args)
        {
            Elevator elevator = new Elevator();
            bool result;
            do
            {
                // get elevator floor
                Console.WriteLine("Elevator is now in floor : " + elevator.Floor);
                // get a new floor
                Console.Write("Give a new floor number (1-5) > ");
                String line = Console.ReadLine();
                int floor;
                result = Int32.TryParse(line, out floor);
                if (result)
                {
                        // try to set a new floor
                        elevator.Floor = floor;
                }
            } while (result);

            Console.WriteLine("Press enter key to continue...");
            Console.ReadLine();
        }
    }
}