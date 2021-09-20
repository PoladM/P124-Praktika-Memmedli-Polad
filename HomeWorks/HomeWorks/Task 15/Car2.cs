using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorks
{
    class Car2 : Vehicle2
    {
        public double FuelCapacity ;
        public double CurrentFuel ;
        public double FuelFor1Km ;


        public Car2(string color, string brand, double millage) : base(color, brand, millage)
        {
            FuelCapacity = 800;
            CurrentFuel = 300;
            FuelFor1Km = 5;
        }

        public override void Drive2(double km)
        {
            if (CurrentFuel / FuelFor1Km > km)
            {
                Console.WriteLine("Driving..");
                Console.WriteLine($"yanacaq - {CurrentFuel - (km * FuelFor1Km)}L");
                Console.WriteLine($"{Brand} Getdiyi mesafe - {Millage + km}km");
            }
            else
                Console.WriteLine("Yeterli yanacaq yoxur.");
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Showing Info");
            Console.WriteLine($"Brand: {Brand} - Color: {Color} - {Brand} surulub: {Millage}km.");
        }
    }
}
