using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viikkotehtavat2
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one heater object
            Heater heater = new Heater();
            // set some values
            heater.IsOn = true;
            heater.Temperature = 100;
            heater.Humidity = 78;
            // print values
            Console.WriteLine("Is heater on : {0}", heater.IsOn);
            Console.WriteLine("Heater temperature : {0}", heater.Temperature);
            Console.WriteLine("Heater humidity : {0}", heater.Humidity);

            // changes values
            heater.Temperature = 0;
            heater.Humidity = 0;
            heater.IsOn = false;
            // print values
            Console.WriteLine("Is heater on : {0}", heater.IsOn);
            Console.WriteLine("Heater temperature : {0}", heater.Temperature);
            Console.WriteLine("Heater humidity : {0}", heater.Humidity);
        }
    }
}
