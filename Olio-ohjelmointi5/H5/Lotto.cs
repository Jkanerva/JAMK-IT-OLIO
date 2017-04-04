using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5
{
    class Lotto
    {
        private Random rand = new Random();

        public List<int> getRandomNumbers(string type)
        {
 
            int largestNumber = 39;
            int numberAmount = 7;

            if (type.Equals("Lotto"))
            {
                largestNumber = 39;
                numberAmount = 7;
            }
            else if (type.Equals("Viking Lotto"))
            {
                largestNumber = 48;
                numberAmount = 6;
            }
            else if (type.Equals("Eurojackpot"))
            {
                largestNumber = 50;
                numberAmount = 5;
            }

            List<int> numbers = new List<int>();
            do
            {
                int number = rand.Next(1, largestNumber + 1);
                if (!numbers.Contains(number)) numbers.Add(number);
            } while (numbers.Count < numberAmount);

            numbers.Sort();

            if (type.Equals("Eurojackpot"))
            {
                List<int> starNumbers = new List<int>();
                do
                {
                    int number = rand.Next(1, 11);
                    if (!starNumbers.Contains(number)) starNumbers.Add(number);
                } while (starNumbers.Count < 2);

                starNumbers.Sort();
                numbers.AddRange(starNumbers);
            }
            return numbers;
        }
    }
}
