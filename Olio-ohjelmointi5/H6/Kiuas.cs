using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H6
{
    class kiuas
    {
        float temp = 0f;
        float humid = 0f;

        public float Temp { get { return temp; } }
        public float Humid { get { return humid; } }

        public void SetTemp(float f)
        {
            if (f >= 0 && f <= 120)
            {
                temp = f;
            }
        }
        public void SetHumid(float f)
        {
            if (f >= 0 && f <= 100)
            {
                humid = f;
            }
        }
    }
}
