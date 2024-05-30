using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public SuperList() : base() {}

        public void GetMinMax1(out double min, out double max)
        {
            min = this[0];
            max = this[0];

            foreach(double n in this)
            {
                if (n < min) min = n;

                else if (n > max) max = n;
            }
        }
        public void GetMinMax2()
        {
            
        }
        public void GetMinMax3()
        {
            
        }
        public void GetMinMax4()
        {
            
        }
    }
}