using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        public SuperList() : base() {} //Inherits the double's list

        public void GetMinMax1(out double min, out double max)
        {
            //They are the same for comparison purposes
            min = this[0]; 
            max = this[0]; 

            foreach(double n in this)
            {
                if (n < min) min = n; //Gets the minimum value

                else if (n > max) max = n; //Gets the maximum value
            }
        }
        public void GetMinMax2()
        {
            MinMax minmax = new MinMax();

           //They are the same for comparison purposes
            double min = this[0]; 
            double max = this[0];

            foreach(double n in this)
            {
                if (n < min) minmax.Min = n;

                else if (n > max) minmax.Max = n;
            }

            Console.WriteLine($"Min: {minmax.Min} | Max: {minmax.Max}");
        }
        public void GetMinMax3()
        {
            
        }
        public void GetMinMax4()
        {
            
        }

        public struct MinMax 
        {
            public double Min;
            public double Max;
        }
    }
}