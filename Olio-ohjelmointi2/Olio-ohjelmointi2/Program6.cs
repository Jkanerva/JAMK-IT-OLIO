using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Program6
    {
        static void Main(string[] args)
        {
            // Jääkaappi
            Fridge fridge = new Fridge();
            Food food1 = new Food("Eggs");
            Food food2 = new Food("Milk");
            Food food3 = new Food("Meat");
            Food food4 = new Food("Salad");

            fridge.AddFood(food1);
            fridge.AddFood(food2);
            fridge.AddFood(food3);
            fridge.AddFood(food4);

            Console.WriteLine("In the fridge");
            foreach (Food i in fridge.Food)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("Drink milk");
            fridge.RemoveFood(food2);

            Console.WriteLine("In the fridge");
            foreach (Food i in fridge.Food)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
