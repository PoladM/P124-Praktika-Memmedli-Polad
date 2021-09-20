using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    abstract class Vehicle2 
    {
        public string Color ;
        public string Brand ;
        public double Millage ;

        public Vehicle2(string color, string brand, double millage)
        {
            Color = color;
            Brand = brand;
            Millage = millage;
        }
        public virtual void ShowInfo()
        {
            
        }
        
        public abstract void Drive2(double km);
    }
}
