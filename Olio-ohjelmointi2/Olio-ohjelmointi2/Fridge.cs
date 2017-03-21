using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Fridge
    {
        List<Food> food = new List<Food> ();
        public List<Food> Food
        {
            get
            {
                return food;
            }
        }
        public void AddFood (Food any)
        {
            food.Add(any);
        }
        public void RemoveFood (Food any)
        {
            food.Remove(any);
        }
    }
}
