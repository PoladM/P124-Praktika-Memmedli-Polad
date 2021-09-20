using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Bycle : Vehicle2
    {
        public Bycle(string color, string brand, double millage) : base(color, brand, millage)
        {

        }

        public override void Drive2(double km)
        {
            Console.WriteLine($"{Brand} Getdiyi mesafe - {Millage + km}km");
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Showing Info");
            Console.WriteLine($"Brand: {Brand} - Color: {Color} - {Brand} surulub: {Millage}km.");
        }
    }
}
