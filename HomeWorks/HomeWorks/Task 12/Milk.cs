using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Milk : Product
    {
        public double Volume;
        public double FatRate;

        public Milk(double volume, double fatrate, string name) : base(name)
        {
            Volume = volume;
            FatRate = fatrate;
        }
    }
}
