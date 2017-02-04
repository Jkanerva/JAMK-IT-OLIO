﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio_ohjelmointi2
{
    class Elevator
    {
        // min and max values
        private const int minFloor = 1;
        private const int maxFloor = 5;
        // first floor by default
        private int floor = 1;

        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value < minFloor)
                {
                    Console.WriteLine("Floor is too small!");
                }
                else if (value > maxFloor)
                {
                    Console.WriteLine("Floor is too big!");
                }
                else
                {
                    floor = value;
                }
            }
        }
    }
}
